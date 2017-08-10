using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ItemPedidoTeste
    {
        #region Base
        private Categoria categoria;
        private Produto produto;
        private ItemDePedido item;
        private ItemDePedido item2;
        private Endereco endereco;
        private Telefone telefone;
        private Contato contato;
        private Cliente cliente;
        private Pedido pedido;

        public void InicializaValorItem()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaValorItemNegativo()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, -5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaValorItemZero()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 0);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaQuantidadeItemNegativa()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, -5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        public void InicializaQuantidadeItemZero()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 0, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
        }
        #endregion

        #region Calcula Valor do Item
        //Calcula Valor do Item
        [TestCategory("Item de Pedido")]
        [TestMethod]
        public void TestCalculaValorDoItem()
        {
            InicializaValorItem();
            Assert.AreEqual(50, item.ValorDoItem);
        }
        [TestCategory("Item de Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "O preço do produto é inválido")]
        public void TestCalculaValorDoItemNegativo()
        {
            InicializaValorItemNegativo();
        }
        [TestCategory("Item de Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "O preço do produto é inválido")]
        public void TestCalculaValorDoItemZero()
        {
            InicializaValorItemZero();
        }
        #endregion

        #region Valida quantidade em Estoque
        [TestCategory("Item de Pedido")]
        [TestMethod]
        public void TestValidaQuantidadeEstoque()
        {
            InicializaValorItem();
            Assert.AreEqual(85, produto.QuantidadeEmEstoque);
        }
        [TestCategory("Item de Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "A Quantidade deve ser maior que zero")]
        public void TestValidaQuantidadeEstoqueNegativa()
        {
            InicializaQuantidadeItemNegativa();
        }
        [TestCategory("Item de Pedido")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "A Quantidade deve ser maior que zero")]
        public void TestValidaQuantidadeEstoqueZero()
        {
            InicializaQuantidadeItemZero();
        }
        #endregion
    }
}
