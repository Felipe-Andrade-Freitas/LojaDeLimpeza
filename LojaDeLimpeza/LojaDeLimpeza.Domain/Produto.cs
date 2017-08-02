using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public DateTime DataFabricacao { get; set; }

        public DateTime DataValidade { get; set; }

        public int QuantidadeEmEstoque { get; set; }

        public Categoria Categoria { get; set; }

        public float Preco { get; set; }

        public void AdicionaEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.QuantidadeEmEstoque += quantidade;
            }
            else
            {
                throw new Exception("Quantidade á ser adicionada deve ser maior que zero");
            }
        }
        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.QuantidadeEmEstoque -= quantidade;
            }
            else
            {
                throw new Exception("Quantidade á ser adicionada deve ser maior que zero");
            }
        }
    }
}
