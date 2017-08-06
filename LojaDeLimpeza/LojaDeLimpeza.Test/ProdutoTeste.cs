using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ProdutoTeste
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

        public void Inicializa()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 30, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 1);
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
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
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
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }
        public void InicializaQuantidadeEstoque()
        {
            this.categoria = new Domain.Categoria(1, "Lavanderia");
            this.produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 30, categoria, 5);
            this.item = new Domain.ItemDePedido(1, 10, produto);
            this.item2 = new Domain.ItemDePedido(2, 5, produto);
            this.endereco = new Domain.Endereco(1, "D. Pedro X", 12, "Apt 208", "Centro", "Belo Horizonte", "MG", "31454-432");
            this.telefone = new Domain.Telefone(1, "(31) 3456-5464");
            this.contato = new Domain.Contato(1, "Silvio", "silvio@gmail.com");
            contato.ListaDeTelefones.Add(telefone);
            this.cliente = new Domain.Cliente(1, "José do Carmo", "098.367.235-03", "Maira das Dores", contato, endereco, 3);
            this.pedido = new Domain.Pedido(1, new DateTime(2017, 08, 02), cliente);
            pedido.ListaDeItemPedido.Add(item);
            pedido.ListaDeItemPedido.Add(item2);
        }
        #endregion

        #region Adiciona em Estoque
        [TestCategory("Produto")]
        [TestMethod]
        public void TestAdicionaEmEstoque()
        {
            Inicializa();
            produto.AdicionaEstoque(10);
            Assert.AreEqual(25, produto.QuantidadeEmEstoque);
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestAdicionaEmEstoqueValorNegativo()
        {
            InicializaValorNegativo();
            produto.AdicionaEstoque(-10);
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestAdicionaEmEstoqueValorZero()
        {
            InicializaValorZero();
            produto.AdicionaEstoque(0);
        }
        #endregion

        #region Remover Estoque
        [TestCategory("Produto")]
        [TestMethod]
        public void TestRemoveEstoque()
        {
            Inicializa();
            produto.RemoverEstoque(5);
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoveEstoqueValorNegativo()
        {
            InicializaValorNegativo();
            produto.RemoverEstoque(-10);
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade á ser adicionada deve ser maior que zero")]
        public void TestRemoveEstoqueValorZero()
        {
            InicializaValorZero();
            produto.RemoverEstoque(0);
        }
        #endregion

        #region Valida preco do produto
        [TestCategory("Produto")]
        [TestMethod]
        public void TestValidaPrecoProduto()
        {
            Inicializa();
            produto.ValidaPrecoProduto();
            Assert.AreEqual(5, produto.Preco);
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaPrecoProdutoZero()
        {
            InicializaValorZero();
            produto.ValidaPrecoProduto();
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaPrecoProdutoNegativo()
        {
            InicializaValorNegativo();
            produto.ValidaPrecoProduto();
        }
        #endregion

        #region Valida quantidade do Estoque
        [TestCategory("Produto")]
        [TestMethod]
        public void TestValidaQuantidadeEstoque()
        {
            Inicializa();
            Assert.AreEqual(15, produto.QuantidadeEmEstoque);
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ter o valor maior que zero")]
        public void TestValidaQuantidadeEstoqueZero()
        {
            InicializaValorZero();
        }
        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ter o valor maior que zero")]
        public void TestValidaQuantidadeEstoqueNegativo()
        {
            InicializaValorNegativo();
        }
        #endregion
    }
}
