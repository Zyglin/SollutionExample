using System.Linq.Expressions;

namespace Lesson26.DataAccess.DbPatterns.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<T> Create(T t);
        Task Delete(T t);
        Task Update(T t);
        Task<T> Get(Guid id);
        Task<IList<T>> GetAll();
    }
}
