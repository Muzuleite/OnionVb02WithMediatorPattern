using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;
using System.Collections.Generic;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.OrderDetailQueries
{
    public class GetOrderDetailByIdQuery : IRequest<GetOrderDetailByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
