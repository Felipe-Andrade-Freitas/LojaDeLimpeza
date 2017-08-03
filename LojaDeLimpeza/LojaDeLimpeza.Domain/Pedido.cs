using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Pedido
    {
        private int idPedido;
        private DateTime dataDoPedido;
        private Cliente cliente;
        private float valorDoPedido;

        public int IdPedido { get { return this.idPedido; } }
        public DateTime DataDoPedido { get { return this.dataDoPedido; } }
        public Cliente Cliente { get { return this.cliente; } }
        public IList<ItemDePedido> ListaDeItemPedido = new List<ItemDePedido>();

        public Pedido(int id, DateTime dataDoPedido, Cliente cliente)
        {
            this.idPedido = id;
            this.cliente = cliente;
            this.dataDoPedido = dataDoPedido;
        }

        public void CalculoValorDoPedido()
        {
            foreach (var itemDePedido in ListaDeItemPedido)
            {
                itemDePedido.CalculaValorDoItem();
                var preco = itemDePedido.ValorDoItem;

                if(preco > 0)
                {
                    valorDoPedido += itemDePedido.ValorDoItem;
                }
                throw new Exception("Pedido com preço negativo ou zero");

            }
        }
    }
}
