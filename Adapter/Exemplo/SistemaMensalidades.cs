using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exemplo
{
    //adaptee
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach(Aluno aluno in listaAlunos)
            {
                var mensalidade = aluno.Mensalidade * 1.1M;

                Console.WriteLine($"Aluno {aluno.Name} mensalidade {aluno.Mensalidade}");
            }
        }
    }
}
