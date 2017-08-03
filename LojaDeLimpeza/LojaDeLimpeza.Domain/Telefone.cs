using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Telefone
    {
        public int idTelefone;
        public string numTelefone;

        public int IdTelefone { get { return this.idTelefone; } }
        public string NumTelefone { get { return this.numTelefone; } }

        public Telefone(int id, string telefone)
        {
            this.idTelefone = id;
            this.numTelefone = telefone;
        }
    }
}
