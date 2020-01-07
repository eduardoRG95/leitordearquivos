using System.Collections.Generic;

class Venda {
    public int Id { get; set; }
    public string IdVenda { get; set; }
    public List<Item> Item { get; set; }
    public string NomeVendedor { get; set; }
        
    public Venda(int id, string idVenda, List<Item> item, string nomeVendedor)
    {
        this.Id = id;
        this.IdVenda = idVenda;
        this.Item = item;
        this.NomeVendedor = nomeVendedor;
    }    
} 