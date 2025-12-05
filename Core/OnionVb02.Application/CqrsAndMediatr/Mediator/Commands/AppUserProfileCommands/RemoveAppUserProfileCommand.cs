using MediatR;

public class RemoveAppUserProfileCommand : IRequest
{
    public int Id { get; set; }

    public RemoveAppUserProfileCommand(int id)
    {
        Id = id;
    }
}
