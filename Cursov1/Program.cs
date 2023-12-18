using Cursov1.Data;
using Cursov1.Domain;
using Cursov1.Funcoes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Text.Json;

// ******************************* EXECUÇÕES ****************************************

#region Execução de métodos - Consultas

//FiltroGlobal();
//IgnoreFiltroGlobal();
//ConsultaProjetada();
//ConsultaParametrizada();
//ConsultacomTAG();
//DivisaoDeConsulta();
// --------------------------------------------------------------------

#endregion


#region Execução de métodos - Stored Procedures

//CriarStoredProcedure();
//InserirDadosViaProcedure();
//CriarProcedureConsultaDepartamento();
//ConsultaViaProcedure();
// --------------------------------------------------------------------

#endregion


#region Execução de métodos - Infrastruture

//ConsultarDepartamento();
//DadosSensiveis();
//TempoComandoGeral();
//TempoComandoFluxo();
//ExecutarEstrategiaResiliente();
// --------------------------------------------------------------------

#endregion


#region Execução de métodos - Modelo de Dados

//Collations();
//Insert();
//PropagarDados();
//Esquemas();
//Conversor();
//ConversorCustomizado();
//TrabalhandoComPropriedadeSombra();
//TiposDePropriedades();
//Relacionamento1Para1();
//Relacionamento1ParaMuitos();
//RelacionamentoMuitosParaMuitos();
//CampoDeApoio();
//ExemploTPH();
//PacotesDePropriedades();

#endregion


#region Execução de métodos - Data Anotations

//Atributos();

#endregion


#region Execução de métodos - EF Functions

//FuncoesData();
//FuncaoLike();
//DataLength();
//FuncaoProperty();
//FuncaoCollete();

#endregion


#region Execução de métodos - Interceptadores

//TesteInterceptacao();
//TesteInterceptadorDePersistencia();

#endregion


#region Execução de métodos - Transações

//ComportamentoPadrao();
//GenerenciandoTransacoesManualmente();
//ReverterTransacao();

#endregion


#region Execução de métodos - UDFs

//FuncaoLEFT();
//FuncaoDefinidaPeloUsuario();
//DateDiff();

#endregion


#region Execução de métodos - Desempenho

//Setup();
//ConsultaRastreada();

//ConsultaProjetadaERastreada();

//Inserir_200_Departamentos();
ConsultaProjetada();

#endregion

// =======================================================================================




// ******************************* IMPLEMENTAÇÕES ****************************************

