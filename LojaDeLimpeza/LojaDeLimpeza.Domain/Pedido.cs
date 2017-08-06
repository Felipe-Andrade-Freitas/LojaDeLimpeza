using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Pedido
    {        
        public int IdPedido { get; set; }
        public DateTime DataDoPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public float ValorDoPedido { get; set; }
        public IList<ItemDePedido> ListaDeItemPedido = new List<ItemDePedido>();
        
        public Pedido(int id, DateTime dataDoPedido, Cliente cliente)
        {
            this.IdPedido = id;
            this.Cliente = cliente;
            this.DataDoPedido = dataDoPedido;
            AdicionaItemPedido();
        }

        public void AdicionaItemPedido()
        {
            foreach(var itemPedido in ListaDeItemPedido)
            {
                itemPedido.CalculaValorDoItem();
            }
            CalculoValorDoPedido();
            RetiraProdutoDoEstoque();
        }
        public void RetiraProdutoDoEstoque()
        {
            foreach(var itemPedido in ListaDeItemPedido)
            {
                var validaEstoque = itemPedido.ValidaQuantidadeItemDePedido();

                if (validaEstoque)
                {
                    itemPedido.QuantidadeItemPedido -= Produto.QuantidadeEmEstoque;
                }
            }
        }
        public void RemoveProduto()
        {
            foreach(var itemPedido in ListaDeItemPedido)
            {
                ListaDeItemPedido.Remove(itemPedido);
            }
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