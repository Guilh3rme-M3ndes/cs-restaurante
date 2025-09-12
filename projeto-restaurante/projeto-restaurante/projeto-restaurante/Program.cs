/*
| Instituto Federal de São Paulo - Campus Cubatão
| Nome: Guilherme Mendes de Sousa - CB3030857
| Nome: Stiven Richardy Silva Rodrigues - CB3030202
| Turma: ADS 471
| 
| Opções no seletor:
| 0. Sair
| 1. Criar novo pedido
| 2. Adicionar item ao pedido
| 3. Remover item do pedido
| 4. Consultar pedido (mostrar id, cliente, itens e valor total)
| 5. Cancelar pedido
| 6. Listar todos os pedidos (com id, valores totais e soma geral do dia)
|
| Requisitos:
| Uma cozinha industrial atende diariamente até 50 pedidos feitos por clientes e numerados sequencialmente.
| Cada um desses pedidos pode ter, no máximo, 10 itens, cada um com um preço no cardápio.
| O sistema deve calcular o valor total dos pedidos e permitir consultar o histórico.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_restaurante
{
    internal class Program
    {
        // public static Item item = new Item();
        public static Pedido pedido = new Pedido();
        public static Restaurante restaurante = new Restaurante();
        public static int idPedido = 0;
        public static int idItem = 0;

        static void Main(string[] args)
        {
            int seletor = -1;
            while (seletor != 0)
            {
                Console.Clear();
                Utils.Titulo("PAINEL PRINCIPAL");
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine(" 1 - Criar novo pedido");
                Console.WriteLine(" 2 - Adicionar item ao pedido");
                Console.WriteLine(" 3 - Remover item do pedido");
                Console.WriteLine(" 4 - Consultar pedido");
                Console.WriteLine(" 5 - Cancelar pedido");
                Console.WriteLine(" 6 - Listar todos os pedidos");
                Console.WriteLine("--------------------------------------------");
                Console.Write(" Escolha uma opção: ");
                seletor = Utils.lerInt(Console.ReadLine(), 0, " Entrada inválida!\n Informe outro número: ");

                switch (seletor)
                {
                    case 0:
                        Console.WriteLine(" Programa finalizado!");
                        break;
                    case 1:
                        novoPedido();
                        break;
                    case 2:
                        adicionarItemPedido();
                        break;
                    case 3:
                        removerItemPedido();
                        break;
                    case 4:
                        consultarPedido();
                        break;
                    case 5:
                        cancelarPedido();
                        break;
                    case 6:
                        listarPedidos();
                        break;
                    default:
                        Utils.MensagemErro("Digite um número de 0-6!");
                        break;
                }
            }
        }

        public static void novoPedido()
        {
            Utils.Titulo("NOVO PEDIDO");
            Console.Write(" Informe o nome do cliente: ");
            string nome = Console.ReadLine();
            Pedido novoPedido = new Pedido(idPedido, nome);
            if (restaurante.novoPedido(novoPedido))
            {
                Utils.MensagemSucesso($"ID do Pedido: {novoPedido.id}\n Pedido adicionado!");
                idPedido++;
            }
            else
                Utils.MensagemErro("Não foi possível adicionar o pedido.");
        }

        public static void adicionarItemPedido()
        {
            Utils.Titulo("ADICIONAR ITEM");
            Console.Write(" Digite o ID do Pedido: ");
            int idPed = Utils.lerInt(Console.ReadLine(), 0, " Entrada inválida!\n Tente novamente: ");
            if (restaurante.buscarPedido(new Pedido(idPed).Id) == -1)
            {
                Console.Write(" Digite a Descrição do Item: ");
                string descricao = Console.ReadLine();
                Console.Write(" Digite o Preço do Item: ");
                string descricao = Utils.lerDouble(Console.ReadLine(), 0, " Entrada inválida!\n Tente novamente: ");
                Item novoItem = new Item(idItem, descricao, preco);
                if (pedido.adicionarItem(novoItem))
                {
                    Utils.MensagemSucesso($"ID do Item: {novoItem.id}\n Descrição: {novoItem.Descricao}\n Preço: {novoItem.Preco}\n Item adicionado!");
                    idItem++;
                }
                else
                    Utils.MensagemErro("Limite máximo de itens atingido.");
            }
            else
                Utils.MensagemErro("ID do Pedido não encontrado.");
        }

        public static void removerItemPedido()
        {

        }

        public static void consultarPedido()
        {

        }

        public static void cancelarPedido()
        {
            
        }

        public static void listarPedidos()
        {

        }
    }
}
