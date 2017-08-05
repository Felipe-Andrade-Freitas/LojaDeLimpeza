using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class ItemDePedido
    {
        private float valorDoItem;

        public int IdItemPedido { get; set; }
        public int QuantidadeItemPedido { get; set; }
        public float ValorDoItem { get { return this.valorDoItem; } }
        public Produto Produto { get; set; }

        public ItemDePedido(int id, int quantidadeItemPedido, Produto produto)
        {
            this.IdItemPedido = id;
            this.Produto = produto;
            this.QuantidadeItemPedido = quantidadeItemPedido;
            AdicionaProduto();
        }

        public void AdicionaProduto()
        {
            ValidaQuantidadeItemDePedido();
            CalculaValorDoItem();
        }

        public bool ValidaQuantidadeItemDePedido()
        {
            if(this.QuantidadeItemPedido > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("A Quantidade deve ser maior que zero");
            }
        }

        public void CalculaValorDoItem()
        {
            if(this.Produto.Preco < 0)
            {
                throw new Exception("O preço do produto é inválido");
            }
            else
            {
                this.valorDoItem = this.Produto.Preco * this.QuantidadeItemPedido;
            }
        }        
    }
}
