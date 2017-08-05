using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public IList<Produto> ListaDeProduto = new List<Produto>();

        public Categoria(int id, string nome)
        {
            this.IdCategoria = id;
            this.NomeCategoria = nome;
        }
    }
}
