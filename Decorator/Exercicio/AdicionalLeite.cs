using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Exercicio
{
    public class AdicionalLeite : CafeDecorator
    {
        public AdicionalLeite(ICafe cafe) : base(cafe)
        {
            descricao = " \n\r adicional de Leite";
            preco = 2M;
        }
    }
}
