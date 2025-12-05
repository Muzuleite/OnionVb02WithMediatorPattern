using MediatR;

public class CreateProductCommand : IRequest
{
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
}
