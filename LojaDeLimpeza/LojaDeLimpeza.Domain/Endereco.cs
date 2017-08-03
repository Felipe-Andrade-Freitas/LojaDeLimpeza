using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Endereco
    {
        public int idEndereco;
        public string rua;
        public int numero;
        public string complemento;
        public string bairro;
        public string cidade;
        public string uf;
        public string cep;

        public int IdEndereco { get { return this.idEndereco; } }
        public string Rua { get { return this.rua; } }
        public int Numero { get { return this.numero; } }
        public string Complemento { get { return this.complemento; } }
        public string Bairro { get { return this.bairro; } }
        public string Cidade { get { return this.cidade; } }
        public string UF { get { return this.uf; } }
        public string CEP { get { return this.cep; } }

        public Endereco(int id, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            this.idEndereco = id;
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
        }
    }
}

// { return }
