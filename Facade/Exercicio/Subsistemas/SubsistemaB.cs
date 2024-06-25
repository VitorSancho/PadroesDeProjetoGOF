using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Exercicio.Subsistemas
{
    public class SubsistemaB
    {
        public List<Livro> listaDeLivros;
        public SubsistemaB()
        {
            listaDeLivros = new List<Livro>()
            {
                new Livro() { Id = 4, Preco = 110.1, ISBN = "11111", Titulo ="Livro 1"},
                new Livro() { Id = 5, Preco = 223.2, ISBN = "22222", Titulo ="Livro 2"},
                new Livro() { Id = 6, Preco = 330.3, ISBN = "33333", Titulo ="Livro 3"},
            };
        }

        public Livro PesquisaLivro(string ISBN)
        {
            return listaDeLivros.Where(livro => livro.ISBN == ISBN).FirstOrDefault();
        }
    }
}
