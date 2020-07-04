using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Transportation_System.Core.Domain;
using Transportation_System.Data;
using Transportation_System.Models;

namespace Transportation_System.Controllers
{
    [Route("api/[controller]")]
    [Route("Transportation/Register")]
    [ApiController]
    public class RegisterationAndLoginController : ControllerBase
    {
        UserManager<User> userManager;
        SignInManager<User> signInManager;
        ILogger<RegisterViewModel> logger;
        public RegisterationAndLoginController(UserManager<User> _userManager,
        SignInManager<User> _signInManager,
        ILogger<RegisterViewModel> _logger)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            logger = _logger;
        }
        [HttpPost]
        public async Task<IActionResult> PostRegister(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new Passenger { UserName = register.Email, Email = register.Email, FirstName = register.FirstName, LastName = register.LastName, BirthDate = register.BirthDate};
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                }
                return Ok(register);
            }
            return BadRequest();
        }
        
    }
}
