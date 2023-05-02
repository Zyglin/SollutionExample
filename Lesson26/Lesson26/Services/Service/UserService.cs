using Lesson26.DataAccess.DbPatterns.Interfaces;
using Lesson26.DataAccess.Entity;
using Lesson26.Services.Interface;

namespace Lesson26.Services.Service
{
    public class UserService : ServiceConstructor, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<User> CreateUser(User user)
        {
            return await UnitOfWork.Users.Create(user);
        }

        public async Task<User> GetUser(string email)
        {
            IList<User> users = await UnitOfWork.Users.GetAll();
            return users.FirstOrDefault(x => x.Email == email);
        }

        public async Task UpdateUser(User user)
        {
            await UnitOfWork.Users.Update(user);
        }
    }
}
