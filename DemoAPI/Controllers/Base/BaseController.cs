using DemoAPI.Application.Interfaces;
using DemoAPI.Application.Interfaces.Base;
using DemoAPI.Application.ViewModels;
using DemoAPI.Application.ViewModels.Base;
using DemoAPI.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers.Base
{
    public class BaseController<T, U> : ControllerBase
        where T : Entity, new()
        where U : ViewModel<T, U>, new()
    {
        private readonly IService<T, U> _service;

        public BaseController(IService<T, U> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<U> GetAll() => _service.GetAll();

        [HttpGet]
        [Route("{id}")]
        public U GetById([FromRoute] int id) => _service.GetById(id);

        [HttpPost]
        public void Add([FromBody] U viewModel) => _service.Add(viewModel);

        [HttpPut]
        [Route("{id}")]
        public void Update([FromBody] U viewModel, [FromRoute] int id)
        {
            viewModel.Id = id;
            _service.Update(viewModel);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Remove([FromRoute] int id) => _service.Remove(id);
    }
}
