using MediatR;

public class UpdateOrderCommand : IRequest
{
    public int Id { get; set; }
    public string ShippingAddress { get; set; }
}
