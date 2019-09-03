using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuyckBuy.Repositorio.Std.Config
{
    class ItemPedidosConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ProdutoId)
                .IsRequired();

            builder.Property(i => i.Quantidade)
                .IsRequired();

        }
    }
}
