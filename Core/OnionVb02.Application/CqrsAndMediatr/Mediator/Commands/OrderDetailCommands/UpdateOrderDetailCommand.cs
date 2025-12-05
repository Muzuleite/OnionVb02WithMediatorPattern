using MediatR;

public class UpdateOrderDetailCommand : IRequest
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
}
