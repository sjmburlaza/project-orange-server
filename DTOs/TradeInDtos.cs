namespace ProjectOrangeApi.DTOs;

public class TradeInDto
{
    public List<StepHeaderDto> StepsHeader { get; set; } = [];
    public StepOneDescriptionDto StepOneDescription { get; set; } = new();
    public string FooterText { get; set; } = string.Empty;
}

public class StepOneDescriptionDto
{
    public string Title { get; set; } = string.Empty;
    public object? Content { get; set; }
    public string Note { get; set; } = string.Empty;
}

public class StepHeaderDto
{
    public string Label { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Subtext { get; set; }
}

public class TradeInStepDto
{
    public int Id { get; set; }
    public List<StepOneFieldDto>? StepOne { get; set; }
    public TradeInFormDataDto? FormData { get; set; }
    public StepOneSummaryDto? Summary { get; set; }
    public StepTwoDto? StepTwo { get; set; }
    public List<StepThreeFieldDto>? StepThree { get; set; }
    public StepFourDto? StepFour { get; set; }
}

public class UpdateTradeInStepOneRequest
{
    public List<StepOneFieldDto>? StepOne { get; set; }
    public TradeInFormDataDto? FormData { get; set; }
    public StepOneSummaryDto? Summary { get; set; }
}

public class UpdateTradeInStepTwoRequest
{
    public StepTwoDto? StepTwo { get; set; }
}

public class UpdateTradeInStepThreeRequest
{
    public List<StepThreeFieldDto>? StepThree { get; set; }
}

public class TradeInSessionDto
{
    public string SessionId { get; set; } = string.Empty;
    public string SiteCode { get; set; } = string.Empty;
    public int CurrentStep { get; set; } = 1;
    public List<StepOneFieldDto>? StepOne { get; set; }
    public TradeInFormDataDto? FormData { get; set; }
    public StepOneSummaryDto? Summary { get; set; }
    public StepTwoDto? StepTwo { get; set; }
    public List<StepThreeFieldDto>? StepThree { get; set; }
    public StepFourDto? StepFour { get; set; }
    public bool IsConfirmed { get; set; }
    public DateTimeOffset CreatedAtUtc { get; set; }
    public DateTimeOffset UpdatedAtUtc { get; set; }
}

public class CreateTradeInSessionRequest
{
    public string? CartCode { get; set; }
    public int? ProductId { get; set; }
}

public class TradeInFormDataDto
{
    public string PostalCode { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Device { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;
}

public class StepOneSummaryDto
{
    public string Brand { get; set; } = string.Empty;
    public string Device { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;
    public decimal FinalAmount { get; set; }
}

public class StepOneFieldDto
{
    public string Title { get; set; } = string.Empty;
    public string FieldName { get; set; } = string.Empty;
    public string Placeholder { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public object? Options { get; set; }
}

public class StepTwoDto
{
    public string Text1 { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string IconText { get; set; } = string.Empty;
    public string Text2 { get; set; } = string.Empty;
    public ImeiFieldDto Imei { get; set; } = new();
}

public class ImeiFieldDto
{
    public string Label { get; set; } = string.Empty;
    public string Placeholder { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}

public class StepThreeFieldDto
{
    public string Code { get; set; } = string.Empty;
    public string Question { get; set; } = string.Empty;
    public string Info { get; set; } = string.Empty;
    public string Response { get; set; } = string.Empty;
}

public class StepFourDto
{
    public string BoxHeader { get; set; } = string.Empty;
    public string BoxSubtext { get; set; } = string.Empty;
    public string Disclaimer { get; set; } = string.Empty;
    public string TncHeader { get; set; } = string.Empty;
    public string TncText1 { get; set; } = string.Empty;
    public string TncText2 { get; set; } = string.Empty;
}

public class CategoryTIDto
{
    public string Category { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

public class BrandTIDto
{
    public string BrandName { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string CategoryCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

public class DeviceTIDto
{
    public string DeviceName { get; set; } = string.Empty;
    public string BrandName { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string CategoryCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

public class StorageTIDto
{
    public string Size { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string DeviceCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
