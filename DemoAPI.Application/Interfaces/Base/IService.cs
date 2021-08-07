using DemoAPI.Domain.Entities.Base;
using System.Collections.Generic;
using System;
using DemoAPI.Application.ViewModels.Base;

namespace DemoAPI.Application.Interfaces.Base
{
    public interface IService<T, U>
        where T : Entity, new()
        where U : ViewModel<T, U>, new()
    {
        IEnumerable<U> GetAll();
        IEnumerable<U> Find(Func<T, bool> predicate);
        U GetById(int id);
        void Update(U viewModel);
        void Add(U viewModel);
        void Remove(int id);
    }
}
