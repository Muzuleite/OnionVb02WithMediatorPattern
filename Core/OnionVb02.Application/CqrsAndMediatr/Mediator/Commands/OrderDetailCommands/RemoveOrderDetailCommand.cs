using MediatR;

public class RemoveOrderDetailCommand : IRequest
{
    public int Id { get; set; }

    public RemoveOrderDetailCommand(int id)
    {
        Id = id;
    }
}
