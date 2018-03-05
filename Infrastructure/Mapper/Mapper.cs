
using System.Collections.Generic;
using System.Reflection;
using AutoMapper;
using System.Linq;

namespace Infrastructure.Mapper
{
    public class Mapper 
    {
        private IMapper _mapper;

        public Mapper(IEnumerable<System.Type> profiles)
        {
            Configurar(profiles);
        }

        private void Configurar(IEnumerable<System.Type> profiles)
        {

            var config = new MapperConfiguration(cfg =>
            {                
                cfg.AddProfiles(profiles);      
            });
            _mapper = config.CreateMapper();

        }

        public Destiny Map<Destiny,Source>(Source destiny)
        {
            return _mapper.Map<Source, Destiny>(destiny);
        }
    }
}
