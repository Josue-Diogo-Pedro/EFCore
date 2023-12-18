namespace Cursov1.Domain;

public class Pessoa
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}

public class Instrutor : Pessoa
{
    public DateTime Desde { get; set; }
    public string? Tecnologia { get; set; }
}

public class Aluno : Pessoa
{
    public int Idade { get; set; }
    public DateTime DataContrato { get; set; }
}
