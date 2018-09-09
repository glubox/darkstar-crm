using DarkstarCrm.Repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DarkstarCrm.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly IUnitOfWork uow;

        protected RepositoryBase(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> filter)
        {
            return uow.GetSet<T>().Where(filter);
        }

        public IQueryable<T> GetAll()
        {
            return uow.GetSet<T>();
        }

        public T FindSingle(Expression<Func<T, bool>> filter)
        {
            return uow.GetSet<T>().SingleOrDefault(filter);
        }

        public void Add(T item) => uow.Add(item);

        public void Remove(T item) => uow.Remove(item);
    }
}