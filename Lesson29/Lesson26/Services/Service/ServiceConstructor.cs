using Lesson26.DataAccess.DbPatterns.Interfaces;

namespace Lesson26.Services.Service
{
    public class ServiceConstructor
    {
        protected IUnitOfWork UnitOfWork;

        protected ServiceConstructor(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
