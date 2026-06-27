namespace ProjectOrangeApi.DTOs;

public class CheckoutFormDto
{
    public string Version { get; set; } = "";
    public List<CheckoutStepDto> Steps { get; set; } = [];
}

public class CheckoutStepDto
{
    public string Id { get; set; } = "";
    public string Label { get; set; } = "";
    public List<CheckoutFieldDto> Fields { get; set; } = [];
}

public class CheckoutFieldDto
{
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";
    public string Label { get; set; } = "";
    public object? DefaultValue { get; set; }
    public List<FieldValidatorDto> Validators { get; set; } = [];
    public List<FieldValidatorDto> AsyncValidators { get; set; } = [];

    public GridDto? Grid { get; set; }
    public List<CheckoutFieldDto> Fields { get; set; } = [];
    public string? OptionsApi { get; set; }
    public string? DependsOn { get; set; }
    public VisibleIfDto? VisibleIf { get; set; }

    public List<FieldOptionDto>? Options { get; set; }
}

public class FieldValidatorDto
{
    public string Name { get; set; } = "";
    public object? Value { get; set; }
}

public class FieldOptionDto
{
    public string Label { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public decimal? Price { get; set; }
    public string? Icon { get; set; }
}

public class GridDto
{
    public int Mobile { get; set; }
    public int Desktop { get; set; }
}

public class VisibleIfDto
{
    public string Field { get; set; } = "";
    public object? Value { get; set; }
}