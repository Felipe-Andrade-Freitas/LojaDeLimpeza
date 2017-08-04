using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ProdutoTeste
    {

        [TestCategory("Produto")]
        [TestMethod]
        public void TestAdicionaEmEstoque()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 50);

            produto.AdicionaEstoque(10);
            Assert.AreEqual(20, produto.QuantidadeEmEstoque);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestAdicionaEmEstoqueValorNegativo()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 50);

            produto.AdicionaEstoque(-10);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestAdicionaEmEstoqueValorZero()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 50);

            produto.AdicionaEstoque(0);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoverEmEstoqueValorZero()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 50);

            produto.RemoverEstoque(0);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoverEstoqueValorNegativo()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 50);

            produto.RemoverEstoque(-10);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoverEstoqueValorZero()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 50);

            produto.AdicionaEstoque(0);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaPrecoProdutoZero()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 0);

            produto.ValidaPreco();
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaPrecoProdutoNegativo()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, -10);

            produto.ValidaPreco();
        }

        [TestCategory("Produto")]
        [TestMethod]
        public void TestValidaPrecoProduto()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);

            produto.ValidaPreco();

            Assert.AreEqual(5, produto.preco);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaQuantidadeProduto()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 0);

            var item = new Domain.ItemDePedido(1, 10, 50, produto);

            item.CalculaValorDoItem();
        }
    }
}
