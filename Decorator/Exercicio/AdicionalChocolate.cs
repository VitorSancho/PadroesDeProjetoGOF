using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Exercicio
{
    public class AdicionalChocolate : CafeDecorator
    {
        public AdicionalChocolate(ICafe cafe) : base(cafe)
        {
            descricao = " \n\r adicional de Chocolate";
            preco = 10M;
        }
    }
}
