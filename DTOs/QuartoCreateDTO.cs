using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;

public class QuartoCreateDTO
{
    [Required(ErrorMessage = "O Numero é obrigatório.")]
    [StringLength(4, ErrorMessage = "O Numero deve ter no máximo 4 caracteres.")]
    public int Numero { get; set; }

    [Required(ErrorMessage = "O Tipo é obrigatório.")]
    [StringLength(10, ErrorMessage = "O Tipo deve ter no máximo 10 caracteres.")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "O PrecoDiaria é obrigatório.")]
    [StringLength(6, ErrorMessage = "O Preço da Diaria deve ter no máximo 6 caracteres.")]
    public float PrecoDiaria { get; set; }

    [Required(ErrorMessage = "O Status é obrigatório.")]
    [StringLength(7, ErrorMessage = "O Status deve ter no máximo 7 caracteres.")]
    public string Status { get; set; } = string.Empty;
    
    public List<ReservaCreateDTO>? Reservas { get; set; }
}