#region Implementação de métodos - Consultas
/*
void Setup(ApplicationContext db)
{
    if (db.Database.EnsureCreated())
    {
        db.Departamentos.AddRange(

            new Departamento
            {
                Ativo = true,
                Descricao = "Departamento 01",
                Funcionarios = new List<Funcionario>
                {
                    new Funcionario
                    {
                        Nome = "Rafael Almeida",
                        CPF = "999992"
                    }
                },
                Excluido = true
            },
            new Departamento
            {
                Ativo = true,
                Descricao = "Departamento 02",
                Funcionarios = new List<Funcionario>
                {
                    new Funcionario
                    {
                        Nome = "Eduardo Pires",
                        CPF = "8888882"
                    },
                    new Funcionario
                    {
                        Nome = "Bruno Brito",
                        CPF = "7777772"
                    }
                }
            }

        );
    }

    db.SaveChanges();
    db.ChangeTracker.Clear();
}
void FiltroGlobal()
{
    using var db = new ApplicationContext();
    Setup(db);

    var departamentos = db.Departamentos.Where(p => p.Id > 0).ToList();
    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao} \t Excluido: {departamento.Excluido}");
    }

}
void IgnoreFiltroGlobal()
{
    using var db = new ApplicationContext();
    Setup(db);

    var departamentos = db.Departamentos.IgnoreQueryFilters().Where(p => p.Id > 0).ToList();
    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao} \t Excluido: {departamento.Excluido}");
    }

}
void ConsultaProjetada()
{
    using var db = new ApplicationContext();
    Setup(db);

    var departamentos = db.Departamentos
        .Where(p => p.Id > 0)
        .Select(p => new {p.Descricao, Funcionarios = p.Funcionarios.Select(f => f.Nome)})
        .ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao}");
        foreach (var funcionario in departamento.Funcionarios)
        {
            Console.WriteLine($"\tNome: {funcionario}");
        }
    }

}
void ConsultaParametrizada()
{
    using var db = new ApplicationContext();
    Setup(db);

    var id = new SqlParameter
    {
        Value = 0,
        SqlDbType = System.Data.SqlDbType.Int
    }; // var id = 0;

    var departamentos = db.Departamentos
        .FromSqlRaw("SELECT * FROM Departamentos WHERE Id > {0}", id)
        .Where(p => !p.Excluido)
        .ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao}");
    }

}
void ConsultaInterpolada()
{
    using var db = new ApplicationContext();
    Setup(db);

    var id = 1;
    var departamentos = db.Departamentos
        .FromSqlInterpolated($"SELECT * FROM Departamentos WHERE Id > {id}")
        .ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao}");
    }

}
void ConsultacomTAG()
{
    using var db = new ApplicationContext();
    Setup(db);

    var departamentos = db.Departamentos
        .TagWith(@"Comentario 1
                   Comentario 2
                   Comentario 3")
        .ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao}");
    }

}
void DivisaoDeConsulta()
{
    using var db = new ApplicationContext();
    Setup(db);

    var departamentos = db.Departamentos
        .Include(p => p.Funcionarios)
        .Where(p => p.Id < 3)
        //.AsSplitQuery()
        .AsSingleQuery()
        .ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao}");
        foreach (var funcionario in departamento.Funcionarios)
        {
            Console.WriteLine($"\tFuncionario: {funcionario.Nome}");
        }
    }

}
// --------------------------------------------------------------------
*/
#endregion


#region Implementação de métodos - Stored Procedures
/*
void CriarStoredProcedure()
{
    var criarDepartamento = @"
        CREATE OR ALTER PROCEDURE CriarDepartamento
            @Descricao VARCHAR(50),
            @Ativo bit
        AS
        BEGIN
            INSERT INTO 
                Departamentos(Descricao, Ativo, Excluido)
            VALUES (@Descricao, @Ativo, 0)
        END
    ";

    using var db = new ApplicationContext();

    db.Database.ExecuteSqlRaw(criarDepartamento);
}
void InserirDadosViaProcedure()
{
    using var db = new ApplicationContext();

    db.Database.ExecuteSqlRaw("exec CriarDepartamento @p0, @p1", "Departamento via Procedure", true);
}
void CriarProcedureConsultaDepartamento()
{
    var getDepartamento = @"
        CREATE OR ALTER PROCEDURE GetDepartamentos
            @Descricao VARCHAR(50)
        AS
        BEGIN
            SELECT * FROM Departamentos WHERE Descricao Like @Descricao + '%'
        END
    ";

    using var db = new ApplicationContext();
    db.Database.ExecuteSqlRaw(getDepartamento);
}
void ConsultaViaProcedure()
{
    using var db = new ApplicationContext();

    var dep = "Departamento";
    var par = new SqlParameter("@par", "Departamento");
    var departamentos = db.Departamentos
        .FromSqlRaw("EXEC GetDepartamentos @par", par)
        .ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento.Descricao}");
    }
}
// --------------------------------------------------------------------
*/
#endregion


