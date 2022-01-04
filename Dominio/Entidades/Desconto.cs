using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Desconto : Entity
    {
        public decimal Quantidade { get; private set; }
        public DateTime DataExpira { get; private set; }

        public Desconto(decimal quantidade, DateTime dataExpira)
        {
            Quantidade = quantidade;
            DataExpira = dataExpira;
        }

        public bool Valido()
        {
            return DateTime.Compare(DateTime.Now, DataExpira) < 0;
        }

        public decimal Valor()
        {
            if (Valido())
                return Quantidade;
            else
                return 0;
        }
    }
}
