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
            int quant;
            bool podeCriar = false;
            for (quant = 0; quant < Pedidos.Length; quant++)
            {
                if (Pedidos[quant].Id == -1)
                {
                    podeCriar = true;
                    Pedidos[quant] = pedido;
                    break;
                }
            }
            return podeCriar;
        }

        public Pedido buscarPedido(Pedido pedido)
        {
            Pedido achou = new Pedido();
            foreach (Pedido p in pedidos)
            {
                if (p.Id == pedido.Id)
                {
                    achou = p;
                    break;
                }
            }
            return achou;
        }

        public bool cancelarPedido(Pedido pedido)
        {
            return false;
        }
    }
}
