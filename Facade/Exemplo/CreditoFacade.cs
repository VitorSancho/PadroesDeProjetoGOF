using Facade.Exemplo.Subsistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Exemplo
{
    public class CreditoFacade
    {
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public CreditoFacade()
        {
            limite = new LimiteCredito();
            serasa = new Serasa();
            cadastro = new Cadastro();
            cadin = new Cadin();
        }

        public bool ConcederEmprestimo(Cliente cliente , double valor)
        {
            Console.WriteLine($"{cliente.Nome} esta pleiteando emprestimo no valor de {valor}");

            cadastro.CadastrarCliente( cliente );

            bool concederEmprestimo = true;

            if(serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine($"Cliente {cliente.Nome} possui restrução no SERASA");
                concederEmprestimo = false;
            }
            else if (cadin.EstaNoCadin(cliente))
            {
                Console.WriteLine($"Cliente {cliente.Nome} possui restrução no CADIN");
                concederEmprestimo = false;
            }
            if (limite.PossuiLimiteCredito(cliente, valor))
            {
                Console.WriteLine($"Cliente {cliente.Nome} possui limite inferior a {limite}");
                concederEmprestimo = false;
            }

            return concederEmprestimo;
        }
    }
}