#region Implementação de métodos - Infrastructure
/*
void ConsultarDepartamento() 
{
    using var db = new ApplicationContext();

    var departamentos = db.Departamentos.Where(p => p.Id > 0).ToArray();
}
void DadosSensiveis()
{
    using var db = new ApplicationContext();
    var descricao = "Departamento";

    var departamentos = db.Departamentos.Where(p => p.Descricao == descricao).ToArray();
}
void TempoComandoGeral()
{
    using var db = new ApplicationContext();

    db.Database.ExecuteSqlRaw("WAITFOR DELAY '00:00:04'; SELECT 1");
}
void TempoComandoFluxo()
{
    using var db = new ApplicationContext();
    db.Database.SetCommandTimeout(10);

    db.Database.ExecuteSqlRaw("WAITFOR DELAY '00:00:07'; SELECT 1");
}
void ExecutarEstrategiaResiliente()
{
    using var db = new ApplicationContext();
    var strategy = db.Database.CreateExecutionStrategy();

    strategy.Execute(() =>
    {
        using var transaction = db.Database.BeginTransaction();
        db.Departamentos.Add(new Departamento { Descricao = "Departamento Transacao" });

        db.SaveChanges();
        transaction.Commit();
    });
}
// --------------------------------------------------------------------
*/
#endregion


