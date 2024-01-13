using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MiradorWebAPI.ViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MiradorWebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;
        RoleManager<IdentityRole> roleManager;
        public AccountController(UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }
        [HttpPost("createRole/{role}")]
        public async Task<IActionResult> CreateRole(string role)
        {


            var result = await roleManager.CreateAsync(new IdentityRole() { Name = role });
            if(result.Succeeded) return NoContent();
            else return BadRequest(result.Errors);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = model.UserEmail,
                    Email = model.UserEmail
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var resultRole = await userManager.AddToRoleAsync(user, "User");
                    if(resultRole.Succeeded)
                    {
                        return Ok(new { userName = model.UserEmail, role = "User" });
                    }
                    else
                    {
                        return BadRequest(resultRole.Errors);
                    }
                }
                else
                {
                    return BadRequest(result.Errors);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.UserEmail);
                if (user != null)
                {
                    var result = await signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                    if (result.Succeeded)
                    {

                        var roles = await userManager.GetRolesAsync(user);

                        IdentityOptions identityOptions = new IdentityOptions();
                        var claims = new Claim[]
                        {
                            new Claim("Lid","123456789"),
                            new Claim(identityOptions.ClaimsIdentity.UserIdClaimType,user.Id),
                            new Claim(identityOptions.ClaimsIdentity.UserNameClaimType,user.UserName),
                            new Claim(identityOptions.ClaimsIdentity.RoleClaimType, roles[0]),
                            new Claim(identityOptions.ClaimsIdentity.RoleClaimType, user.Email),
                            new Claim("Mno","96701010101"),
                        };

                        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This-is-my-jwt-secret-key-for-jwt"));
                        var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

                        var jwt = new JwtSecurityToken(
                            claims: claims,
                            signingCredentials: signingCredentials,
                            expires: DateTime.Now.AddMinutes(30));
                        return Ok(new
                        {
                            userName = model.UserEmail,
                            role = roles[0],
                            token = new JwtSecurityTokenHandler().WriteToken(jwt)
                        });
                        //return Ok(new { userName = model.UserEmail, role = roles[0] });
                    }
                    else
                    {
                        return BadRequest(new { Error = "Invalid Username Or Password" });
                    }
                }
                else
                {
                    return BadRequest(new { Error = "Invalid Username Or Password" });
                }
            }
            else
            {
               return BadRequest(ModelState);
            }
        }
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return NoContent();
        }
    }
}
