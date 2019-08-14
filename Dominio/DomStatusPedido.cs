using System.ComponentModel;


namespace ProAcompanhamentoPedido.Dominio
{
    public enum DomStatusPedido
    {
        [Description("Pedido na Triagem")]
        SEPARACAO,

        [Description("Pedido no Balcão")]
        BALCAO,

        [Description("Pedido entregue ao cliente")]
        ENTREGUE
    }
}
