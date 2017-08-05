using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Contato
    {
        public int IdContato { get; set; }
        public string NomeDoContato { get; set; }
        public string Email { get; set; }
        public List<Telefone> ListaDeTelefones = new List<Telefone>();
        
        public Contato(int id, string nomeDoContato, string email)
        {
            this.IdContato = id;
            this.NomeDoContato = nomeDoContato;
            this.Email = email;
        }
    }
}
