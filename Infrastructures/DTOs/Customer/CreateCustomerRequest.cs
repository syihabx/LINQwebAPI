namespace Infrastructure.DTOs;

public class CreateCustomerRequest
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Address { get; set; }
}