using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.Test
{
    [TestClass]
    public class ProdutoTeste
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

            produto.ValidaPrecoProduto();
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaPrecoProdutoNegativo()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, -10);

            produto.ValidaPrecoProduto();
        }

        [TestCategory("Produto")]
        [TestMethod]
        public void TestValidaPrecoProduto()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 5);

            produto.ValidaPrecoProduto();

            Assert.AreEqual(5, produto.Preco);
        }

        [TestCategory("Produto")]
        [TestMethod]
        [ExpectedException(typeof(Exception), "Preço do produto deve ser maior que zero")]
        public void TestValidaQuantidadeProduto()
        {
            var categoria = new Domain.Categoria(1, "Lavanderia");
            var produto = new Domain.Produto(1, "Sabão em pó", new DateTime(2017, 07, 12), new DateTime(2018, 08, 12), 10, categoria, 0);

            var item = new Domain.ItemDePedido(1, 10, produto);

            item.CalculaValorDoItem();
        }
    }
}
