using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Produto
    {
        public int quantidadeEmEstoque;

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeEmEstoque { get { return this.quantidadeEmEstoque; } }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get { return this.Fornecedor; } }
        public float Preco { get; set; }

        public Produto(int id, string nome, DateTime dataFabricacao, DateTime dataValidade, int quantidadeEmEstoque, Categoria categoria, float preco)
        {
            this.IdProduto = id;
            this.NomeProduto = nome;
            this.DataFabricacao = dataFabricacao;
            this.DataValidade = dataValidade;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.Categoria = categoria;
            this.Preco = preco;
            ValidaPrecoProduto();
        }

        public bool ValidaPrecoProduto()
        {
            if(this.Preco > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("Preço do produto deve ser maior que zero");
            }
        }

        public void AdicionaEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.quantidadeEmEstoque += quantidade;
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
                this.quantidadeEmEstoque -= quantidade;
            }
            else
            {
                throw new Exception("Quantidade á ser adicionada deve ser maior que zero");
            }
        }
        
    }
}
