namespace JokesWebApi.Web.Services
{
    using System.Threading.Tasks;

    using JokesWebApi.Data.Models;
    using JokesWebApi.Web.ViewModels.Register;

    public interface IUsersService
    {
        Task RegisterAsync(RegisterInputModel model);

        public Task<ApplicationUser> GetUserAsync(string email, string password);
    }
}
