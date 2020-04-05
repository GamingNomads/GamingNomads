using GamingNomads.Api.Models;
using GamingNomads.Shared.EventManager;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace GamingNomads.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        //public EventsController()
        //{

        //}

        public EventsController(IEventRepository eventsRepository)
        {
            _eventRepository = eventsRepository;
        }

        /// <summary>
        /// GET api/Events
        /// </summary>
        /// <returns>All Events (Shows)</returns>
        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(_eventRepository.GetAllEvents());
        }

        /// <summary>
        /// GET api/Events/{id}
        /// </summary>
        /// <param name="id">The id of the event to get</param>
        /// <returns>Event (Show) instance</returns>
        [HttpGet("{id}")]
        public IActionResult GetEventById(int id)
        {
            return Ok(_eventRepository.GetEventById(id));
        }

        [HttpPost]
        public IActionResult CreateEvent([FromBody] Show show)
        {
            if (show == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrWhiteSpace(show.Name))
            {
                ModelState.AddModelError("EventName", "The Event Name shouldn't be empty");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdEvent = _eventRepository.AddEvent(show);

            return Created("show", createdEvent);
        }

        [HttpPut]
        public IActionResult UpdateEvent([FromBody] Show show)
        {
            if (show == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrWhiteSpace(show.Name))
            {
                ModelState.AddModelError("EventName", "The Event Name shouldn't be empty");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eventToUpdate = _eventRepository.GetEventById(show.Id);

            if (eventToUpdate == null)
            {
                return NotFound();
            }

            _eventRepository.UpdateEvent(show);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var eventToDelete = _eventRepository.DeleteEvent(id);

            return NoContent(); //success
        }
    }
}