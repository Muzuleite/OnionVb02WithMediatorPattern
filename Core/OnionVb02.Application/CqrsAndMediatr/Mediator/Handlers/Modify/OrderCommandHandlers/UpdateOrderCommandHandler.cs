using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderCommandHandlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IOrderRepository _repository;

        public UpdateOrderCommandHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            Order value = await _repository.GetByIdAsync(request.Id);

            value.ShippingAddress = request.ShippingAddress;
            value.UpdatedDate = DateTime.Now;
            value.Status = DataStatus.Updated;

            await _repository.SaveChangesAsync();
        }
    }
}
