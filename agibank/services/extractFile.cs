using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace agibank
{
    class ExtractFile
    {
        public static void createLists(List<string> lines, string arquivo)
        {
            List<Vendedor> listVendedor = new List<Vendedor>();
            List<Cliente> listCliente = new List<Cliente>();
            List<Venda> listVenda = new List<Venda>();

            foreach (var line in lines)
            {
                string[] words = line.Split('ç');
                switch (Convert.ToInt32(words[0].Trim()))
                {
                    case 1:
                        listVendedor.Add(createVendedor(words));
                        break;
                    case 2:
                        listCliente.Add(createCliente(words));
                        break;
                    case 3:
                        listVenda.Add(createVenda(words));
                        break;
                    default:
                        Console.WriteLine("Linha do arquivo fora do padrão");
                        break;
                }
            }
                FilterFile.createOutputFile(listVendedor, listCliente, listVenda, arquivo);

        }

        private static Venda createVenda(string[] words)
        {
            return new Venda(
                Convert.ToInt32(words[0].Trim()),
                words[1].Trim(),
                createItem(words[2].Trim()),
                words[3]
            );
        }
       
        private static Cliente createCliente(string[] words)
        {
            return new Cliente(
                Convert.ToInt32(words[0].Trim()),
                words[1].Trim(),
                words[2].Trim(),
                words[3]
            );
        }

        private static Vendedor createVendedor(string[] words)
        {
            return new Vendedor(
                Convert.ToInt32(words[0].Trim()),
                words[1].Trim(),
                words[2].Trim(),
                Convert.ToDouble(words[3].Replace(".",","))
            );
        }

        private static List<Item> createItem(string item)
        {
            List<Item> listItems = new List<Item>(); ;
            item = item.Replace("[", "").Replace("]", "");
            string[] vendas = item.Split(',');
            foreach (var itenVenda in vendas)
            {
                var itens = itenVenda.Split('-');
                listItems.Add(new Item(Convert.ToInt32(itens[0].Trim()),
                                    Convert.ToInt32(itens[1].Trim()),
                                    Convert.ToDouble(itens[2].Replace(".",","))));
            }
            return listItems;
        }

    }
}