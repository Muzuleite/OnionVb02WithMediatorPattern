using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.AppUserProfileCommandHandlers
{
    public class CreateAppUserProfileCommandHandler : IRequestHandler<CreateAppUserProfileCommand>
    {
        private readonly IAppUserProfileRepository _repository;

        public CreateAppUserProfileCommandHandler(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUserProfile
            {
                CreatedDate = DateTime.Now,
                Status = DataStatus.Inserted,
                FirstName = request.FirstName,
                LastName = request.LastName,
            });
        }
    }
}