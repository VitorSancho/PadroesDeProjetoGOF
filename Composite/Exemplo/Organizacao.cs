using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Exemplo
{
    //COMPOSITE -> deve implementar todos os métodos que o leaf implementa
    // pode implementar métodos que o leaf não possui
    public class Organizacao : HoraTrabalhada
    {
        protected List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>();
        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }
        public override int GetHoraTrabalhada()
        {
            var horasTrabDepartaemnto = 0;
            foreach (var departamento in departamentos)
            {
                horasTrabDepartaemnto += departamento.GetHoraTrabalhada();
            }
            Console.WriteLine($"{Nome} registrou um total de {horasTrabDepartaemnto} \n");
            return horasTrabDepartaemnto;
        }
    }
}
