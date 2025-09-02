using System.ComponentModel.DataAnnotations;

namespace MinimalApi.DTOs;

public record VeiculoDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(150, ErrorMessage = "O nome deve ter no máximo 150 caracteres.")]
    public string Nome { get;set; } = default!;

    [Required(ErrorMessage = "A marca é obrigatória.")]
    [StringLength(100, ErrorMessage = "A marca deve ter no máximo 100 caracteres.")]
    public string Marca { get;set; } = default!;

    [Required(ErrorMessage = "O ano é obrigatório.")]
    [Range(1950, int.MaxValue, ErrorMessage = "O ano deve ser superior a 1950.")]
    public int Ano { get;set; } = default!;
}