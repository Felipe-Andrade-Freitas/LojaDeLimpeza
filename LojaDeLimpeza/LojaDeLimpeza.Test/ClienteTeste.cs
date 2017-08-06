using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ClienteTeste
    {
        #region Base
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

        public void InicializaStatusBom()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.status = new StatusDoCliente() { IdStatus = 3, NomeStatus = "Bom" };
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 5000);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }
        public void InicializaStatusMedio()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 15);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.status = new StatusDoCliente() { IdStatus = 2, NomeStatus = "Medio" };
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 2000);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }
        public void InicializaStatusRuim()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 100, categoria, 10);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.status = new StatusDoCliente() { IdStatus = 1, NomeStatus = "Ruim" };
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 500);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
        }
        #endregion

        [TestCategory("Cliente")]
        [TestMethod]
        public void ValidaStatusClienteBom()
        {
            InicializaStatusBom();
            status.VerificarStatusCliente(cliente);
            Assert.AreEqual(3, status.IdStatus);
        }
        [TestCategory("Cliente")]
        [TestMethod]
        public void ValidaStatusClienteMedio()
        {
            InicializaStatusMedio();
            status.VerificarStatusCliente(cliente);
            Assert.AreEqual(2, status.IdStatus);
        }
        [TestCategory("Cliente")]
        [TestMethod]
        public void ValidaStatusClienteRuim()
        {
            InicializaStatusRuim();
            status.VerificarStatusCliente(cliente);
            Assert.AreEqual(1, status.IdStatus);
        }
    }
}
