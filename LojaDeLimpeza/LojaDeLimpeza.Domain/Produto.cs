using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Produto
    {
        public int idProduto;
        public string nomeProduto;
        public DateTime dataFabricacao;
        public DateTime dataValidade;
        public int quantidadeEmEstoque;
        public Categoria categoria;
        public float preco;

        public int IdProduto { get { return this.idProduto; } }
        public string NomeProduto { get { return this.nomeProduto; } }
        public DateTime DataFabricacao { get { return this.dataFabricacao; } }
        public DateTime DataValidade { get { return this.dataValidade; } }
        public int QuantidadeEmEstoque { get { return this.quantidadeEmEstoque; } }
        public Categoria Categoria { get { return this.categoria; } }
        public Fornecedor Fornecedor { get { return this.Fornecedor; } }
        public float Preco { get { return this.preco; } }

        public Produto(int id, string nome, DateTime dataFabricacao, DateTime dataValidade, int quantidade, Categoria categoria, float preco)
        {
            this.idProduto = id;
            this.nomeProduto = nome;
            this.dataFabricacao = dataFabricacao;
            this.dataValidade = dataValidade;
            this.quantidadeEmEstoque = quantidade;
            this.categoria = categoria;
            this.preco = preco;
        }

        public void ValidaQuantidadeProduto()
        {
            if (this.quantidadeEmEstoque > 0)
            {

            }
            else
            {
                throw new Exception("A Quantidade deve ser maior que zero");
            }
        }

        public void ValidaPreco()
        {
            if(this.preco > 0)
            {
                
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
