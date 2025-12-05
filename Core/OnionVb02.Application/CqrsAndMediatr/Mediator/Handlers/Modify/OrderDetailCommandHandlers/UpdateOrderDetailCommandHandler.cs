using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderDetailCommandHandlers
{
    public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommand>
    {
        private readonly IOrderDetailRepository _repository;

        public UpdateOrderDetailCommandHandler(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            OrderDetail value = await _repository.GetByIdAsync(request.Id);

            value.OrderId = request.OrderId;
            value.ProductId = request.ProductId;
            value.UpdatedDate = DateTime.Now;
            value.Status = DataStatus.Updated;

            await _repository.SaveChangesAsync();
        }
    }
}
