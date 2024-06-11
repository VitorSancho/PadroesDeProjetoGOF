using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exemplo
{
    //Target
    public interface ICalculaMensalidade
    {
        void ProcessaCalculoMensalidade(string[,] alunosArray);
    }
}