#region Implementação de métodos - Modelo de Dados
/*
void Collations()
{
    using var db = new ApplicationContext();

    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}
void Insert()
{
    using var db = new ApplicationContext();
    var depa = new Departamento { Descricao = "Josue", Ativo = true, Excluido = false };

    db.Departamentos.Add(depa);

    db.SaveChanges();
}
void PropagarDados()
{
    using var db = new ApplicationContext();

    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    var script = db.Database.GenerateCreateScript();
    Console.WriteLine(script);
}
void Esquemas()
{
    using var db = new ApplicationContext();
    var script = db.Database.GenerateCreateScript();

    Console.WriteLine(script);
}
void Conversor() => Esquemas();
void ConversorCustomizado()
{
    using var db = new ApplicationContext();

    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    db.Conversores.Add(
        new Conversor
        {
            Status = Status.Devolvido
        }
    );

    db.SaveChanges();

    var conversorEmAnalise = db.Conversores.AsNoTracking().FirstOrDefault(p => p.Status == Status.Analise);
    var conversorDevolvido = db.Conversores.AsNoTracking().FirstOrDefault(p => p.Status == Status.Devolvido);
}
void TrabalhandoComPropriedadeSombra()
{
    using var db = new ApplicationContext();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    var departamento = new Departamento { Descricao = "Departamento Propriedade Sombra" };
    db.Departamentos.Add(departamento);

    db.Entry(departamento).Property("UltimaAtualizacao").CurrentValue = DateTime.Now;

    db.SaveChanges();

    var departamentos = db.Departamentos.Where(p => EF.Property<DateTime>(p, "UltimaAtualizacao") < DateTime.Now);
}
void TiposDePropriedades()
{
    using var db = new ApplicationContext();

    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    var cliente = new Cliente
    {
        Nome = "Fulano de tal",
        Telefone = "(79) 98888-9999",
        Endereco = new Endereco { Bairro = "Centro", Cidade = "Sao Paulo" }
    };

    db.Clientes.Add(cliente);
    db.SaveChanges();

    var clientes = db.Clientes.AsNoTracking().ToList();

    var options = new JsonSerializerOptions { WriteIndented = true };

    clientes.ForEach(cli =>
    {
        var json = JsonSerializer.Serialize(cli, options);
        Console.WriteLine(json);
    });
}
void Relacionamento1Para1()
{
    using var db = new ApplicationContext();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    var estado = new Estado
    {
        Nome = "Sergipe",
        Governador = new Governador { Nome = "Josué" }
    };

    db.Estados.Add(estado);
    db.SaveChanges();

    var estados = db.Estados.AsNoTracking().ToList();

    estados.ForEach(estado =>
    {
        Console.WriteLine($"Estado: {estado.Nome}, Governador: {estado.Governador}");
    });
}
void Relacionamento1ParaMuitos()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var estado = new Estado
        {
            Nome = "Sergipe",
            Governador = new Governador { Nome = "Rafael Almeida" }
        };

        estado.Cidades.Add(new Cidade { Nome = "Itabaiana" });

        db.Estados.Add(estado);
        db.SaveChanges();
    }

    using (var db = new ApplicationContext())
    {
        var estados = db.Estados.ToList();

        estados[0].Cidades.Add(new Cidade { Nome = "Aracaju" });

        db.SaveChanges();

        foreach (var est in db.Estados.Include(p => p.Cidades).Include(p => p.Governador).AsNoTracking())
        {
            Console.WriteLine($"Estado: {est.Nome}, Governador: {est.Governador.Nome}");

            foreach (var cidade in est.Cidades)
            {
                Console.WriteLine($"\t Cidade: {cidade.Nome}");
            }
        }
    }
}
void RelacionamentoMuitosParaMuitos()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var ator1 = new Ator { Nome = "Rafael" };
        var ator2 = new Ator { Nome = "Pires" };
        var ator3 = new Ator { Nome = "Bruno" };

        var filme1 = new Filme { Descricao = "A volta dos que não foram" };
        var filme2 = new Filme { Descricao = "De volta para o futuro" };
        var filme3 = new Filme { Descricao = "Poeira em alto mar filme" };

        ator1.Filmes.Add(filme1);
        ator1.Filmes.Add(filme2);

        ator2.Filmes.Add(filme2);

        filme3.Atores.Add(ator1);
        filme3.Atores.Add(ator2);
        filme3.Atores.Add(ator3);

        db.AddRange(ator1, ator2, filme3);

        db.SaveChanges();

        foreach(var ator in db.Atores.Include(e => e.Filmes))
        {
            Console.WriteLine($"Ator: {ator.Nome}");

            foreach (var filme in ator.Filmes)
            {
                Console.WriteLine($"\tFilme: {filme.Descricao}");
            }
        }
    }
}
void CampoDeApoio()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var documento = new Documento();
        documento.SetCPF("12345678901");

        db.Documentos.Add(documento);
        db.SaveChanges();

        foreach (var doc in db.Documentos.AsNoTracking())
        {
            Console.WriteLine($"CPF -> {doc.GetCPF()}");
        }
    }

        
}
void ExemploTPH()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var pessoa = new Pessoa { Nome = "Fulano de tal" };
        var instrutor = new Instrutor { Nome = "Rafael Almeida", Tecnologia = ".NET", Desde = DateTime.Now };
        var aluno = new Aluno { Nome = "Maria Thysbe", Idade = 31, DataContrato = DateTime.Now.AddDays(-1) };

        db.AddRange(pessoa, instrutor, aluno);
        db.SaveChanges();

        var pessoas = db.Pessoas.AsNoTracking().ToList();
        var instrutores = db.Pessoas.OfType<Instrutor>().AsNoTracking().ToList();
        var alunos = db.Pessoas.OfType<Aluno>().AsNoTracking().ToList();

        Console.WriteLine("Pessoas ****************"); 
        pessoas.ForEach(p =>
        {
            Console.WriteLine($"Id: {p.Id} -> Nome: {p.Nome}");
        });

        Console.WriteLine("Instrutores ****************");
        instrutores.ForEach(i =>
        {
            Console.WriteLine($"Id: {i.Id} -> Nome: {i.Nome}, Tecnologia: {i.Tecnologia}, Desde: {i.Desde}");
        });

        Console.WriteLine("Alunos ****************");
        alunos.ForEach(a =>
        {
            Console.WriteLine($"Id: {a.Id} -> Nome: {a.Nome}, Idade: {a.Idade}, Data Contrato: {a.DataContrato}");
        });

    }
}
void PacotesDePropriedades()
{
    using(var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var configuracao = new Dictionary<string, object>
        {
            ["Chave"] = "SenhaBancoDeDados",
            ["Valor"] = Guid.NewGuid().ToString()
        };

        db.Configuracoes.Add(configuracao);
        db.SaveChanges();

        var configuracoes = db
            .Configuracoes
            .AsNoTracking()
            .Where(p => p["Chave"] == "SenhaBancoDeDados")
            .ToList();

        configuracoes.ForEach(p =>
        {
            Console.WriteLine($"Chave: {p["Chave"]} - Valor: {p["Valor"]}");
        });
    }
}
*/
#endregion


#region Implementação de métodos - Data Anotations
/*
void Atributos()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var script = db.Database.GenerateCreateScript();

        Console.WriteLine(script);

        db.Atributos.Add(
            new Atributo
            {
                Descricao = "Exemplo",
                Observacao = "Observacao"
            }
        );

        db.SaveChanges();
    }
}
*/
#endregion


