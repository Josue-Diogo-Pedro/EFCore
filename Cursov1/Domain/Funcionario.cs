namespace Cursov1.Domain;

public class Funcionario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public bool Excluido { get; set; }

    // EF Relational
    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; }
}





/*
public class Funcionario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    //public string? RG { get; set; }

    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; }
}
*/