using Microsoft.AspNetCore.Mvc;
using Fiap.Api.ReportCity.Services;
using Fiap.Api.ReportCity.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Fiap.Api.ReportCity.Controllers
{
    [Route("fiap/api/ReportCity/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: fiap/api/ReportCity/User
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        // GET: fiap/api/ReportCity/User/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST: fiap/api/ReportCity/User
        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }

        // PUT: fiap/api/ReportCity/User/5
        [HttpPut("{id}")]
        public IActionResult PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _userService.UpdateUser(user);
            return NoContent();
        }

        // DELETE: fiap/api/ReportCity/User/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
