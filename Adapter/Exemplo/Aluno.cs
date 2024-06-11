using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Exemplo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Mensalidade { get; set; }

        public Aluno(int id, string name, decimal mensalidade)
        {
            Id = id;
            Name = name;
            Mensalidade = mensalidade;  
        }
    }
}
