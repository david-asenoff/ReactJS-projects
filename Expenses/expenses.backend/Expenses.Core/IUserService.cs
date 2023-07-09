using Expenses.Core.DTO;
using Expenses.DB;
using System.Threading.Tasks;

namespace Expenses.Core
{
    public interface IUserService
    {
        Task<AuthenticatedUserDTO> SignUp(User user);
        Task<AuthenticatedUserDTO> SignIn(User user);
    }
}
