using System.ComponentModel.DataAnnotations;

namespace MinimalApi.DTOs;

public class LoginDTO
{
    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "O formato do e-mail é inválido.")]
    [StringLength(255, ErrorMessage = "O e-mail deve ter no máximo 255 caracteres.")]
    public string Email { get; set; } = default!;

    [Required(ErrorMessage = "A senha é obrigatória.")]
    [StringLength(100, ErrorMessage = "A senha deve ter no máximo 100 caracteres.")]
    public string Senha { get; set; } = default!;
}