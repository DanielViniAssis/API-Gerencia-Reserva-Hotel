using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;


public class ClienteCreateDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [StringLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres.")]
    public string Cpf { get; set; } = string.Empty;

    [Required(ErrorMessage = "O E-mail é obrigatório.")]
    [StringLength(320, ErrorMessage = "O CPF deve ter no máximo 320 caracteres.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O Telefone é obrigatório.")]
    [StringLength(14, ErrorMessage = "O Telefone deve ter no máximo 14 caracteres.")]
    public string Telefone { get; set; } = string.Empty;

    public List<ReservaCreateDTO>? Reservas { get; set; }
}