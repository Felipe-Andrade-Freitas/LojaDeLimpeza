using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Contato
    {
        private int idContato;
        private string nomeDoContato;
        private string email;

        public int IdContato { get { return this.idContato; } }
        public string NomeDoContato { get { return this.nomeDoContato; } }
        public string Email { get { return this.email; } }
        public List<Telefone> ListaDeTelefones = new List<Telefone>();
        
        public Contato(int id, string nomeDoContato, string email)
        {
            this.idContato = id;
            this.nomeDoContato = nomeDoContato;
            this.email = email;
        }
    }
}
