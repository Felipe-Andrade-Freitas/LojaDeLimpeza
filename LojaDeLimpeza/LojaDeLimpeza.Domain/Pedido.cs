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
        
        public int IdPedido { get { return this.idPedido; } }
        public DateTime DataDoPedido { get { return this.dataDoPedido; } }
        public Cliente Cliente { get { return this.cliente; } }
        public float ValorDoPedido { get; set; }
        public IList<ItemDePedido> ListaDeItemPedido = new List<ItemDePedido>();
        
        public Pedido(int id, DateTime dataDoPedido, Cliente cliente)
        {
            this.idPedido = id;
            this.cliente = cliente;
            this.dataDoPedido = dataDoPedido;
            CalculoValorDoPedido();
        }

        public void CalculoValorDoPedido()
        {
            foreach (var itemDePedido in ListaDeItemPedido)
            {
                itemDePedido.CalculaValorDoItem();
                this.ValorDoPedido += itemDePedido.ValorDoItem;                    
            }     
        }
    }
}
