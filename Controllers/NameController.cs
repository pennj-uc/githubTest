using githubTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace githubTest.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personName = new Name { PersonName = "John Penn"};
            return Ok(personName);
        }
    }

    
}




