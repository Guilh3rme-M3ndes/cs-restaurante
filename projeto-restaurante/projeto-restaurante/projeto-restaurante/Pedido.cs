using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_restaurante
{
    internal class Pedido
    {
        private int id;
        private string cliente;
        private Item[] itens = new Item[10];

        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public Item[] Itens { get => itens; }

        public Pedido(int id, string cliente)
        {
            Id = id;
            Cliente = cliente;
            for(int ii = 0; ii < itens.Length; ii++)
            {
                itens[ii] = new Item();
            }
        }

        public Pedido(int id): this(id, "") { }

        public Pedido(): this(-1, "") { }

        public bool adicionarItem(Item item)
        {
            bool adicionou = false;
            for(int ii = 0; ii < itens.Length; ii++)
            {
                if(itens[ii].Id == item.Id)
                {
                    break;
                }
                if(itens[ii].Id == -1)
                {
                    itens[ii] = item;
                    adicionou = true;
                    break;
                }
            }
            return adicionou;
        }

        public bool removerItem(Item item)
        {
            return false;
        }

        public string dadosDoPedido()
        {
            return "";
        }

        public double calcularTotal()
        {
            return 0;
        }
    }
}
