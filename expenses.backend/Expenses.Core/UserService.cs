using Expenses.Core.CustomException;
using Expenses.Core.DTO;
using Expenses.Core.Utilities;
using Expenses.DB;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Core
{
    public class UserService : IUserService
    {
        private readonly AppDbContext context;
        private readonly IPasswordHasher passwordHasher;

        public UserService(AppDbContext context,
                           IPasswordHasher passwordHasher)
        {
            this.context = context;
            this.passwordHasher = passwordHasher;
        }

        public async Task<AuthenticatedUserDTO> SignIn(User user)
        {
            var userDb = await context.Users.FirstOrDefaultAsync(x => x.Username == user.Username);
            if (userDb == null ||
                passwordHasher.VerifyHashedPassword(userDb.Password, user.Password) == PasswordVerificationResult.Failed)
            {
                throw new InvalidUserNamePasswordException("Invalid username or password");
            }
            return new AuthenticatedUserDTO
            {
                Username = user.Username,
                Token = JwtGenerator.GenerateUserToken(user.Username)
            };
        }

        public async Task<AuthenticatedUserDTO> SignUp(User user)
        {
            var checkUser = await context.Users.FirstOrDefaultAsync(x => x.Username.Equals(user.Username));
            if (checkUser != null)
            {
                throw new UserNameAlreadyExistException("Username already exists");
            }
            user.Password = passwordHasher.HashPassword(user.Password);
            await context.AddAsync(user);
            await context.SaveChangesAsync();

            return new AuthenticatedUserDTO
            {
                Username = user.Username,
                Token = JwtGenerator.GenerateUserToken(user.Username)
            };
        }
    }
}
