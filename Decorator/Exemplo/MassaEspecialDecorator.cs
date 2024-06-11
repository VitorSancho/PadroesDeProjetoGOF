﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pasta
{
    public class MassaEspecialDecorator : PizzaDecorator
    {
        public MassaEspecialDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {

            return base.Opcionais() + "\r\n com Massa especial";
        }

        public override decimal Preco()
        {
            return base.Preco() + 2M;
        }

    }
}
