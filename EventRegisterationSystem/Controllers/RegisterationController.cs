using EventRegisterationSystem.Models;
using EventRegisterationSystem.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventRegisterationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterationController : ControllerBase
    {
        private readonly IRegisterationRepository registerationRepository;
        private readonly IEventRepository eventRepository;
        private readonly IUserRepository userRepository;
        public RegisterationController(IRegisterationRepository _registerationRepository , IEventRepository _eventRepository, IUserRepository _userRepository)
        {
            registerationRepository = _registerationRepository;
            eventRepository = _eventRepository;
            userRepository = _userRepository;
        }
        [HttpPost("Register")]
        public IActionResult Register(Registeration registeration)
        {
            Event @event = eventRepository.GetById(registeration.EventId);
            User user = userRepository.GetById(registeration.UserId);
            if(@event == null || user == null)
            {
                return NotFound("not found");
            }
            registerationRepository.AddRegisteration(registeration);
            return Ok(registeration);
        }
    }
}
