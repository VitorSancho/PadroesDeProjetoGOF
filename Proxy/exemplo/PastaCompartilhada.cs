using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.exemplo
{
    //RealSubject
    // objeto que queremos usar de forma mais eficiente usando a classe proxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            Console.WriteLine("### operaçao de escrita e leitura foi executada");
        }
    }
}
