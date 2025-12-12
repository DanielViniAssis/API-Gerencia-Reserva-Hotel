using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;

public class QuartoReadDTO
{
    public long id {get; set;}

    public int Numero { get; set; }

    public string Tipo { get; set; } = string.Empty;

    public float PrecoDiaria { get; set; }

    public string Status { get; set; } = string.Empty;
}