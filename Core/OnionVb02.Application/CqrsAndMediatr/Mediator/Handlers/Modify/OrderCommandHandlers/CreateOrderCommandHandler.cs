using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderCommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IOrderRepository _repository;

        public CreateOrderCommandHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Order
            {
                CreatedDate = DateTime.Now,
                Status = DataStatus.Inserted,
                ShippingAddress = request.ShippingAddress,
            });
        }
    }
}
