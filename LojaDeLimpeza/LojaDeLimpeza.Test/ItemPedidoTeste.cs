using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ItemPedidoTeste
    {
        [TestCategory("Item de Pedido")]
        [TestMethod]
        public void TestCalculaValorDoItem()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");

            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);

            var item = new Domain.ItemDePedido(1, 10, 50, produto);

            item.CalculaValorDoItem();

            Assert.AreEqual(50, item.ValorDoItem);
        }

        [TestCategory("Item de Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestCalculaValorDoItemNegativo()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");

            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, -5);

            var item = new Domain.ItemDePedido(1, 10, 50, produto);

            item.CalculaValorDoItem();
        }

        [TestCategory("Item de Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestCalculaValorDoItemZero()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");

            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 0);

            var item = new Domain.ItemDePedido(1, 10, 50, produto);

            item.CalculaValorDoItem();
        }
    }
}
