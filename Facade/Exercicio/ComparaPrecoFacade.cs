using Facade.Exercicio.Subsistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Exercicio
{
    public class ComparaPrecoFacade
    {
        public SubsistemaA subsistemaA;
        public SubsistemaB subsistemaB;
        public ComparaPrecoFacade()
        {
            subsistemaA = new SubsistemaA();
            subsistemaB = new SubsistemaB();
        }

        public List<Livro> Comparar(string ISBN)
        {
            var listaDeLivro = new List<Livro>();
            listaDeLivro.Add(subsistemaA.PesquisaLivro(ISBN));
            listaDeLivro.Add(subsistemaB.PesquisaLivro(ISBN));

            return listaDeLivro.OrderBy(livro => livro.Preco).ToList();
            
        }
    }
}
