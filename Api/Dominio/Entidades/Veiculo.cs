using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Dominio.Entidades;

public class Veiculo
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Nome { get; set; } = default!;

    [Required]
    [StringLength(100)]
    public string Marca { get; set; } = default!;

    [Required]
    public int Ano { get; set; }
}