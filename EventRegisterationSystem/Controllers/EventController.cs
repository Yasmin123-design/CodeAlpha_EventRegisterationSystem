using EventRegisterationSystem.Models;
using EventRegisterationSystem.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventRegisterationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase

    {
        private readonly IEventRepository eventRepository;
        public EventController(IEventRepository _eventRepository)
        {
            eventRepository = _eventRepository;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Event> events = eventRepository.GetAll();
            return Ok(events);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Event @event = eventRepository.GetById(id);
            if(@event == null)
            {
                return NotFound("event not found");
            }
            return Ok(@event);
        }
        [HttpPost("Add")]
        public IActionResult Add(Event @event)
        {
            eventRepository.AddEvent(@event);
            return Ok(@event);
        }
    }
}
