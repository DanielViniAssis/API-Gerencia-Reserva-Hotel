using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;

public class FuncionarioCreateDTO
{
    [Required(ErrorMessage = "O Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O Cargo é obrigatório.")]
    [StringLength(100, ErrorMessage = "O Cargo deve ter no máximo 100 caracteres.")]
    public string Cargo { get; set; } = string.Empty;

    // Relacionamento 1 - n
    public List<ReservaCreateDTO>? Reservas { get; set; } 
}