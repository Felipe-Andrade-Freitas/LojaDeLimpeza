using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string Filiacao { get; set; }
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
        public StatusDoCliente StatusDoCliente { get; set; }
        public IList<Pedido> ListaDePedido = new List<Pedido>();

        public Cliente(int id, string nomeDoCliente, string cpf, string filiacao, Contato contato, Endereco endereco, StatusDoCliente statusDoCliente)
        {
            this.IdCliente = id;
            this.NomeCliente = nomeDoCliente;
            this.CPF = cpf;
            this.Filiacao = filiacao;
            this.Contato = contato;
            this.Endereco = endereco;
            this.StatusDoCliente = statusDoCliente;

        }
    }
}
