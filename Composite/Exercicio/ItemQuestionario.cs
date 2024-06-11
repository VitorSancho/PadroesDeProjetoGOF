using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Exercicio
{
    //component
    public abstract class ItemQuestionario
    {
        public string Descricao { get; set; }
        public abstract void Exibir();
        public void Add() { }
        public void Remove() { }
    }
}
