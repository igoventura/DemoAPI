using DemoAPI.Application.Attributes;
using DemoAPI.Application.Interfaces.Base;
using DemoAPI.Application.ViewModels.Base;
using DemoAPI.Domain.Entities.Base;
using DemoAPI.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;

namespace DemoAPI.Application.Services.Base
{
    public class Service<T, U> : IService<T, U>
        where T : Entity, new()
        where U : ViewModel<T, U>, new()
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<U> GetAll() => ViewModel<T, U>.FromEntityEnumerable(_repository.GetAll());

        public IEnumerable<U> Find(Func<T, bool> predicate) => ViewModel<T, U>.FromEntityEnumerable(_repository.Find(predicate));

        public U GetById(int id) => ViewModel<T, U>.FromEntity(_repository.GetById(id));

        public void Add(U viewModel)
        {
            T entity = ViewModel<T, U>.ToEntity(viewModel);
            _repository.Add(entity);
            _repository.Save();
        }

        public void Remove(int id)
        {
            T entity = _repository.GetById(id);
            _repository.Remove(entity);
            _repository.Save();
        }

        public void Update(U viewModel)
        {
            T entity = ViewModel<T, U>.ToEntity(viewModel);
            _repository.Update(entity);
            _repository.Save();
        }
    }
}
