using Microsoft.AspNetCore.Mvc;

namespace Api_Intro.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return Ok();
        //}
        [HttpGet]
        //public string GetNameById([FromForm] int id)
        //{
        //    return "Fidash" + id;
        //}

        public IActionResult GetById( int id)
        {
            string name = "Fidash" + id;
            return Ok(name);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> names = new List<string>() { "Fidash", "Lalesh"};
            return Ok(names);
        }
    }
}