#region Implementações de métodos - EF Functions

void ApagarCriarBancoDeDados()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        db.Funcoes.AddRange(
            new Funcao
            {
                Descricao1 = "Bala 1",
                Descricao2 = "Bala 1",

                Data1 = DateTime.Now.AddDays(2),
                Data2 = "2021-01-01"
            },
            new Funcao
            {
                Descricao1 = "Bala 2",
                Descricao2 = "Bala 2",

                Data1 = DateTime.Now.AddDays(1),
                Data2 = "XX21-01-01"
            },
            new Funcao
            {
                Descricao1 = "Teste",
                Descricao2 = "Teste",

                Data1 = DateTime.Now.AddDays(1),
                Data2 = "XX21-01-01"
            }
        );

        db.SaveChanges();
    }
}
void FuncoesData()
{
    ApagarCriarBancoDeDados();

    using (var db = new ApplicationContext())
    {
        var script = db.Database.GenerateCreateScript();

        Console.WriteLine(script);

        var dados = db.Funcoes.AsNoTracking().Select(p => new
        {
            Dias = EF.Functions.DateDiffDay(DateTime.Now, p.Data1),
            Data = EF.Functions.DateFromParts(2021, 01, 01),
            DataValida = EF.Functions.IsDate(p.Data2)
        }).ToList();

        dados.ForEach(p =>
        {
            Console.WriteLine(p);
        });
    }
}
void FuncaoLike()
{
    using (var db = new ApplicationContext())
    {

        var script = db.Database.GenerateCreateScript();

        Console.WriteLine(script);

        var dados = db
            .Funcoes
            .AsNoTracking()
            .Where(p => EF.Functions.Like(p.Descricao1, "B[ao]%"))
            .Select(x => x.Descricao1)
            .ToList();

        Console.WriteLine("Resultado");
        dados.ForEach(p =>
        {
            Console.WriteLine(p);
        });
    }
}
void DataLength()
{
    using (var db = new ApplicationContext())
    {
        var resultado = db
            .Funcoes
            .AsNoTracking()
            .Select(p => new
            {
                TotalBytesCampoData = EF.Functions.DataLength(p.Data1),
                TotalBytes1 = EF.Functions.DataLength(p.Data1),
                TotalBytes2 = EF.Functions.DataLength(p.Data2),
                Total1 = p.Descricao1.Length,
                Total2 = p.Descricao2.Length
            }).FirstOrDefault();

        Console.WriteLine("Resultado");
        Console.WriteLine(resultado);
    }
}
void FuncaoProperty()
{
    ApagarCriarBancoDeDados();

    using (var db = new ApplicationContext())
    {
        var resultado = db.Funcoes
            //.AsNoTracking() //Habilitando o AsNotracking() ele não consegue trazer do banco a entidade sombra
            .FirstOrDefault(p => EF.Property<string>(p, "PropriedadeSombra") == "Teste");

        var propriedadeSombra = db?
                .Entry(resultado)
                .Property<string>("PropriedadeSombra")
                .CurrentValue;

        Console.WriteLine("Resultado:");
        Console.WriteLine(propriedadeSombra);
    }
}
void FuncaoCollete()
{
    using (var db = new ApplicationContext())
    {
        var consulta1 = db.Funcoes
            .FirstOrDefault(p => EF.Functions.Collate(p.Descricao1, "SQL_Latin1_General_CP1_CS_AS") == "bala");

        var consulta2 = db.Funcoes
            .FirstOrDefault(p => EF.Functions.Collate(p.Descricao1, "SQL_Latin1_General_CP1_CI_AI") == "bala");

        Console.WriteLine($"Consulta1 : {consulta1?.Descricao1}");

        Console.WriteLine($"Consulta2 : {consulta2?.Descricao1}");
    }
}

#endregion


#region Implementações de métodos - Interceptadores

