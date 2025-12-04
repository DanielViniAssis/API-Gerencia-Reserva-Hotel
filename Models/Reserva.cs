using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Gerencia_Reserva_Hotel.Models;

public class Reserva
{
    [Key]
    public long Id { get; set; }

    public DateTime DataEntrada { get; set; }

    public DateTime DataSaida { get; set; }

    public float ValorTotal { get; set; } 

    public string Status { get; set; } = string.Empty;

    // Relacionamentos 1 - 1
    public int QuartoId { get; set; }
    public Quarto? Quarto { get; set; }

    public int ClienteId { get; set; } 
    public Cliente? Cliente { get; set; }

    public int FuncionarioId { get; set; } 
    public Funcionario? Funcionario { get; set; }

}