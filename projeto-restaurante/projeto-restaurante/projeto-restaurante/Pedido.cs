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
            int jj;
            bool removeu = false;
            foreach (Item i in itens)
            {
                if (i.Id == item.Id)
                {
                    int ii = 0;
                    while (ii < this.itens.Length && this.itens[ii].Id != item.Id)
                    {
                        ii++;
                    }
                    for (jj = ii; jj < this.itens.Length - 1; jj++)
                    {
                        this.itens[jj] = this.itens[jj + 1];
                    }
                    this.itens[jj] = new Item();
                    removeu = true;
                    break;
                }
            }
            return removeu;
        }

        public string dadosDoPedido()
        {
            string itensDados = "";
            foreach (Item item in this.itens)
            {
                if (item.Id != -1) 
                {
                    itensDados += $" ID: {item.Id}\n" +
                        $" Descrição: {item.Descricao}\n" +
                        $" Preço: {item.Preco.ToString("f")}\n" +
                        $"{new string('-', 44)}\n";
                }
            }
            return $" ID do pedido: {this.Id}\n" +
                $" Cliente: {this.Cliente}\n" +
                $"{new string('-', 44)}\n" +
                $"{itensDados}";
        }

        public double calcularTotal()
        {
            double total = 0;
            foreach (Item item in this.itens)
            {
                total += item.Preco;
            }
            return total;
        }
        
    }
}
