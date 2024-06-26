using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.exemplo
{
    //Subject
    // define os membros que serão implementados pelas classes RealSubject e Proxy
    public interface IPastaCompartilhada
    {
        void OperacaoDeLeituraGravacao();
    }
}
