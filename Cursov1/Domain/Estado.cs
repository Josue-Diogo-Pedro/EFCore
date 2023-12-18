namespace Cursov1.Domain;

public class Estado
{
    public int Id { get; set; }
    public string? Nome { get; set; }

    public Governador? Governador { get; set; }
    public ICollection<Cidade> Cidades { get;} = new List<Cidade>();
}

public class Governador
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Partido { get; set; }

    public int EstadoId { get; set; }
    public Estado? Estado { get; set; }
}

public class Cidade
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Estado Estado { get; set; }
}