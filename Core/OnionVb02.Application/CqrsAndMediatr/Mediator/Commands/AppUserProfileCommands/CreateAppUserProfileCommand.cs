using MediatR;

public class CreateAppUserProfileCommand : IRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
