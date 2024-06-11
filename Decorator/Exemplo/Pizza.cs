using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pasta
{
    public class Pizza : IPizza
    {
        public string Nome { get; set; }
        public Pizza(string nome)
        {
            Nome = nome;
        }
        public string Opcionais()
        {
            var opcional = $"Pizza de {Nome}";
            return opcional;
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}
