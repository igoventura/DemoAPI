using DemoAPI.Domain.Entities.Base;
using DemoAPI.Domain.Interfaces.Base;
using DemoAPI.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAPI.Infrastructure.Data.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly FinancesDbContext _context;
        private readonly DbSet<TEntity> entities;

        public Repository(FinancesDbContext context)
        {
            _context = context;
            entities = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll() => entities;

        public TEntity GetById(int id) => entities.SingleOrDefault(e => e.Id == id);

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate) => entities.Where(predicate);

        public void Add(TEntity entity) => entities.Add(entity);

        public void Update(TEntity entity) => entities.Update(entity);

        public void Remove(TEntity entity) => entities.Remove(entity);

        public void Save() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
