﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Customer.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
      
        [HttpGet]
        public IActionResult Index()
        {
          return Ok(new List<string> { "Hilmi Celayir", "Saniye Yıldız", "Nevin Yıldız", "Fatih Yılmaz" });

        }
    }
}
