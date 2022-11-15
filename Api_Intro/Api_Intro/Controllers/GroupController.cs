using Api_Intro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Intro.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class GroupController : ControllerBase
    {

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            List<Group> groups = new List<Group>();

            Group group1 = new()
            {
                Id = 1,
                Name = "A",
                Capasity = 16
            };

            Group group2 = new()
            {
                Id = 2,
                Name = "B",
                Capasity = 14
            };

            Group group3 = new()
            {
                Id = 3,
                Name = "C",
                Capasity = 13
            };

            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);

            return Ok(groups);
        }
    }
}
