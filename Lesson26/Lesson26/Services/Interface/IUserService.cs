using Lesson26.DataAccess.Entity;

namespace Lesson26.Services.Interface
{
    public interface IUserService
    {
        Task<User> GetUser(string email);
        Task<User> CreateUser(User user);
        Task UpdateUser(User user);
    }
}
