using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exercicio
{
    public interface IGrafico
    {
        string Titulo { get; set; }
        List<string> XValores { get; set; }
        List<int> YValores { get; set; }
        void GerarGrafico(string titulo, List<string> xValores, List<int> yValores);
    }
}
