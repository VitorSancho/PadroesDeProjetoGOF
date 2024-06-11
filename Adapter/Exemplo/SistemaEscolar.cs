using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exemplo
{
    //client
    public class SistemaEscolar
    {
        public static string[,] GetListaAlunosMensalidade()
        {
            string[,] alunosArray = new string[2,4]
            {
                { "101","Maria","Artes","1000" },
                { "102","Pedro","Engenharia","2000" }
            };

            return alunosArray;
        }
    }
}