void TesteInterceptacao()
{
    using (var db = new ApplicationContext())
    {
        var resultado =
            db.Funcoes
            .TagWith("Use Nolock")
            .FirstOrDefault();

        Console.WriteLine($"Consulta: {resultado?.Descricao1}");
    }
}
void TesteInterceptadorDePersistencia()
{
    using (var db = new ApplicationContext())
    {
        db.Funcoes.Add(new Funcao
        {
            Descricao1 = "Salvando e testando o interceptador de persistencia"
        });

        db.SaveChanges();
    }
}

#endregion


#region Implementações de métodos - Transações

void CadastrarLivro()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        db.Livros.Add(new Livro
        {
            Titulo = "Introdução ao EntityFramework Core",
            Autor = "Rafael",
            CadastradoEm = DateTime.Now.AddDays(-1)
        });

        db.SaveChanges();
    }
}
void ComportamentoPadrao()
{
    CadastrarLivro();

    using (var db = new ApplicationContext())
    {
        var livro = db.Livros.FirstOrDefault(p => p.Id == 1);
        livro.Autor = "Rafael Almeida";

        db.Livros.Add(new Livro
        {
            Autor = "Rafael Almeida",
            Titulo = "Dominando o EntityFramework Core"
        });

        db.SaveChanges();
    }
}
void GenerenciandoTransacoesManualmente()
{
    CadastrarLivro();

    using (var db = new ApplicationContext())
    {
        var transacao = db.Database.BeginTransaction();

        var livro = db.Livros.FirstOrDefault(p => p.Id == 1);
        livro.Autor = "Rafael Almeida";
        db.SaveChanges();

        Console.ReadKey();

        db.Livros.Add(new Livro
        {
            Autor = "Rafael Almeida",
            Titulo = "Dominando o EntityFramework Core"
        });

        db.SaveChanges();

        transacao.Commit();
    }
}
void ReverterTransacao()
{
    CadastrarLivro();

    using (var db = new ApplicationContext())
    {
        var transacao = db.Database.BeginTransaction();

        try
        {
            Console.WriteLine("Josue".PadRight(20, '*'));
            var livro = db.Livros.FirstOrDefault(p => p.Id == 1);
            livro.Autor = "Rafael Almeida";
            db.SaveChanges();

            db.Livros.Add(new Livro
            {
                Autor = "Rafael Almeida".PadLeft(16, '*'),
                Titulo = "Dominando o EntityFramework Core"
            });

            db.SaveChanges();

            transacao.Commit();
        }
        catch (Exception)
        {
            transacao.Rollback();
        }
    }
}


#endregion


#region Implementações de métodos - UDFs

void FuncaoLEFT()
{
    using (var db = new ApplicationContext())
    {
        CadastrarLivro();

        var result = db.Livros.Select(p => MinhasFuncoes.Left(p.Titulo, 10)).ToList();
        result.ForEach(p =>
        {
            Console.WriteLine(p);
        });
    }
}

void FuncaoDefinidaPeloUsuario()
{
    CadastrarLivro();

    using (var db = new ApplicationContext())
    {
        db.Database.ExecuteSqlRaw(@"
            CREATE FUNCTION ConverterParaLetrasMaiusculas(@dados VARCHAR(100))
            RETURNS VARCHAR(100)
            BEGIN
                RETURN UPPER(@dados)
            END
        ");

        var result = db.Livros.Select(p => MinhasFuncoes.LetrasMaiusculas(p.Titulo)).ToList();
        result.ForEach(p =>
        {
            Console.WriteLine(p);
        });
    }
}

void DateDiff()
{
    CadastrarLivro();

    using (var db = new ApplicationContext())
    {
        /*
        var result = db.Livros
            .Select(p => EF.Functions.DateDiffDay(p.CadastradoEm, DateTime.Now)).ToList();
        */

        var result = db.Livros
            .Select(p => MinhasFuncoes.DateDiff("DAY", p.CadastradoEm, DateTime.Now)).ToList();

        result.ForEach(p =>
        {
            Console.WriteLine(p);
        });
    }
}

#endregion


#region Implementações - Desempenho

void ConsultaRastreada()
{
    using var db = new ApplicationContext();

    var funcionarios = db.Funcionarios.AsNoTrackingWithIdentityResolution().Include(p => p.Departamento).ToList();
}

void ConsultaCustomizada()
{
    using var db = new ApplicationContext();
    db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;

    var funcionarios = db.Funcionarios.Include(p => p.Departamento).ToList();
}

void ConsultaProjetadaERastreada()
{
    using var db = new ApplicationContext();
    //db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;

    var departamentos = db.Departamentos
        .Include(p => p.Funcionarios)
        .Select(p => new
        {
            Departamento = p,
            TotalFuncionarios = p.Funcionarios.Count()
        })
        .ToList();

    departamentos[0].Departamento.Descricao = "Departamento Teste Atualizado";

    db.SaveChanges();

}

void Setup()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        db.Departamentos.Add(new Departamento
        {
            Descricao = "Departamento Teste",
            Ativo = true,
            Funcionarios = Enumerable.Range(1, 100).Select(p => new Funcionario
            {
                CPF = p.ToString().PadLeft(11, '0'),
                Nome = $"Funcionario {p}"
            }).ToList()
        });

        db.SaveChanges();
    }
}

