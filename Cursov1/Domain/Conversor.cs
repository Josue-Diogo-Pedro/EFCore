using System.Net;

namespace Cursov1.Domain;

public class Conversor
{
    public int Id { get; set; }
    public bool Ativo { get; set; }
    public bool Excluido { get; set; }
    public Versao Versao { get; set; }
    public Status Status { get; set; }
    public IPAddress? EnderecoIp { get; set; }
}

public enum Versao {
    EFCore1,
    EFCore2,
    EFCore3,
    EFCore5
}

public enum Status
{
    Analise,
    Enviado,
    Devolvido
}
