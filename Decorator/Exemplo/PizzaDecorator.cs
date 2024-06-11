using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pasta
{
    public abstract class PizzaDecorator : IPizza
    {
        protected readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string Opcionais()
        {
            return _pizza.Opcionais();
        }

        public virtual decimal Preco()
        {
            return _pizza.Preco();
        }
    }
}
