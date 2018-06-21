using CleanDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // POST api/people
        [HttpPost]
        public void Post([FromBody] Person person)
        {
        }
    }
}
