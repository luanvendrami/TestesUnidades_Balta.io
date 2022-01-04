using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Produto : Entity
    {
        public string Titulo { get; private set; }
        public decimal Preco { get; private set; }
        public bool Ativado { get; private set; }
        public Produto(string titulo, decimal preco, bool ativado)
        {
            Titulo = titulo;
            Preco = preco;
            Ativado = ativado;
        }
    }
}
