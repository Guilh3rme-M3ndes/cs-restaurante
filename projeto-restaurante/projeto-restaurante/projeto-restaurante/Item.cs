using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_restaurante
{
    internal class Item
    {
        private int id;
        private string descricao;
        private double preco;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }

        public Item(int id, string descricao, double preco)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
        }

        public Item(int id) : this(id, "", 0) { }

        public Item() : this(-1, "", 0) { }
    }
}
