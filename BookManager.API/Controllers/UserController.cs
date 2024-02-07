using BookManager.Application.InputModels;
using BookManager.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var user = _userService.GetById(id);

            if(user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateInputUserModel createUser)
        {
            if (string.IsNullOrEmpty(createUser.Name)) return BadRequest();

            var id = _userService.Create(createUser);

            return CreatedAtAction(nameof(GetById), new { id }, createUser);
        }
    }
}
