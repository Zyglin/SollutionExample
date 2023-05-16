using Lesson26.DataAccess.Entity;

namespace Lesson26.DataAccess.DbPatterns.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; }
        IGenericRepository<Film> Films { get; }
        IGenericRepository<Genre> Genres { get; }
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Rating> Ratings { get; }
    }
}
