class Cliente {
    public int Id { get; set; }
    public string Cnpj { get; set; }
    public string Nome { get; set; }
    public string Area { get; set; }
        
    public Cliente(int id, string cnpj, string nome, string area)
    {
        this.Id = id;
        this.Cnpj = cnpj;
        this.Nome = nome;
        this.Area = area;
    }    
} 