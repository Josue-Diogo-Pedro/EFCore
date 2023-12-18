using Cursov1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualBasic;

namespace Cursov1;

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ApplicationContext>();
        var connectionString = "Data Source=DESKTOP-DSNQA59\\SQLEXPRESS;Initial Catalog=DevIO-02;Integrated Security=True;pooling=false; Trust Server Certificate=true;";

        builder.UseSqlServer(connectionString);

        return new ApplicationContext(builder.Options);
    }
}
   