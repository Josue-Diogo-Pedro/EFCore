using Microsoft.EntityFrameworkCore;

namespace Cursov1.Domain;

public class Documento
{
    private string? _cpf;
    public int Id { get; set; }

    public void SetCPF(string cpf)
    {
        //Validar cpf
        if (string.IsNullOrWhiteSpace(cpf))
            throw new Exception("CPF inválido");

        _cpf = cpf;
    }

    [BackingField(nameof(_cpf))]
    public string? CPF => _cpf;

    public string GetCPF() => _cpf;
}
