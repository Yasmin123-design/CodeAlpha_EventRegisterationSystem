using EventRegisterationSystem.Models;
using EventRegisterationSystem.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventRegisterationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody]User user)
        {
            userRepository.AddUser(user);
            return Ok(user);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<User> users = userRepository.GetAll();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            User user = userRepository.GetById(id);
            if(user == null)
            {
                return NotFound("user not found");
            }
            return Ok(user);
        }
    }
}
