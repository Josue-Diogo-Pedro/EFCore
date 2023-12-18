using Cursov1.Domain;
using Cursov1.Funcoes;
using Cursov1.Interceptadores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Cursov1.Data;

public class ApplicationContext : DbContext
{
    #region Infrastructure, Procedures, Modelo de Dados, DataAnotations

    
    //private readonly StreamWriter _writer = new StreamWriter(Directory.GetCurrentDirectory() + "../../../../" + "/meu_log_do_ef_core.txt", append: true);
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    /*
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Conversor> Conversores { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Documento> Documentos { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Atributo> Atributos { get; set; }
    public DbSet<Aeroporto> Aeroportos { get; set; }

    //public DbSet<Instrutor> Instrutores { get; set; }
    //public DbSet<Aluno> Alunos { get; set; }

    public DbSet<Ator> Atores { get; set; }
    public DbSet<Filme> Filmes { get; set; }

    public DbSet<Dictionary<string, object>> Configuracoes => Set<Dictionary<string, object>>("Configuracoes");

    */

    public ApplicationContext() { }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    #endregion

    #region EF Functions
    
    public DbSet<Funcao>? Funcoes { get; set; }
    public DbSet<Livro>? Livros { get; set; }
    
    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        var connectionString = "Data Source=DESKTOP-DSNQA59\\SQLEXPRESS;Initial Catalog=DevIO-02;Integrated Security=True;pooling=false; Trust Server Certificate=true;";

        #region Infrastructure

        //builder
        //.UseSqlServer(connectionString, o => 
        //                                   o.MaxBatchSize(100).CommandTimeout(5)
        //                                      .EnableRetryOnFailure(4, TimeSpan.FromSeconds(10), null))
        //.LogTo(Console.WriteLine, LogLevel.Information)
        //.LogTo(Console.WriteLine, new[] {CoreEventId.ContextInitialized, RelationalEventId.CommandExecuted},
        //    LogLevel.Information,
        //    DbContextLoggerOptions.LocalTime | DbContextLoggerOptions.SingleLine
        //);
        //.LogTo(_writer.WriteLine, LogLevel.Information);
        //.EnableDetailedErrors();
        //.EnableSensitiveDataLogging();

        #endregion

        #region Modelo de Dados
        /*
        builder
            .UseSqlServer(connectionString)
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging();
        */
        #endregion

        #region EF Functions
        
        builder
            .UseSqlServer(connectionString)
            //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution)
            .LogTo(Console.WriteLine, LogLevel.Information)
            //.AddInterceptors(new InterceptadorDeComando())
            //.AddInterceptors(new InterceptadorDeConexao())
            //.AddInterceptors(new InterceptadorDePersistencia())
            .EnableSensitiveDataLogging();
        
        #endregion

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Modelo de Dados
        /*
        // - Filtro global
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AI");

        // - Filtro parcial
        modelBuilder.Entity<Departamento>().Property(p => p.Descricao).UseCollation("SQL_Latin1_General_CP1_CS_AS");
        */

        /*
        // - Sequencias
        modelBuilder
            .HasSequence<int>("MinhaSequencia", "sequencias")
            .StartsAt(100)
            .IncrementsBy(1);
        modelBuilder.Entity<Departamento>().Property(p => p.Id).HasDefaultValueSql("NEXT VALUE FOR sequencias.MinhaSequencia");
        */

        /*
        // - Indice
        modelBuilder
            .Entity<Departamento>()
            .HasIndex(p => new { p.Descricao, p.Ativo })
            .HasDatabaseName("idx_meu_indice_composto")
            .HasFilter("Descricao IS NOT NULL")
            .HasFillFactor(80)
            .IsUnique();
        */

        /*
        // - Propagação de Dados
        modelBuilder.Entity<Estado>().HasData(new[]
        {
            new Estado{Id = 1, Nome = "Sao Paulo"},
            new Estado{Id = 2, Nome = "Sergipe"}
        });
        */

        /*
        // - Esquemas
        modelBuilder.HasDefaultSchema("cadastro");
        modelBuilder.Entity<Estado>().ToTable("Estado", "SegundoEsquema");
        */

        /*
        // - Conversões

        var conversao1 = new EnumToStringConverter<Versao>();
        var conversao2 = new ValueConverter<Versao, string>(p => p.ToString(), p => (Versao)(Enum.Parse(typeof(Versao), p)));

        modelBuilder.Entity<Conversor>()
            .Property(p => p.Versao)
            //.HasConversion(conversao1)
            //.HasConversion(conversao2);
            .HasConversion(p => p.ToString(), p => (Versao)Enum.Parse(typeof(Versao), p));
            //.HasConversion<string>();
        */

