using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VanRijtDataBase.Dtos.Event;

namespace VanRijtDataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenementController : ControllerBase
    {

        private readonly IEventService _eventService;

        public EvenementController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Evenement>>> PostEvent(PostEventDto evenement)
        {
            return Ok(await _eventService.PostEvent(evenement));
        }

    }
}
