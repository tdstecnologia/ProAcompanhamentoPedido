﻿using Microsoft.EntityFrameworkCore;
using ProAcompanhamentoPedido.Dominio;
using System;

namespace ProAcompanhamentoPedido.Models
{
    public class AcompanhamentoContexto : DbContext
    {
        public AcompanhamentoContexto(DbContextOptions<AcompanhamentoContexto> opcoes) : base(opcoes)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder
            .Entity<Pedido>()
            .Property(p => p.Status)
            .HasConversion(
            v => v.ToString(),
            v => (DomStatusPedido)Enum.Parse(typeof(DomStatusPedido), v));
        }
    }
}
