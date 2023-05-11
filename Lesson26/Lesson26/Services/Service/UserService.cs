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

    //Dependency injection (DI) или внедрение зависимостей представляет механизм, который позволяет сделать взаимодействующие в приложении объекты слабосвязанными.
    //Такие объекты связаны между собой через абстракции, например, через интерфейсы, что делает всю систему более гибкой, более адаптируемой и расширяемой.
    //В центре подобного механизма находится понятие зависимость - некоторая сущность, от которой зависит другая сущность.
    //Преимуществом ASP.NET Core в этом отношении является то, что фреймворк уже по умолчанию имеет встроенный контейнер внедрения зависимостей, который представлен интерфейсом IServiceProvider.
    //А сами зависимости еще называются сервисами, собственно поэтому контейнер можно назвать провайдером сервисов.
    //Этот контейнер отвечает за сопоставление зависимостей с конкретными типами и за внедрение зависимостей в различные объекты.
}
