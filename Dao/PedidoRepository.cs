using ProAcompanhamentoPedido.Dominio;
using ProAcompanhamentoPedido.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Dao
{
    public class PedidoRepository
    {

        public List<Pedido> Pedidos = new List<Pedido>();

        public PedidoRepository()
        {
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                Pedidos.Add(new Pedido(i, GerarStatus(random.Next(3))));
            }
        }

        private DomStatusPedido GerarStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return DomStatusPedido.SEPARACAO;
                case 1:
                    return DomStatusPedido.BALCAO;
                default:
                    return DomStatusPedido.ENTREGUE;
            }
        }
    }
}
