using Cursov1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cursov1.Configurations;

public class AtorFilmeConfiguration : IEntityTypeConfiguration<Ator>
{
    public void Configure(EntityTypeBuilder<Ator> builder)
    {
        builder
            .HasMany(p => p.Filmes)
            .WithMany(p => p.Atores)
            .UsingEntity<Dictionary<string, object>>(
                "FilmesAtores",
                p => p.HasOne<Filme>().WithMany().HasForeignKey("FilmeId"),
                p => p.HasOne<Ator>().WithMany().HasForeignKey("AtorId"),
                p => p.Property<DateTime>("DataCadastro").HasDefaultValueSql("GETDATE()")
            );
    }
}
