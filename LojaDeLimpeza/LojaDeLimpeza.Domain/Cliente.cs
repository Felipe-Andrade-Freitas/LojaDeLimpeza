using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Cliente
    {
        private int idCliente;
        private string nomeDoCliente;
        private string cpf;
        private string filiacao;
        private Contato contato;
        private Endereco endereco;
        private StatusDoCliente statusDoCliente;

        public int IdCliente { get { return this.idCliente; } }
        public string NomeCliente { get { return this.nomeDoCliente; } }
        public string CPF { get { return this.cpf; } }
        public string Filiacao { get { return this.filiacao; } }
        public Contato Contato { get { return this.contato; } }
        public Endereco Endereco { get { return this.endereco; } }
        public StatusDoCliente StatusDoCliente { get { return this.statusDoCliente; } }
        public IList<Pedido> ListaDePedido = new List<Pedido>();

        public Cliente(int id, string nomeDoCliente, string cpf, string filiacao, Contato contato, Endereco endereco, StatusDoCliente statusDoCliente)
        {
            this.idCliente = id;
            this.nomeDoCliente = nomeDoCliente;
            this.cpf = cpf;
            this.filiacao = filiacao;
            this.contato = contato;
            this.endereco = endereco;
            this.statusDoCliente = statusDoCliente;

        }
    }
}
