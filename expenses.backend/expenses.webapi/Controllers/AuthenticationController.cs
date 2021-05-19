using Expenses.Core;
using Expenses.Core.CustomException;
using Expenses.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService userService;

        public AuthenticationController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(User user)
        {
            try
            {
                var result = await userService.SignUp(user);
                return Created("", result);
            }
            catch (UserNameAlreadyExistException e)
            {
                return StatusCode(409, e.Message);
            }
        }
    }
}
