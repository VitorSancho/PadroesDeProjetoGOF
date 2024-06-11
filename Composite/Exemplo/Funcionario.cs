using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Exemplo
{
    //leaf -> utulizando herança, a classe não é obrigada a implementar o método Add
    //o leaf somente deve implementar os método que o dizem repeito, não precisa implementar todos os métodos
    // que as camadas acima implementar
    public class Funcionario : HoraTrabalhada
    {
        public int Horas { get; set; }
        public override int GetHoraTrabalhada()
        {
            //logica
            Console.WriteLine($"O funcionario {Nome} registrou {Horas} horas trabalhadas");
            return Horas;
        }
    }
}
