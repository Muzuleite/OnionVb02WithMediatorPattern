using MediatR;

public class CreateOrderDetailCommand : IRequest
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
}
