﻿using CursoEF.Entidades;
using System.Data.Entity;

namespace CursoEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        /// <summary>
        /// Configura o relacionamento das entidades do entity framework. Onde a categoria tem muitos produtos (HasMany) ou uma lista de produtos, e onde o produto
        /// tem opcionalmente uma categoria.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var configuration = modelBuilder.Entity<Categoria>();
            configuration.HasMany(categoria => categoria.Produtos).WithOptional(produto => produto.Categoria);

            var venda = modelBuilder.Entity<Venda>();
            venda.HasMany(v => v.Produtos).WithMany().Map(relacionamento =>
            {
                relacionamento.ToTable("Venda_Produtos");
                relacionamento.MapLeftKey("VendaId");
                relacionamento.MapRightKey("ProdutoId");
            });
        }
    }
}
