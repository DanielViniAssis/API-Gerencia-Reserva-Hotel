using System.ComponentModel.DataAnnotations;

namespace API_Gerencia_Reserva_Hotel.Models;

public class Funcionario
{
    [Key]
    public long Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Cargo { get; set; } = string.Empty;

    // Relacionamento 1 - n
    public List<Reserva> Reservas { get; set; } = new();
}