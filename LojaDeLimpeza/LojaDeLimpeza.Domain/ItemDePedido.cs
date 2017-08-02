using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class ItemDePedido
    {
        private int id;
        private int quantidade;
        private float valorDoItem;
        private Produto produto;

        public int IdItemPedido { get { return this.id; } }
        public int QuantidadeProduto { get { return this.quantidade; } }
        public float ValorDoItem { get { return this.valorDoItem; } }
        public Produto Produto { get { return this.produto; } }

        public ItemDePedido(int id, int quantidade, float valorDoItem, Produto produto)
        {
            this.id = id;
            this.produto = produto;
            this.quantidade = quantidade;
            this.valorDoItem = valorDoItem;
        }

        public void CalculaValorDoItem()
        {
            this.produto.ValidaPreco();
            this.valorDoItem = this.Produto.Preco * this.QuantidadeProduto;
        }
    }
}
