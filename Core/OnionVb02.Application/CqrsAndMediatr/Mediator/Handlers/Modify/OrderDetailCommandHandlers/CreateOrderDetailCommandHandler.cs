using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.OrderDetailCommandHandlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand>
    {
        private readonly IOrderDetailRepository _repository;

        public CreateOrderDetailCommandHandler(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                CreatedDate = DateTime.Now,
                Status = DataStatus.Inserted,
                OrderId = request.OrderId,
                ProductId = request.ProductId
            });
        }
    }
}
