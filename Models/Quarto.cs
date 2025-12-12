using System.ComponentModel.DataAnnotations;

namespace API_Gerencia_Reserva_Hotel.Models;

public class Quarto
{
    [Key]
    public long Id { get; set; }

    public int Numero { get; set; }

    public string Tipo { get; set; } = string.Empty;

    public float PrecoDiaria { get; set; } 

    public string Status { get; set; } = string.Empty;

    // Relacionamento 1 - n
    public List<Reserva> Reservas { get; set; } = new();

}