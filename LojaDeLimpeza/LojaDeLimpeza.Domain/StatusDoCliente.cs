using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class StatusDoCliente
    {
        public int idStatus;
        public string nomeStatus;

        public int IdStatus { get { return this.idStatus; } }
        public string NomeStatus { get { return this.nomeStatus; } }

        public StatusDoCliente(int id, string nomeStatus)
        {
            this.idStatus = id;
            this.nomeStatus = nomeStatus;
        }        
    }
}
