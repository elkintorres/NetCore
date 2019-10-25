using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [FormatFilter]
    public class ContactController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Contact register)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Contact result = register;
            result.Id = 143;

            return Created("", result);
        }
    }
}