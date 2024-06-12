using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Exemplo.Subsistemas
{
    public class LimiteCredito
    {
        public bool PossuiLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine($"Verificando o limite de {valor} reais para crédito " +
                $"                  do cliente {cliente.Nome}");

            if (valor <20000.00)
            {
                return false;
            }
            return true;
        }
    }
}
