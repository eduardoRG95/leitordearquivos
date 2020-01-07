using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace agibank
{
    class FilterFile
    {
        public static void createOutputFile(List<Vendedor> listVendedor, List<Cliente> listCliente, List<Venda> listVenda, string outFile)
        {
            const string PATH_DESTINY = @".\data\out";
            string[] lines = {
                    FilterFile.countSalesman(listVendedor),
                    FilterFile.countClient(listCliente),
                    FilterFile.findSaleMaxPrice(listVenda),
                    FilterFile.worstSeller(listVenda)
                };
            var fileName = outFile.Split(".");
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(PATH_DESTINY,  fileName[0] + ".txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        public static string countSalesman(List<Vendedor> listVendedor)
        {
            return "Quantidade de vendedores: " + listVendedor.Count;
        }
        public static string countClient(List<Cliente> listCliente)
        {
            return "\n Quantidade de clientes: " + listCliente.Count;
        }
        public static string findSaleMaxPrice(List<Venda> listVenda)
        {
            double maxPrice = 0;
            string idMaxSale = null;
            foreach (var venda in listVenda)
            {
                double priceSale = 0;
                foreach (var item in venda.Item)
                {
                    priceSale += item.Price;
                }
                if (priceSale > maxPrice)
                {
                    maxPrice = priceSale;
                    idMaxSale = venda.IdVenda;
                }
            }
            return "\n ID da venda mais caras: " + idMaxSale;
        }
        public static string worstSeller(List<Venda> listVenda)
        {
            double minPrice = 0;
            double priceSale = 0;
            string nameSeller = null;
            var usersGroupedByCountry = listVenda.GroupBy(venda => venda.NomeVendedor);
            foreach (var group in usersGroupedByCountry)
            {
                foreach (var user in group)
                {
                    priceSale = 0;
                    foreach (var item in user.Item)
                    {
                        priceSale += item.Price;
                    }
                    if (minPrice == 0)
                    {
                        minPrice = priceSale;
                    }
                    if (priceSale < minPrice)
                    {
                        minPrice = priceSale;
                        nameSeller = user.NomeVendedor;
                    }
                }
            }
            return "\n O pior vendedor " + nameSeller;
        }

    }
}