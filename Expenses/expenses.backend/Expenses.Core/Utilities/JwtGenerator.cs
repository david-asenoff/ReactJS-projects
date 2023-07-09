using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Expenses.Core.Utilities
{
    public static class JwtGenerator
    {
        public static string GenerateUserToken(string username)
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, username),
            };

            return GenerateUserToken(claims, DateTime.UtcNow.AddDays(1));
        }

        private static string GenerateUserToken(Claim[] claims, DateTime expires)
        {
            var tokenHadler = new JwtSecurityTokenHandler();
            // The code bellow depends on adding some keys in launchSettings.json as follows:
            // "JWT_SECRET": "Some super secret string is needed here",
            // "JWT_ISSUER": "My Expenses"
            var secret = Environment.GetEnvironmentVariable("JWT_SECRET");
            var issuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expires,
                Issuer = issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHadler.CreateToken(tokenDescriptor);

            return tokenHadler.WriteToken(token);
        }
    }
}
