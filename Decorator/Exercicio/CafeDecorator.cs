using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Exercicio
{
    public abstract class CafeDecorator : ICafe
    {
        public ICafe cafe;
        public string descricao;
        public decimal preco;
        public CafeDecorator(ICafe cafe)
        {
            this.cafe = cafe;
        }

        public virtual string Descricao()
        {
            return cafe.Descricao() + descricao;
        }

        public virtual decimal Preco()
        {
            return cafe.Preco() + preco;
        }
    }
}
