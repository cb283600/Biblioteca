
using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Datos.EF
{
    public class BibliotecaContext : DbContext
    {
        /**
         * DbSet is a collection of entities that can be queried from the database.
         * DbSet<TEntity> is a property of type DbSet<TEntity> on a DbContext-derived class.
         * The DbSet<TEntity> class represents an entity set that can be used for create, read, update, and delete operations.
         */

        public DbSet<Tema> Temas { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=biblioteca;Integrated Security=True");
        }
    }
}
