using Cursov1.Domain;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq.Expressions;

namespace Cursov1.Conversores;

public class ConversorCustomizado : ValueConverter<Status, string>
{
    public ConversorCustomizado() : base(
        p => ConverterParaOhBancoDeDados(p),
        value => ConverterParaAplicacao(value),
        new ConverterMappingHints(1)
        )
    {
    }

    public static string ConverterParaOhBancoDeDados(Status status)
    {
        return status.ToString()[0..1];
    }

    public static Status ConverterParaAplicacao(string value)
    {
        var status = Enum
            .GetValues<Status>()
            .FirstOrDefault(p => p.ToString() == value);

        return status;
    }
}
