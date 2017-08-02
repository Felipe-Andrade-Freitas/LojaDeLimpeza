using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Categoria
    {
        public int idCategoria;
        public string nomeCategoria;

        public int IdCategoria { get { return this.idCategoria; } }
        public string NomeCategoria { get { return this.nomeCategoria; } }
        public IList<Produto> ListaDeProduto = new List<Produto>();

        public Categoria(int id, string nome)
        {
            this.idCategoria = id;
            this.nomeCategoria = nome;
        }
    }
}
