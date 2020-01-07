class Item {
    public int Id { get; set; } 
    public int Quantidade { get; set; }
    public double Price { get; set; }
        
    public Item(int id, int quantidade, double price)
    {
        this.Id = id;
        this.Quantidade = quantidade;
        this.Price = price;
    }    
} 