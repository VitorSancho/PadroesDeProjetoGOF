using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Exercicio
{
    public class CafeExpresso : ICafe
    {
        public string Descricao()
        {
            return "Café Expresso";
        }

        public decimal Preco()
        {
            return 8M;
        }
    }
}
