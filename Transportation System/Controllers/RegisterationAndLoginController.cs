using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Transportation_System.Core.Domain;
using Transportation_System.Data;
using Transportation_System.Models;

namespace Transportation_System.Controllers
{
    [Route("Transportation")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterationAndLoginController : ControllerBase
    {
        UserManager<User> userManager;
        SignInManager<User> signInManager;
        ILogger<RegisterViewModel> logger;
        IMapper mapper;
        public RegisterationAndLoginController(UserManager<User> _userManager,
        SignInManager<User> _signInManager,
        ILogger<RegisterViewModel> _logger,IMapper _mapper)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            logger = _logger;
            mapper = _mapper;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> PostRegister(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                //var user = new Passenger { UserName = register.Email, Email = register.Email, FirstName = register.FirstName, LastName = register.LastName, BirthDate = register.BirthDate};
                var user = mapper.Map<Passenger>(register);
                user.UserName = register.Email;
                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                }
                return Ok( new { register.BirthDate,register.Email,register.FirstName,register.LastName } );
            }
            return BadRequest();
        }
        [HttpPost("login")]
        public async Task<IActionResult> PostLogin(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(login.Email, login.Password,isPersistent:false, lockoutOnFailure: false);
                var LoggedInUser = userManager.Users.Where(s => s.Email == login.Email).FirstOrDefault();
                if (LoggedInUser != null)
                {
                    if (result.Succeeded)
                    {
                        return Ok(new { LoggedInUser.Email,LoggedInUser.FirstName,LoggedInUser.LastName,LoggedInUser.BirthDate });
                    }
                }
                return NotFound();
            }
            return BadRequest();
        }
    }
}
