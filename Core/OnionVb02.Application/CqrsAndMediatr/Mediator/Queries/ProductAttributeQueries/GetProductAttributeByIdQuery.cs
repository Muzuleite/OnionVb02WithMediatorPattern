using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.ProductAttributeQueries
{
    public class GetProductAttributeByIdQuery : IRequest<GetProductAttributeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductAttributeByIdQuery(int id)
        {
            Id = id;
        }
    }

    public class GetProductAttributeQuery : IRequest<List<GetProductAttributeQueryResult>>
    {
    }

}
