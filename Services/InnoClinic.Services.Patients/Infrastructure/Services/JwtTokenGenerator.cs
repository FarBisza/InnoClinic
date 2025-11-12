using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using InnoClinic.Services.Patients.Domain.Entities;
using InnoClinic.Services.Patients.Infrastructure.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace InnoClinic.Services.Patients.Infrastructure.Services
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IConfiguration _configuration;
        public JwtTokenGenerator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJwtToken(Patient patient)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, patient.FirstName) };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwt = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddHours(1),
                    signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}