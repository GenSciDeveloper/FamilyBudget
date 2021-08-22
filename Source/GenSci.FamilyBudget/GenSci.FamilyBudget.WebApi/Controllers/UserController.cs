using GenSci.FamilyBudget.DataContext.Models;
using GenSci.FamilyBudget.DataContext.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenSci.FamilyBudget.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        private readonly IRepository<User> _userRepository;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            //_userRepository = new Repository<User>();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get() => await _userRepository.All.ToListAsync();

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user = _userRepository.FindById(id);

            return user == null ? NotFound() : (ActionResult<User>)new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            if (user == null)
                return BadRequest();

            _userRepository.Add(user);
            await _userRepository.SaveAsync();

            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<User>> Put(User user)
        {
            if (user == null)
                return BadRequest();

            _userRepository.Update(user);
            await _userRepository.SaveAsync();
            return Ok(user);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            User user = _userRepository.FindById(id);

            if (user == null)
                return NotFound();

            _userRepository.Delete(user);
            await _userRepository.SaveAsync();

            return Ok(user);
        }
    }
}
