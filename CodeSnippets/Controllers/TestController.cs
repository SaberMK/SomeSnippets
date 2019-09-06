using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSnippets.Entities.Entities;
using CodeSnippets.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CodeSnippets.Controllers
{
    [ApiController]
    [Route("api/test")]
    [EnableCors("hah")]
    public class TestController : Controller
    {
        readonly IUserService _userService;
        public TestController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetTestString());
        }
    }
}
