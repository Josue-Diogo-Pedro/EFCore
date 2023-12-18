using Cursov1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cursov1.Configurations;

/*
 * **********************  Configurando com TPH  *****************************
public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
{ 
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder
            .ToTable("Pessoas")
            .HasDiscriminator<int>("TipoPessoa")
            .HasValue<Pessoa>(3)
            .HasValue<Instrutor>(6)
            .HasValue<Aluno>(99);
    }
}*/


// **********************  Configurando com TPT  *****************************

public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
{
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder.ToTable("Pessoas");
    }
}

public class InstrutorConfiguration : IEntityTypeConfiguration<Instrutor>
{
    public void Configure(EntityTypeBuilder<Instrutor> builder)
    {
        builder.ToTable("Instrutor");
    }
}


public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Alunos");
    }
}