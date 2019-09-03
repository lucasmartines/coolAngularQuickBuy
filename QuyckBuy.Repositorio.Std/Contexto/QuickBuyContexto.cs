﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio;
using QuickBuy.Dominio.Entidades;
using QuyckBuy.Repositorio.Std.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        

        public DbSet<Pedido> Pedidos { get;set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ItemPedido> ItensPedidos  { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidosConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }
}
