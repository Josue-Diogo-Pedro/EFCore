namespace Cursov1.Domain;

public class Ator
{
    public int Id { get; set; }
    public string? Nome { get; set; }

    public ICollection<Filme>? Filmes { get; set; } = new List<Filme>();
}

public class Filme
{
    public int Id { get; set; }
    public string? Descricao { get; set; }

    public ICollection<Ator>? Atores { get; set; } = new List<Ator>();
}
