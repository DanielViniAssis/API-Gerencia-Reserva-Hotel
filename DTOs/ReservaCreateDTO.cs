using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;


public class ReservaCreateDTO
{
    [Required(ErrorMessage = "A Data de Entrada é obrigatória.")]
    public DateTime DataEntrada { get; set; }

    [Required(ErrorMessage = "A Data de Saida é obrigatória.")]
    public DateTime DataSaida { get; set; }

    [Required(ErrorMessage = "O Valor Total é obrigatório.")]
    public float ValorTotal { get; set; }

    [Required(ErrorMessage = "O Status é obrigatório.")]
    [StringLength(7, ErrorMessage = "O Status deve ter no máximo 7 caracteres.")]
    public string Status { get; set; } = string.Empty;

    public int QuartoId { get; set; }

    public int ClienteId { get; set; } 

    public int FuncionarioId { get; set; } 

    public ClienteCreateDTO? Cliente { get; set; }
    public QuartoCreateDTO? Quarto { get; set; }
    public FuncionarioCreateDTO? Funcionario { get; set; }
}