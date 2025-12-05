using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserProfileQueries;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;

namespace OnionVb02.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUserProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProfileList()
        {
            var values = await _mediator.Send(new GetAppUserProfileQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var value = await _mediator.Send(new GetAppUserProfileByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfile(CreateAppUserProfileCommand command)
        {
            await _mediator.Send(command);
            return Ok("Profil oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProfile(UpdateAppUserProfileCommand command)
        {
            await _mediator.Send(command);
            return Ok("Profil güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProfile(int id)
        {
            await _mediator.Send(new RemoveAppUserProfileCommand(id));
            return Ok("Profil silindi");
        }
    }
}