void ConsultaProjetada()
{
    using (var db = new ApplicationContext())
    {
        var departamentos = db.Departamentos.AsNoTrackingWithIdentityResolution().ToList();

        var memoria = (System.Diagnostics.Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024) + "MB";

        Console.WriteLine(memoria);
    }
}

void Inserir_200_Departamentos()
{
    using (var db = new ApplicationContext())
    {
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        var random = new Random();

        db.Departamentos.AddRange(Enumerable.Range(1, 200).Select(p =>
        new Departamento
            {
                Descricao = "Departamento Teste",
                Image = getBytes()
            }));

        db.SaveChanges();

        byte[] getBytes()
        {
            var buffer = new byte[1024 + 1024];
            random.NextBytes(buffer);

            return buffer;
        }
    }
}

#endregion

// =======================================================================================







/* DataBase & Tipos de Carregamentos

using Cursov1.Data;
using Cursov1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

//Console.WriteLine("Hello, World!");


// - Using methods and main of Application
int _count;

//EnsureCreatedAndDeleted();
//GapDoEnsureCreated();
//HealthCheckDoBancoDeDados();
//new ApplicationContext().Departamentos?.AsNoTracking().Any();
//_count = 0;
//GerenciarEstadoDaConexao(false);
//_count = 0;
//GerenciarEstadoDaConexao(true);

//MigracoesPendentes();
//ScriptGeralDoBancoDeDados();

//CarregamentoAdiantado();
//CarregamentoExplicito();
CarregamentoLazyLoad();


// Creating Methods

static void MigracoesPendentes()
{
    using var db = new ApplicationContext();
    var migracoesPendentes = db.Database.GetPendingMigrations();

    Console.WriteLine($"Total: {migracoesPendentes.Count()}");
    foreach (var migracao in migracoesPendentes)
    {
        Console.WriteLine($"Migracao: {migracao}");
    }
}

static void ScriptGeralDoBancoDeDados()
{
    using var db = new ApplicationContext();
    var sctipt = db.Database.GenerateCreateScript();

    Console.WriteLine(sctipt);
}

static void ExecuteSql()
{
    using var db = new ApplicationContext();

    //segunda forma
    var descricao = "TESTE";
    db.Database.ExecuteSqlRaw("update Departamentos set Descricao={0} WHERE Id=1", descricao);

    //terceira forma
    db.Database.ExecuteSqlInterpolated($"UPDATE Departamentos SET Descricao={descricao} WHERE Id=1");
}

static void EnsureCreatedAndDeleted()
{
    var db = new ApplicationContext();
    //db.Database.EnsureCreated();
    db.Database.EnsureDeleted();
}

static void GapDoEnsureCreated()
{
    var db1 = new ApplicationContext();
    var db2 = new ApplicationContextCidade();

    db1.Database.EnsureCreated();
    db2.Database.EnsureCreated();

    var databaseCreator = db2.GetService<IRelationalDatabaseCreator>();
    databaseCreator.CreateTables();
}

static void HealthCheckDoBancoDeDados()
{
    using var db = new ApplicationContext();
    var canConnect = db.Database.CanConnect();

    if (canConnect)
    {
        Console.WriteLine("Posso me conectar");
    }
    else
    {
        Console.WriteLine("Não posso me conectar");
    }
}

void GerenciarEstadoDaConexao(bool gerenciarEstadoConexao)
{
    using var db = new ApplicationContext();
    var time = System.Diagnostics.Stopwatch.StartNew();

    var conexao = db.Database.GetDbConnection();

    conexao.StateChange += (_, __) => ++_count;

    if (gerenciarEstadoConexao)
        conexao.Open();

    for (var i = 0; i < 200; i++)
    {
        db.Departamentos?.AsNoTracking().Any();
    }

    time.Stop();
    var mensagem = $"Tempo: {time.Elapsed.ToString()}, {gerenciarEstadoConexao}, Contador: {_count}";

    Console.WriteLine(mensagem);
}

// - Tipos de carregamentos
void CarregamentoAdiantado()
{
    using var db = new ApplicationContext();
    SetupTiposCarregamentos(db);

    //Carregamento adiantado!!
    var departamentos = db.Departamentos.Include(p => p.Funcionarios);

    foreach (var departamento in departamentos)
    {
        Console.WriteLine("\n------------------------------");
        Console.WriteLine($"Departamento: {departamento.Descricao}");

        if (departamento.Funcionarios?.Any() ?? false)
        {
            foreach (var funcionario in departamento.Funcionarios)
            {
                Console.WriteLine($"\tFuncionario: {funcionario.Nome}");
            }
        }
        else Console.WriteLine("\tNenhum funcionario encontrado!");
    }
}
void CarregamentoExplicito()
{
    using var db = new ApplicationContext();
    SetupTiposCarregamentos(db);

    var departamentos = db.Departamentos?.ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine("\n------------------------------");
        Console.WriteLine($"Departamento: {departamento.Descricao}");

        if(departamento.Id == 6)
        {
            db.Entry(departamento).Collection(p => p.Funcionarios).Load(); // ou subistituir o lambda por "Funcionarios" - nome da tabela do banco de dados!
        }

        if (departamento.Funcionarios?.Any() ?? false)
        {
            foreach (var funcionario in departamento.Funcionarios)
            {
                Console.WriteLine($"\tFuncionario: {funcionario.Nome}");
            }
        }
        else Console.WriteLine("\tNenhum funcionario encontrado!");
    }
}
void CarregamentoLazyLoad()
{
    using var db = new ApplicationContext();
    SetupTiposCarregamentos(db);

    var departamentos = db.Departamentos?.ToList();

    foreach (var departamento in departamentos)
    {
        Console.WriteLine("\n------------------------------");
        Console.WriteLine($"Departamento: {departamento.Descricao}");

        if (departamento.Funcionarios?.Any() ?? false)
        {
            foreach (var funcionario in departamento.Funcionarios)
            {
                Console.WriteLine($"\tFuncionario: {funcionario.Nome}");
            }
        }
        else Console.WriteLine("\tNenhum funcionario encontrado!");
    }
}

void SetupTiposCarregamentos(ApplicationContext db)
{
    if (!db.Departamentos.Any())
    {
        db.Departamentos.AddRange(
            new Departamento
            {
                Descricao = "Departamento 01",
                Funcionarios = new List<Funcionario>
                {
                    new Funcionario{
                        Nome = "Rafael Almeida",
                        CPF = "999999999991"
                        //RG = "222221"
                    }
                }
            },
            new Departamento
            {
                Descricao = "Departamento 02",
                Funcionarios = new List<Funcionario>
                {
                    new Funcionario
                    {
                        Nome = "Eduardo Pires",
                        CPF = "777777771"
                        //RG = "1000002"
                    }
                }
            }
        );

        db.SaveChanges();
        db.ChangeTracker.Clear();
    }
}
*/