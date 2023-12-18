using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Cursov1.Interceptadores;

public class InterceptadorDePersistencia : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        Console.WriteLine(eventData.Context?.ChangeTracker.DebugView.LongView);
        return result;
    }
}
