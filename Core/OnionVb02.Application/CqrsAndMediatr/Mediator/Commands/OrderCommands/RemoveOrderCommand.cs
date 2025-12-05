using MediatR;

public class RemoveOrderCommand : IRequest
{
    public int Id { get; set; }

    public RemoveOrderCommand(int id)
    {
        Id = id;
    }
}
