using System.Linq;

namespace DarkstarCrm.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        IQueryable<T> GetSet<T>();

        void Save();

        void Add<T>(T item) where T : class;

        void Remove<T>(T item) where T : class;
    }
}