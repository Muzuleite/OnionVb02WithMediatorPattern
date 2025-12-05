using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;
using System.Collections.Generic;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserProfileQueries
{
    public class GetAppUserProfileByIdQuery : IRequest<GetAppUserProfileByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAppUserProfileByIdQuery(int id)
        {
            Id = id;
        }
    }
}
