using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class ItemPedido : Entity
    {
        public Produto Produto { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public ItemPedido(Produto produto, decimal preco, int quantidade)
        {
            Produto = produto;
            Preco = Produto != null ? produto.Preco : 0;
            Quantidade = quantidade;
        }
        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public decimal Total()
        {
            return Preco * Quantidade;
        }
    }
}
