using Microsoft.EntityFrameworkCore;
using ProAcompanhamentoPedido.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Models
{
    public class AcompanhamentoContexto : DbContext
    {
        public AcompanhamentoContexto(DbContextOptions<AcompanhamentoContexto> opcoes) : base(opcoes)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<PedidoCliente> PedidoClientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<PedidoCliente>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder
        .Entity<PedidoCliente>()
        .Property(p => p.Status)
        .HasConversion(
            v => v.ToString(),
            v => (DomStatusPedido)Enum.Parse(typeof(DomStatusPedido), v));
        }
    }
}
