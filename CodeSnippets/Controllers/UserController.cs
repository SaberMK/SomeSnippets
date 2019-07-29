using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSnippets.ViewModels.Request.User;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeSnippets.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [EnableCors("hah")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("auth")]
        public ActionResult<string> Auth([FromBody]UserAuthViewModel request)
        {
            return request.Password;
        }
    }
}