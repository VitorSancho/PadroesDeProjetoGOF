﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exercicio
{
    //Adaptee
    public class SuperGeradorGrafico
    {
        public void Init() { }

        public void DesenharGrafico(string titulo, List<string> x, List<int> y) {
            Console.WriteLine("SuperGerador: gerando");
        }
    }
}
