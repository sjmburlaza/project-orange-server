namespace ProjectOrangeApi.DTOs;

public class PostalCodeValidationDto
{
	public bool IsValid { get; set; }
	public string? Message { get; set; }
}