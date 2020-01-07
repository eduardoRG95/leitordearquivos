class Vendedor {
    public int Id { get; set; }
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }
        
    public Vendedor(int id, string cpf, string nome,  double salario)
    {
        this.Id = id;
        this.Cpf = cpf;
        this.Nome = nome;
        this.Salario = salario;
    }    
} 