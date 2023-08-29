using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GamerHeavenAPI.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IConfiguration _configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class AuthenticationBody
        {
            public string? Username { get; set; }
            public string? Password { get; set; }
        }

        private class ApiUser
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public ApiUser(int userId, string username, string firstName, string lastName)
            {
                UserId = userId;
                Username = username;
                FirstName = firstName;
                LastName = lastName;
            }
        }

        private ApiUser ValidateUserCredentials(string? username, string? password)
        {
            // We assume all credentials are valid
            return new ApiUser(
                1,
                username ?? "",
                "Jhon",
                "Doe"
                );
        }
        
        [HttpPost("authenticate")]
        // Returns Token
        public ActionResult<string> Authenticate(AuthenticationBody authenticationBody)
        {
            // Validate Credentials
            var user = ValidateUserCredentials(authenticationBody.Username, authenticationBody.Password);

            if (user == null) return Unauthorized();

            // Create a token
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Claims
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.UserId.ToString()));
            claimsForToken.Add(new Claim("given_name", user.FirstName));
            claimsForToken.Add(new Claim("family_name", user.LastName));

            var jwtToken = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claimsForToken,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                signingCredentials
            );

            var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return Ok(tokenToReturn);
        }
    }
}
