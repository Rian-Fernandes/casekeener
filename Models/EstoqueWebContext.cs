using Microsoft.EntityFrameworkCore;

namespace casekeener.Models
{
    public class EstoqueWebContext : DbContext
    {
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public EstoqueWebContext(DbContextOptions<EstoqueWebContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaModel>().ToTable("Categoria");
            modelBuilder.Entity<ProdutoModel>().ToTable("Produto");
            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
        }
    }
}
