using CursoEF.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CursoEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Categoria> configuration = modelBuilder.Entity<Categoria>();
            configuration.HasMany(categoria => categoria.Produtos).WithOptional(produto => produto.Categoria);
        }
    }
}
