using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Customer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        public IActionResult Index()
        {
           return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" });

        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" }[id]);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Silme işlemi başarılı.");
        }
    }
}

