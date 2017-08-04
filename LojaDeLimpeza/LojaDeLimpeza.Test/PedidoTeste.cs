using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class PedidoTeste
    {
        [TestCategory("Pedido")]
        [TestMethod]
        public void CalculaValorDoPedido()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);
            var item = new Domain.ItemDePedido(1, 10, 50, produto);
            var item2 = new Domain.ItemDePedido(2, 5, 25, produto);
            var statusDoCliente = new Domain.StatusDoCliente(1, "Bom");
            var endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            var telefone = new Domain.Telefone(1, "(31) 3456-5464");
            var contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            var cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, statusDoCliente);
            var pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);

            pedido.CalculoValorDoPedido();
            Assert.AreEqual(75, pedido.ValorDoPedido);
        }

        [TestCategory("Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Pedido com preço negativo ou zero")]
        public void CalculaValorDoPedidoNegativo()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);
            var item = new Domain.ItemDePedido(1, 10, -50, produto);
            var item2 = new Domain.ItemDePedido(2, 5, 25, produto);
            var statusDoCliente = new Domain.StatusDoCliente(1, "Bom");
            var endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            var telefone = new Domain.Telefone(1, "(31) 3456-5464");
            var contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            var cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, statusDoCliente);
            var pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
            pedido.CalculoValorDoPedido();
        }

        [TestCategory("Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Pedido com preço negativo ou zero")]
        public void CalculaValorDoPedidoZero()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);
            var item = new Domain.ItemDePedido(1, 10, -50, produto);
            var item2 = new Domain.ItemDePedido(2, 5, 50, produto);
            var statusDoCliente = new Domain.StatusDoCliente(1, "Bom");
            var endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            var telefone = new Domain.Telefone(1, "(31) 3456-5464");
            var contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            var cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, statusDoCliente);
            var pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
            pedido.CalculoValorDoPedido();
        }
    }
}
