using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class PedidoTeste
    {
        private Categoria categoria;
        private Produto produto;
        private ItemDePedido item;
        private ItemDePedido item2;
        private StatusDoCliente status;
        private Endereco endereco;
        private Telefone telefone;
        private Contato contato;
        private Cliente cliente;
        private Pedido pedido;

        public void Inicializa()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.status = new Domain.StatusDoCliente(1, "Bom");
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, status);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }
        public void InicializaValorNegativo()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, -5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.status = new Domain.StatusDoCliente(1, "Bom");
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, status);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }
        public void InicializaValorZero()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 0);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.status = new Domain.StatusDoCliente(1, "Bom");
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, status);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }

        [TestCategory("Pedido")]
        [TestMethod]
        public void CalculaValorDoPedido()
        {
            Inicializa();
            pedido.CalculoValorDoPedido();
            Assert.AreEqual(75, pedido.ValorDoPedido);
        }

        [TestCategory("Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Pedido com preço negativo ou zero")]
        public void CalculaValorDoPedidoNegativo()
        {
            InicializaValorNegativo();
        }

        [TestCategory("Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Pedido com preço negativo ou zero")]
        public void CalculaValorDoPedidoZero()
        {
            InicializaValorZero();
        }
    }
}
