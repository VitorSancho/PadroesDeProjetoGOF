using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.exercicio
{
    public class Internet : IInternet
    {
        public void AcessaSite(string site)
        {
            Console.WriteLine($"##### acessando site - {site}");
        }
    }
}
