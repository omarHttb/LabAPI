using Lab.Model;
using Lab.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        IAccount accountService;

        public AccountsController(IAccount _accountService)
        {
            accountService = _accountService;
        }

        [HttpPost]
        [Route("Signup")]
        public async Task<IActionResult> Signup(SignUpDTO signUpDTO)
        {
            var result = await accountService.CreateAccount(signUpDTO);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500,result.Errors);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(SignInDTO signIn)
        {
            var result = await accountService.SignIn(signIn);

            if (result.Succeeded)
            {
                List<Claim> authClaim = new List<Claim>();
                Claim claim = new Claim(ClaimTypes.Name, signIn.Username);
                authClaim.Add(claim);
                claim = new Claim("uniqueValue", Guid.NewGuid().ToString());
                authClaim.Add(claim);



                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisMySecurityKey"));

                var token = new JwtSecurityToken(
                            issuer: "http://localhost",
                            audience: "User",
                            expires: DateTime.Now.AddDays(30),
                            claims: authClaim,
                            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                            );

                return Ok(
                        new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token)
                        });
            }
            else
            {
                return Unauthorized();
            }
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
