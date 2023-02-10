using AutoMapper;
using TiendaServicios.api.autor.Modelo;

namespace TiendaServicios.api.autor.Aplicacion
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDto>();
        }
    }
}
