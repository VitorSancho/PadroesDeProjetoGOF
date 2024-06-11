using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exemplo
{
    //adapter
    public class AlunosAdapter : ICalculaMensalidade
    {
        private SistemaMensalidades sistemaMensalidades = new SistemaMensalidades();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Mensalidade = null;
            List<Aluno> listaAlunos = new List<Aluno>();

            ConverteArrayParaList(alunosArray, Id, Nome, Mensalidade, listaAlunos);

            sistemaMensalidades.CalculaMensalidade(listaAlunos);
        }

        private void ConverteArrayParaList(string[,] alunosArray, string? id, string? nome, string? mensalidade, List<Aluno> listaAlunos)
        {
            for (int i=0; i < alunosArray.GetLength(0); i++)
            {
                for (int j=0;j<alunosArray.GetLength(1);j++) { 
                    if (j==0)
                    {
                        id = alunosArray[i,j];
                    }
                    else if (j == 1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else
                    {
                        mensalidade = alunosArray[i, j];
                    }
                }

                listaAlunos.Add(new Aluno(Convert.ToInt32(id), nome, Convert.ToDecimal(mensalidade)));
            }
        }
    }
}
