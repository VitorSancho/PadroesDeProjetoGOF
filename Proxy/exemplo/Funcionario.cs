using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.exemplo
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Perfil { get; set; }

        public Funcionario(string nome, string perfil)
        {
            Nome = nome;
            Perfil = perfil;
        }
    }
}
