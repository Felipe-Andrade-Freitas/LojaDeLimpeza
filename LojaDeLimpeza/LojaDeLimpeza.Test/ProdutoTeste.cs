using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ProdutoTeste
    {
        Categoria categoria = new Categoria()
        {
            IdCategoria = 1,
            NomeCategoria = "Lavanderia"
        };

        Produto produto = new Produto()
        {
            IdProduto = 1,
            NomeProduto = "Sabão em pó",
            DataFabricacao = new DateTime(2017, 07, 12),
            DataValidade = new DateTime(2018, 08, 12),
            QuantidadeEmEstoque = 10,
            Categoria = categoria,
            Preco = 5
        };

        [TestCategory("Adiciona Estoque")]
        [TestMethod]
        public void TestAdicionaEmEstoque()
        {
            produto.AdicionaEstoque(10);
            Assert.AreEqual(20, produto.QuantidadeEmEstoque);
        }

        [TestCategory("Adiciona Estoque")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestAdicionaEmEstoqueValorNegativo()
        {
            produto.AdicionaEstoque(-10);
        }

        [TestCategory("Adiciona Estoque")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestAdicionaEmEstoqueValorZero()
        {
            produto.AdicionaEstoque(0);
        }

        [TestCategory("Remover Estoque")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoverEmEstoqueValorZero()
        {
            produto.RemoverEstoque(0);
        }

        [TestCategory("Remover Estoque")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoverEstoqueValorNegativo()
        {
            produto.RemoverEstoque(-10);
        }

        [TestCategory("Remover Estoque")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoverEstoqueValorZero()
        {
            produto.AdicionaEstoque(0);
        }
    }
}
