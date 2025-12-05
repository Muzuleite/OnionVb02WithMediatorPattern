using MediatR;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Domain.Enums;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Modify.ProductCommandHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _repository;

        public UpdateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            Product value = await _repository.GetByIdAsync(request.Id);

            value.ProductName = request.ProductName;
            value.UnitPrice = request.UnitPrice;
            value.UpdatedDate = DateTime.Now;
            value.Status = DataStatus.Updated;

            await _repository.SaveChangesAsync();
        }
    }
}
