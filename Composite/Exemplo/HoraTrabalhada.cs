using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Exemplo
{
    public abstract class HoraTrabalhada
    {
        //Component
        public string Nome { get; set; }
        public virtual void Add(HoraTrabalhada component)
        { }
        public abstract int GetHoraTrabalhada();
    }
}
