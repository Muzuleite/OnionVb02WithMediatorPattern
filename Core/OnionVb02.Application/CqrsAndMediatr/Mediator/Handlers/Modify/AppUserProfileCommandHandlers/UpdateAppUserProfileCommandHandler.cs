using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.AppUserProfileCommandHandlers
{
    public class UpdateAppUserProfileCommandHandler : IRequestHandler<UpdateAppUserProfileCommand>
    {
        private readonly IAppUserProfileRepository _repository;

        public UpdateAppUserProfileCommandHandler(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            AppUserProfile value = await _repository.GetByIdAsync(request.Id);

            value.FirstName = request.FirstName;
            value.LastName = request.LastName;
            value.UpdatedDate = DateTime.Now;
            value.Status = DataStatus.Updated;

            await _repository.SaveChangesAsync();
        }
    }
}