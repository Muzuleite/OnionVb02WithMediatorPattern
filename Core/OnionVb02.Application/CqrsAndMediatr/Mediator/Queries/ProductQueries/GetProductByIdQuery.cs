using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;
using System.Collections.Generic;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductQueries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
