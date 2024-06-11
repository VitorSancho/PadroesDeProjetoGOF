using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exercicio
{
    public class MeuGeradorGrafico : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }

        public List<int> YValores { get; set; }

        public void GerarGrafico(string titulo, List<string> xValores, List<int> yValores)
        {
            Console.WriteLine("Meu Gerador gráfico : Gerando gráfico");
        }
    }
}
