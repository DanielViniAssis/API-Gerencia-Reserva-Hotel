using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;

public class ReservaReadDTO
{
    public long Id { get; set; }

    public DateTime DataEntrada { get; set; }

    public DateTime DataSaida { get; set; }

    public float ValorTotal { get; set; }

    public string Status { get; set; } = string.Empty;

    public int QuartoId { get; set; }

    public int ClienteId { get; set; } 

    public int FuncionarioId { get; set; } 

    public ClienteReadDTO? Cliente { get; set; }
    public QuartoReadDTO? Quarto { get; set; }

}