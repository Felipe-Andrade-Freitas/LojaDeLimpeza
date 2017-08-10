using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class PedidoTeste
    {
        #region Base
        private Categoria categoria;
        private Produto produto;
        private Produto produto2;
        private Produto produto3;
        private ItemDePedido item;
        private ItemDePedido item2;
        private ItemDePedido item3;
        private Endereco endereco;
        private Telefone telefone;
        private Contato contato;
        private Cliente cliente;
        private Pedido pedido;

        public void Inicializa()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 10);
            this.produto2 = new Domain.Produto(2, "Amaciante de Roupas", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 10);
            this.produto3 = new Domain.Produto(3, "Água Sanitária", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 10);
            this.item = new Domain.ItemDePedido(1, 15, produto);
            this.item2 = new Domain.ItemDePedido(2, 10, produto2);
            this.item3 = new Domain.ItemDePedido(3, 5, produto3);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaValorNegativo()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, -5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaValorZero()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 0);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaValorRetiradoEstoqueNegativo()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaValorRetiradoEstoqueZero()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 20, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 10, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        #endregion

        #region Calcula valor do pedido
        [TestCategory("Pedido")]
        [TestMethod]
        public void CalculaValorDoPedido()
        {
            Inicializa();
            pedido.AdicionaItemPedido(item);
            pedido.AdicionaItemPedido(item2);
            pedido.AdicionaItemPedido(item3);
            Assert.AreEqual(150, item.ValorDoItem);
            Assert.AreEqual(100, item2.ValorDoItem);
            Assert.AreEqual(50, item3.ValorDoItem);
            Assert.AreEqual(500, pedido.ValorDoPedido);
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
        #endregion
        
        #region Retira do Estoque
        [TestCategory("Pedido")]
        [TestMethod]
        public void RetiraEstoque()
        {
            Inicializa();
            Assert.AreEqual(85, produto.QuantidadeEmEstoque);
            Assert.AreEqual(90, produto2.QuantidadeEmEstoque);
            Assert.AreEqual(95, produto3.QuantidadeEmEstoque);
        }
        [TestCategory("Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ter o valor maior que zero")]
        public void RetiraEstoqueValorNegativo()
        {
            InicializaValorRetiradoEstoqueNegativo();
        }
        [TestCategory("Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ter o valor maior que zero")]
        public void RetiraEstoqueValorZero()
        {
            InicializaValorRetiradoEstoqueZero();
        }
        #endregion
    }
}