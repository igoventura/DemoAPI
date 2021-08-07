using System;
using System.Collections.Generic;

namespace DemoAPI.Domain.Interfaces.Base
{
    public interface IRepository<T> : IDisposable where T : IEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T GetById(int id);
        void Update(T entity);
        void Add(T entity);
        void Remove(T entity);
        void Save();
    }
}
