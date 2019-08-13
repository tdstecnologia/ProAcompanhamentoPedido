using ProAcompanhamentoPedido.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Models
{
    public class Pedido
    {
        public Pedido(int i)
        {
        }

        public Pedido(int pedidoId, DomStatusPedido status)
        {
            PedidoId = pedidoId;
            Status = status;
        }

        public int PedidoId { get; set; }

        public DomStatusPedido Status { get; set; }
    }
}
