using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Exercicio
{
    public class CafeFiltrado : ICafe
    {
        public string Descricao()
        {
            return "Café Filtrado";
        }

        public decimal Preco()
        {
            return 5M;
        }
    }
}
