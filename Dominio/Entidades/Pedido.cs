using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pedido : Entity
    {
        public Pedido(Cliente cliente, DateTime data, string numero, IList<ItemPedido> items, decimal taxaEntrega, Desconto desconto, EStatusPedido status)
        {
            Cliente = cliente;
            Data = DateTime.Now;
            Numero = Guid.NewGuid().ToString().Substring(0, 8);
            Items = new List<ItemPedido>();
            TaxaEntrega = taxaEntrega;
            Desconto = desconto;
            Status = EStatusPedido.AguadandoPagamento;
        }

        public Cliente Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public string Numero { get; private set; }
        public IList<ItemPedido> Items { get; private set; }
        public decimal TaxaEntrega { get; private set; }
        public Desconto Desconto { get; private set; }
        public EStatusPedido Status { get; private set; }

        public void AddItem(Produto produto, int quantidade)
        {
            var item = new ItemPedido(produto, quantidade);
            Items.Add(item);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Total();
            }

            total += TaxaEntrega;
            total -= Desconto != null ? Desconto.Valor() : 0;

            return total;
        }

        public void Pagamento(decimal quantidade)
        {
            if (quantidade == Total())
                this.Status = EStatusPedido.AguardandoEntrega;
        }

        public void Cancelamento()
        {
            Status = EStatusPedido.Cancelado;
        }
    }
}
