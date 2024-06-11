using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pasta
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {

            return base.Opcionais() + "\r\n com Borda Recheada";
        }

        public override decimal Preco()
        {
            return base.Preco() + 5M;
        }

    }
}
