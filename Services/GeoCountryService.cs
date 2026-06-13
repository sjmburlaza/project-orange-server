using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Primitives;

namespace ProjectOrangeApi.Services;

public sealed class GeoCountryService
{
    private static readonly string[] CountryHeaderNames =
    [
        "CF-IPCountry",
        "X-Vercel-IP-Country",
        "CloudFront-Viewer-Country",
        "X-Azure-ClientIPCountry",
        "X-AppEngine-Country",
        "X-Country-Code",
        "X-Geo-Country"
    ];

    private static readonly string[] ClientIpHeaderNames =
    [
        "CF-Connecting-IP",
        "True-Client-IP",
        "X-Real-IP",
        "X-Forwarded-For",
        "Forwarded"
    ];

    private readonly HttpClient _httpClient;

    public GeoCountryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string?> GetCountryCodeAsync(
        HttpContext httpContext,
        CancellationToken cancellationToken)
    {
        var countryFromHeader = GetCountryCodeFromHeaders(httpContext.Request.Headers);

        if (countryFromHeader is not null)
        {
            return countryFromHeader;
        }

        var clientIp = GetPublicClientIp(httpContext);

        if (clientIp is null)
        {
            return null;
        }

        return await LookupCountryCodeByIpAsync(clientIp, cancellationToken);
    }

    private static string? GetCountryCodeFromHeaders(IHeaderDictionary headers)
    {
        foreach (var headerName in CountryHeaderNames)
        {
            if (!headers.TryGetValue(headerName, out var values))
            {
                continue;
            }

            foreach (var value in values)
            {
                var normalizedCode = NormalizeCountryCode(value);

                if (normalizedCode is not null)
                {
                    return normalizedCode;
                }
            }
        }

        return null;
    }

    private static IPAddress? GetPublicClientIp(HttpContext httpContext)
    {
        foreach (var headerName in ClientIpHeaderNames)
        {
            if (!httpContext.Request.Headers.TryGetValue(headerName, out var values))
            {
                continue;
            }

            var ip = headerName.Equals("Forwarded", StringComparison.OrdinalIgnoreCase)
                ? GetPublicIpFromForwardedHeader(values)
                : GetPublicIpFromHeaderValues(values);

            if (ip is not null)
            {
                return ip;
            }
        }

        var remoteIp = httpContext.Connection.RemoteIpAddress;

        if (remoteIp is null)
        {
            return null;
        }

        if (remoteIp.IsIPv4MappedToIPv6)
        {
            remoteIp = remoteIp.MapToIPv4();
        }

        return IsPublicIpAddress(remoteIp) ? remoteIp : null;
    }

    private static IPAddress? GetPublicIpFromForwardedHeader(StringValues values)
    {
        foreach (var value in values)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                continue;
            }

            foreach (var forwardedEntry in value.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                foreach (var parameter in forwardedEntry.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
                {
                    var parts = parameter.Split('=', 2, StringSplitOptions.TrimEntries);

                    if (parts.Length != 2 ||
                        !parts[0].Equals("for", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    var ip = ParsePublicIp(parts[1]);

                    if (ip is not null)
                    {
                        return ip;
                    }
                }
            }
        }

        return null;
    }

    private static IPAddress? GetPublicIpFromHeaderValues(StringValues values)
    {
        foreach (var value in values)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                continue;
            }

            foreach (var candidate in value.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                var ip = ParsePublicIp(candidate);

                if (ip is not null)
                {
                    return ip;
                }
            }
        }

        return null;
    }

    private async Task<string?> LookupCountryCodeByIpAsync(
        IPAddress ipAddress,
        CancellationToken cancellationToken)
    {
        try
        {
            var ip = Uri.EscapeDataString(ipAddress.ToString());
            var response = await _httpClient.GetStringAsync(
                $"https://ipapi.co/{ip}/country/",
                cancellationToken);

            return NormalizeCountryCode(response);
        }
        catch (HttpRequestException)
        {
            return null;
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            return null;
        }
    }

    private static IPAddress? ParsePublicIp(string candidate)
    {
        var value = candidate.Trim().Trim('"');

        if (value.Length == 0 ||
            value.Equals("unknown", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        if (value.StartsWith('['))
        {
            var closingBracketIndex = value.IndexOf(']');

            if (closingBracketIndex > 0)
            {
                value = value[1..closingBracketIndex];
            }
        }
        else if (value.Count(c => c == ':') == 1)
        {
            var portSeparatorIndex = value.LastIndexOf(':');

            if (portSeparatorIndex > 0)
            {
                value = value[..portSeparatorIndex];
            }
        }

        if (!IPAddress.TryParse(value, out var ipAddress))
        {
            return null;
        }

        if (ipAddress.IsIPv4MappedToIPv6)
        {
            ipAddress = ipAddress.MapToIPv4();
        }

        return IsPublicIpAddress(ipAddress) ? ipAddress : null;
    }

    private static string? NormalizeCountryCode(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        var code = value.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .FirstOrDefault()?
            .Trim()
            .Trim('"')
            .ToLowerInvariant();

        if (string.IsNullOrWhiteSpace(code) ||
            code is "xx" or "unknown")
        {
            return null;
        }

        return code.Length == 2 && code.All(c => c is >= 'a' and <= 'z')
            ? code
            : null;
    }

    private static bool IsPublicIpAddress(IPAddress ipAddress)
    {
        if (IPAddress.IsLoopback(ipAddress) ||
            ipAddress.Equals(IPAddress.Any) ||
            ipAddress.Equals(IPAddress.IPv6Any) ||
            ipAddress.Equals(IPAddress.None) ||
            ipAddress.Equals(IPAddress.IPv6None))
        {
            return false;
        }

        return ipAddress.AddressFamily switch
        {
            AddressFamily.InterNetwork => IsPublicIpv4(ipAddress.GetAddressBytes()),
            AddressFamily.InterNetworkV6 => IsPublicIpv6(ipAddress.GetAddressBytes()),
            _ => false
        };
    }

    private static bool IsPublicIpv4(byte[] bytes)
    {
        return bytes[0] switch
        {
            0 => false,
            10 => false,
            100 when bytes[1] is >= 64 and <= 127 => false,
            127 => false,
            169 when bytes[1] == 254 => false,
            172 when bytes[1] is >= 16 and <= 31 => false,
            192 when bytes[1] == 0 => false,
            192 when bytes[1] == 168 => false,
            198 when bytes[1] is 18 or 19 => false,
            198 when bytes[1] == 51 && bytes[2] == 100 => false,
            203 when bytes[1] == 0 && bytes[2] == 113 => false,
            >= 224 => false,
            _ => true
        };
    }

    private static bool IsPublicIpv6(byte[] bytes)
    {
        if (bytes[0] == 0xff ||
            (bytes[0] & 0xfe) == 0xfc ||
            bytes[0] == 0xfe && (bytes[1] & 0xc0) == 0x80)
        {
            return false;
        }

        return !(bytes[0] == 0x20 &&
            bytes[1] == 0x01 &&
            bytes[2] == 0x0d &&
            bytes[3] == 0xb8);
    }
}
