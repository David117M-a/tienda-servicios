using Microsoft.EntityFrameworkCore;
using TiendaServicios.api.autor.Modelo;

namespace TiendaServicios.api.autor.Persistencia
{
    public class ContextoAutor: DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options): base(options)
        {

        }

        public DbSet<AutorLibro> AutorLibro { get; set; }
        public DbSet<GradoAcademico> GradosAcademicos { get; set; }
    }
}
