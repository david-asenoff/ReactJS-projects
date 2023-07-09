namespace JokesWebApi.Web.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using JokesWebApi.Data;
    using JokesWebApi.Data.Models;
    using JokesWebApi.Web.ViewModels.Register;
    using Microsoft.EntityFrameworkCore;

    public class UsersService: IUsersService
    {
        private readonly ApplicationDbContext db;

        public UsersService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task RegisterAsync(RegisterInputModel model)
        {
            var user = new ApplicationUser();
            user.Email = model.Email;
            user.PasswordHash = model.Password;
            await this.db.Users.AddAsync(user);
            await this.db.SaveChangesAsync();

        }

        public async Task<ApplicationUser> GetUserAsync(string email, string password)
        {
            var user = new ApplicationUser();
            var userFromDb = await this.db.Users.Where(u => u.Email == email && u.PasswordHash == password).FirstOrDefaultAsync();
            user.Email = userFromDb.Email;
            user.PasswordHash = userFromDb.PasswordHash;

            return user;
        }
    }
}
