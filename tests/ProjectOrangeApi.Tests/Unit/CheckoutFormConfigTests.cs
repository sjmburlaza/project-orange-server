using System.Text.Json;
using ProjectOrangeApi.DTOs;
using Xunit;

namespace ProjectOrangeApi.Tests.Unit;

public class CheckoutFormConfigTests
{
    [Theory]
    [InlineData("fr", "fr-1.1")]
    [InlineData("jp", "jp-1.1")]
    [InlineData("cn", "cn-1.1")]
    public async Task SiteCheckoutForm_DeserializesIntoDto(string siteCode, string expectedVersion)
    {
        var form = await ReadSiteFormAsync(siteCode);

        Assert.Equal(expectedVersion, form.Version);
        Assert.NotEmpty(form.Steps);
        Assert.Contains(form.Steps, step => step.Id == "customer");
        Assert.Contains(form.Steps, step => step.Id == "shipping");
        Assert.Contains(form.Steps, step => step.Id == "payment");
    }

    [Fact]
    public async Task FranceCheckoutForm_UsesFrenchAddressFields()
    {
        var form = await ReadSiteFormAsync("fr");
        var deliveryAddress = GetCustomerGroup(form, "deliveryAddress");

        Assert.Contains(deliveryAddress.Fields, field => field.Name == "companyName");
        Assert.Contains(deliveryAddress.Fields, field => field.Name == "addressLine3");
        Assert.DoesNotContain(deliveryAddress.Fields, field => field.Name == "region");
        Assert.True(HasValidator(GetGroupField(deliveryAddress, "postalCode"), "maxLength", 5));
    }

    [Fact]
    public async Task JapanCheckoutForm_CollectsKanaNamesAndBuildingDetails()
    {
        var form = await ReadSiteFormAsync("jp");
        var customerFields = GetCustomerFields(form);
        var billingAddress = GetCustomerGroup(form, "billingAddress");

        Assert.Contains(customerFields, field => field.Name == "lastNameKana");
        Assert.Contains(customerFields, field => field.Name == "firstNameKana");
        Assert.Contains(GetCustomerGroup(form, "deliveryAddress").Fields, field => field.Name == "deliveryInstructions");
        Assert.Contains(billingAddress.Fields, field => field.Name == "addressLine2");
    }

    [Fact]
    public async Task ChinaCheckoutForm_UsesFullNameAndAdministrativeAddressFields()
    {
        var form = await ReadSiteFormAsync("cn");
        var customerFields = GetCustomerFields(form);
        var deliveryAddress = GetCustomerGroup(form, "deliveryAddress");
        var billingAddress = GetCustomerGroup(form, "billingAddress");

        Assert.Contains(customerFields, field => field.Name == "fullName");
        Assert.DoesNotContain(customerFields, field => field.Name == "firstName");
        Assert.DoesNotContain(customerFields, field => field.Name == "lastName");

        AssertRequiredField(deliveryAddress, "recipientName");
        AssertRequiredField(deliveryAddress, "region");
        AssertRequiredField(deliveryAddress, "city");
        AssertRequiredField(deliveryAddress, "district");
        AssertRequiredField(deliveryAddress, "street");
        AssertRequiredField(deliveryAddress, "addressLine1");
        AssertRequiredField(deliveryAddress, "postalCode");

        AssertRequiredField(billingAddress, "district");
        AssertRequiredField(billingAddress, "street");
    }

    private static async Task<CheckoutFormDto> ReadSiteFormAsync(string siteCode)
    {
        var path = Path.Combine(
            FindRepoRoot(),
            "src",
            "ProjectOrange.Api",
            "Config",
            "sites",
            siteCode,
            "checkout-form.json");

        await using var stream = File.OpenRead(path);
        var form = await JsonSerializer.DeserializeAsync<CheckoutFormDto>(
            stream,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        Assert.NotNull(form);
        return form!;
    }

    private static string FindRepoRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);

        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory.FullName, "ProjectOrangeApi.sln")))
            {
                return directory.FullName;
            }

            directory = directory.Parent;
        }

        throw new DirectoryNotFoundException("Could not locate ProjectOrangeApi.sln.");
    }

    private static List<CheckoutFieldDto> GetCustomerFields(CheckoutFormDto form)
    {
        return form.Steps.Single(step => step.Id == "customer").Fields;
    }

    private static CheckoutFieldDto GetCustomerGroup(CheckoutFormDto form, string groupName)
    {
        return GetCustomerFields(form).Single(field => field.Name == groupName);
    }

    private static CheckoutFieldDto GetGroupField(CheckoutFieldDto group, string fieldName)
    {
        return group.Fields.Single(field => field.Name == fieldName);
    }

    private static void AssertRequiredField(CheckoutFieldDto group, string fieldName)
    {
        Assert.True(HasValidator(GetGroupField(group, fieldName), "required"));
    }

    private static bool HasValidator(CheckoutFieldDto field, string name, int? value = null)
    {
        var validator = field.Validators.FirstOrDefault(candidate => candidate.Name == name);

        if (validator is null)
        {
            return false;
        }

        if (!value.HasValue)
        {
            return true;
        }

        return validator.Value switch
        {
            JsonElement element when element.ValueKind == JsonValueKind.Number =>
                element.TryGetInt32(out var number) && number == value.Value,
            int number => number == value.Value,
            long number => number == value.Value,
            _ => false
        };
    }
}
