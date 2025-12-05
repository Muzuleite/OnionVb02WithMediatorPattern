using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;
using System.Collections.Generic;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderQueries
{
    public class GetOrderByIdQuery : IRequest<GetOrderByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
