using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Exercicio
{
    //leaf
    public class Questao : ItemQuestionario
    {
        public override void Exibir()
        {
            Console.WriteLine($"Descricao {Descricao}");
        }
    }
}
