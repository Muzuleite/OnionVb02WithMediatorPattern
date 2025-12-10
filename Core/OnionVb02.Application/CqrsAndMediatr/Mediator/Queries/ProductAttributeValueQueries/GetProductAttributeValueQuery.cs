using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeValueQueries
{
    public class GetProductAttributeValueQuery : IRequest<List<GetProductAttributeValueQueryResult>>
    {
    }
}
