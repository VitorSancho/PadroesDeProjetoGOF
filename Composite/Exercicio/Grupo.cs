using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Exercicio
{
    //composite
    public class Grupo : ItemQuestionario
    {
        public List<ItemQuestionario> listaDeItens = new List<ItemQuestionario>();
        
        public void Add(ItemQuestionario item)
        {
            listaDeItens.Add(item);
        }

        public void Remove(ItemQuestionario item)
        {
            listaDeItens.Remove(item);  
        }

        public override void Exibir()
        {
            Console.WriteLine($"Grupo {Descricao}");
            foreach(var item in listaDeItens)
            {
                item.Exibir();
            }
        }
    }
}
