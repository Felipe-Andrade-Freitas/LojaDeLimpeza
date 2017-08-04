using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Fornecedor
    {
        public int idFornecedor;
        public string cnpj;
        public string nomeFantasia;
        public string razaoSocial;

        public int IdFornecedor { get { return this.idFornecedor; } }
        public string CNPJ { get { return this.cnpj; } }
        public string NomeFantasia { get { return this.nomeFantasia; } }
        public string RazaoSocial { get { return this.razaoSocial; } }
    }
}
