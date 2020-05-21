using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string passworkd);
        Task<User> Login(string username, string passworkd);
        Task<bool> UserExists(string username);
    }
}