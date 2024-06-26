using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.exemplo
{
    //Proxy
    // contém uma referência à classe RealSubject e posse acessar
    // os membros da classe RealSubject conforme necessário
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada pasta;
        private Funcionario funcionario;

        public PastaCompartilhadaProxy(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }
        public void OperacaoDeLeituraGravacao()
        {
            if (funcionario.Perfil.ToUpper() == "CEO")
            {
                pasta = new PastaCompartilhada();
                Console.WriteLine(@"O proxy 'Pasta Compartilhada' invoca a pasta Real
                                        Método usado: OperacaoDeLeituraGravacao() \n");
            }
            else
            {
                Console.WriteLine(@"O proxy 'Pasta Compartilhada' avisa:
                                        'Você não tem permissãopara acessar esta pasta'\n");
            }
        }
    }
}
