using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exercicio
{
    public class GraficoAdapter : IGrafico
    {
        SuperGeradorGrafico geradorGrafico = new SuperGeradorGrafico();

        public string Titulo { get ; set ; }
        public List<string> XValores { get ; set ; }
        public List<int> YValores { get ; set ; }

        public void GerarGrafico(string titulo, List<string> xValores, List<int> yValores)
        {
            geradorGrafico.DesenharGrafico(titulo, xValores, yValores);
        }
    }
}
