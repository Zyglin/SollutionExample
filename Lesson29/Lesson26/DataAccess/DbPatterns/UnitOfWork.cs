using Lesson26.DataAccess.DbPatterns.Interfaces;
using Lesson26.DataAccess.Entity;

namespace Lesson26.DataAccess.DbPatterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;

        public UnitOfWork(MyDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<User> Users => new GenericRepository<User>(_context);

        public IGenericRepository<Film> Films => new GenericRepository<Film>(_context);

        public IGenericRepository<Genre> Genres => new GenericRepository<Genre>(_context);

        public IGenericRepository<Comment> Comments => new GenericRepository<Comment>(_context);
        public IGenericRepository<Rating> Ratings => new GenericRepository<Rating>(_context);

    }
}