        /*
        // - Conversor Customizado
        modelBuilder.Entity<Conversor>()
            .Property(p => p.Status)
            .HasConversion(new ConversorCustomizado());
        */

        /*
        // - Propriedade Sombra
        modelBuilder.Entity<Departamento>().Property<DateTime>("UltimaAtualizacao");
        */

        /*
        // - Owned Types
        modelBuilder.Entity<Cliente>(p =>
        {
            p.OwnsOne(x => x.Endereco, end =>
            {
                end.Property(p => p.Bairro).HasColumnName("Bairro");
                end.ToTable("Enderecos");
            });
        });
        */

        #endregion

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

        #region Modelo de Dados - Sacola de Propriedades
        /* Modelo de Dados
         *  - Configurando Sacola de Propriedades
         *  
        modelBuilder.SharedTypeEntity<Dictionary<string, object>>("Configuracoes", b =>
        {
            b.Property<int>("Id");

            b.Property<string>("Chave")
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            b.Property<string>("Valor")
                .HasColumnType("VARCHAR(255)")
                .IsRequired();
        });
        */
        #endregion

        modelBuilder.Entity<Funcao>(conf =>
        {
            conf
            .Property<string>("PropriedadeSombra")
            .HasColumnType("VARCHAR(100)")
            .HasDefaultValueSql("'Teste'");
        });

        #region Trabalhando com FUNÇÕES

        // - Registrando Builtin Function via FLUENT API
        modelBuilder.HasDbFunction(_funcaoLeft)
            .HasName("LEFT")
            .IsBuiltIn();

        modelBuilder.HasDbFunction(_letrasMaiusculas)
            .HasName("ConverterParaLetrasMaiusculas")
            .HasSchema("dbo");

        // Trabalhando com funções complexas
        modelBuilder.HasDbFunction(_dateDiff)
            .HasName("DATEDIFF")
            .HasTranslation(p =>
            {
                var argumentos = p.ToList();

                var constante = (SqlConstantExpression)argumentos[0];
                argumentos[0] = new SqlFragmentExpression(constante.Value.ToString());

                return new SqlFunctionExpression("DATEDIFF", argumentos, false, new[] { false, false, false }, typeof(int), null);
            })
            .IsBuiltIn();

        #endregion

    }

    #region Funções incorporadas em variáveis

    private MethodInfo? _funcaoLeft = typeof(MinhasFuncoes)
            .GetRuntimeMethod("Left", new[] { typeof(string), typeof(int) });

    private MethodInfo? _letrasMaiusculas = typeof(MinhasFuncoes)
        .GetRuntimeMethod(nameof(MinhasFuncoes.LetrasMaiusculas), new[] { typeof(string) });
    
    //DateDiff é uma função complexa
    private MethodInfo? _dateDiff = typeof(MinhasFuncoes)
        .GetRuntimeMethod(nameof(MinhasFuncoes.DateDiff), new[] { typeof(string), typeof(DateTime), typeof(DateTime) });

    #endregion

    public override void Dispose()
    {
        base.Dispose();
        //_writer.Dispose();
    }




    /*
     *  --- Módulo Consultas e Stored Procedures
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=DESKTOP-DSNQA59\\SQLEXPRESS;Initial Catalog=DevIO-02;Integrated Security=True;pooling=false; Trust Server Certificate=true;";
        optionsBuilder.
             //UseSqlServer(connectionString, p => p.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery) Este parametro é uma estratégia para não cansar as consultas)
             UseSqlServer(connectionString)
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // - Filtro global
        //modelBuilder.Entity<Departamento>().HasQueryFilter(p => !p.Excluido);
    }
    */
}


























/* Database & Tipos de Carregamentos
public class ApplicationContext : DbContext
{
    
    public DbSet<Departamento>? Departamentos { get; set; }
    public DbSet<Funcionario>? Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string strConnection = "Data Source=DESKTOP-DSNQA59\\SQLEXPRESS;Initial Catalog=C002;Integrated Security=True;pooling=false; Trust Server Certificate=true;MultipleActiveResultSets=true";
        optionsBuilder
            .UseSqlServer(strConnection)
            .EnableSensitiveDataLogging();
        //.LogTo(Console.WriteLine, LogLevel.Information);
    }
    
}
*/
