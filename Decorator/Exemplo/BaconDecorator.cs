using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pasta
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {

            return base.Opcionais() + "\r\n com Bacon";
        }

        public override decimal Preco()
        {
            return base.Preco() + 4M;
        }

    }
}
