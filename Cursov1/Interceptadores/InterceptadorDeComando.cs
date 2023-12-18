using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace Cursov1.Interceptadores;

public class InterceptadorDeComando : DbCommandInterceptor
{
    private static readonly Regex _tableRegex =
        new Regex(@"(?<tableAlias>FROM +(\[.*\]\.)?(\[.*\]\.)?(\[.*\]) AS (\[.*\])(?! WITH \(NOLOCK\)))",
            RegexOptions.Multiline |
            RegexOptions.IgnoreCase |
            RegexOptions.Compiled);

    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {

        UsarNoLock(command);

        return result;

        /* Aula - Sobrescrevendo métodos
        Console.WriteLine("[Sync] entrei dentro do método ReaderExecuting");
        return base.ReaderExecuting(command, eventData, result);
        */
    }

    public override ValueTask<DbDataReader> ReaderExecutedAsync(DbCommand command,
        CommandExecutedEventData eventData,
        DbDataReader result,
        CancellationToken cancellationToken = default)
    {
        UsarNoLock(command);

        return new ValueTask<DbDataReader>(result);

        /* Aula - Sobrescrevendo métodos
        Console.WriteLine("[Async] entrei dentro do método ReaderExecutingAsync");
        return base.ReaderExecutedAsync(command, eventData, result, cancellationToken);
        */
    }

    private void UsarNoLock(DbCommand command)
    {
        if (!command.CommandText.Contains("WITH (NOLOCK)") && command.CommandText.StartsWith("-- Use Nolock"))
        {
            command.CommandText = _tableRegex.Replace(command.CommandText, "${tableAlias} WITH (NOLOCK)");
        }
    }

}
