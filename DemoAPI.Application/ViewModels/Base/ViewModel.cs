using AutoMapper;
using System.Collections.Generic;

namespace DemoAPI.Application.ViewModels.Base
{
    public class ViewModel<Entity, DTO>
        where Entity : class, new()
        where DTO : class, new()
    {
        private static readonly MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Entity, DTO>();
            cfg.CreateMap<DTO, Entity>();
        });

        private static readonly IMapper _mapper = config.CreateMapper();

        public static Entity ToEntity(DTO dto)
        {
            return _mapper.Map<Entity>(dto);
        }

        public static DTO FromEntity(Entity entity)
        {
            return _mapper.Map<DTO>(entity);
        }

        public static IEnumerable<DTO> FromEntityEnumerable(IEnumerable<Entity> entities)
        {
            return _mapper.Map<IEnumerable<DTO>>(entities);
        }
    }
}
