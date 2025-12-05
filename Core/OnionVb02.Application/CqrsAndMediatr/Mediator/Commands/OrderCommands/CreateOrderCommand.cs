using MediatR;

public class CreateOrderCommand : IRequest
{
    public string ShippingAddress { get; set; }
}
