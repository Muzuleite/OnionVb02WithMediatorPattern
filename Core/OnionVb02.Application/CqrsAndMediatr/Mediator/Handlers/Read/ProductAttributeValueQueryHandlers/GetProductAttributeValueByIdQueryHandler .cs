using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeValueQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Handlers.Read.ProductAttributeValueQueryHandlers
{
    public class GetProductAttributeValueByIdQueryHandler : IRequestHandler<GetProductAttributeValueByIdQuery, GetProductAttributeValueByIdQueryResult>
    {
        private readonly IProductAttributeValueRepository _repository;

        public GetProductAttributeValueByIdQueryHandler(IProductAttributeValueRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetProductAttributeValueByIdQueryResult> Handle(GetProductAttributeValueByIdQuery request, CancellationToken cancellationToken)
        {
            ProductAttributeValue value = await _repository.GetByIdAsync(request.Id);
            return new GetProductAttributeValueByIdQueryResult
            {
                Id = value.Id,
                ProductId = value.ProductId,
                ProductAttributeId = value.ProductAttributeId,
                Value = value.Value,
            };
        }
    }

}
