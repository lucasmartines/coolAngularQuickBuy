using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuyckBuy.Repositorio.Std.Config
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
               .Property(p => p.DataPrevisaoEntrega)
               .IsRequired();

            builder
               .Property(p => p.CEP)
               .HasMaxLength(10)
               .IsRequired();

            builder
               .Property(p => p.Estado)
               .IsRequired();

            builder
               .Property(p => p.EnderecoCompleto)
               .IsRequired();

            builder
               .Property(p => p.NumeroEndereco)
               .IsRequired();

            builder
               .Property(p => p.FormaPagamentoId)
               .IsRequired();

            //builder
                //.HasOne(u => u.Usuario);

        }
    }
}
