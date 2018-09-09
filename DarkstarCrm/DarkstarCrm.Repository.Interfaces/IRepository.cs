using System;
using System.Linq;
using System.Linq.Expressions;

namespace DarkstarCrm.Repository.Interfaces
{
    public interface IRepository<T>  where T : class
    {
        IQueryable<T> FindBy(Expression<Func<T, bool>> filter);

        IQueryable<T> GetAll();

        T FindSingle(Expression<Func<T, bool>> filter);

        void Add(T item);

        void Remove(T item);
    }
}