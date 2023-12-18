using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cursov1.Domain;

[Table("TabelaAtributos")]
[Index(nameof(Descricao), nameof(Id), IsUnique = true)]
[Comment("Meu comentário para a minha tabela")]
public class Atributo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("MinhaDescricao", TypeName = "VARCHAR(100)")]
    [Comment("Meu comentário para o meu campo")]
    public string? Descricao { get; set; }

    [MaxLength(255)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    //[Required]
    public string? Observacao { get; set; }
}

public class Aeroporto
{
    public int Id { get; set; }
    public string? Nome { get; set; }

    [InverseProperty("AeroportoPartida")]
    public ICollection<Voo>? VoosPartida { get; set; }

    [InverseProperty("AeroportoChegada")]
    public ICollection<Voo>? VoosChegada { get; set; }
}

public class Voo
{
    public int Id { get; set; }
    public string? Descricao { get; set; }

    public Aeroporto? AeroportoPartida { get; set; }
    public Aeroporto? AeroportoChegada { get; set; }
}
