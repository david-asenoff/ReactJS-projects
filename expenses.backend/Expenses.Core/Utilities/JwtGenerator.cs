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
        }
    }
}
