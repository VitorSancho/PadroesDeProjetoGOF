using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.exercicio
{
    public class InternetProxy : IInternet
    {
        private IInternet internet;
        private List<string> listaDeSitesPermitidos;

        public InternetProxy()
        {
            this.internet = new Internet();   
            listaDeSitesPermitidos= new List<string>
            {"youtube","google","gmail"
            };
        }

        public void AcessaSite(string site)
        {
            if (listaDeSitesPermitidos.Contains(site))
            {
                Console.WriteLine("Acessando funcionalidade do real subject");
                internet.AcessaSite(site);
            }
            else
            {
                Console.WriteLine("####### Site não permitido");
            }
        }
    }
}
