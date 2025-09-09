using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_restaurante
{
    internal class Restaurante
    {
        private int proxPedido;
        private Pedido[] pedidos = new Pedido[50];

        public int ProxPedido { get => proxPedido; set => proxPedido = value; }
        public Pedido[] Pedidos { get => pedidos; }

        public Restaurante(int proxPedido)
        {
            this.proxPedido = proxPedido;
            for(int ii = 0; ii < this.pedidos.Length; ii++)
            {
                this.pedidos[ii] = new Pedido();
            }
        }

        public Restaurante(): this(0) { }

        public bool novoPedido(Pedido pedido) 
        {
            return false;
        }

        public Pedido buscarPedido(Pedido pedido)
        {
            return new Pedido();
        }

        public bool cancelarPedido(Pedido pedido)
        {
            return false;
        }
    }
}
