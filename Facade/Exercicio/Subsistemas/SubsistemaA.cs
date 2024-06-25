using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Exercicio.Subsistemas
{
    public class SubsistemaA
    {
        public List<Livro> listaDeLivros;
        public SubsistemaA()
        {
            listaDeLivros = new List<Livro>()
            {
                new Livro() { Id = 1, Preco = 111.1, ISBN = "11111", Titulo ="Livro 1"},
                new Livro() { Id = 2, Preco = 222.2, ISBN = "22222", Titulo ="Livro 2"},
                new Livro() { Id = 3, Preco = 333.3, ISBN = "33333", Titulo ="Livro 3"},
            };
        }

        public Livro PesquisaLivro(string ISBN)
        {
            
            return listaDeLivros.Where(livro => livro.ISBN == ISBN).FirstOrDefault();
        }
    }
}
