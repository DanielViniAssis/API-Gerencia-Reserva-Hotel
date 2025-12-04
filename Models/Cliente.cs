using System.ComponentModel.DataAnnotations;

namespace API_Gerencia_Reserva_Hotel.Models;

public class Cliente
{
    [Key]
    public long Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Cpf { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;

    public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

    // Relacionamento 1 - n
    public List<Reserva> Reservas { get; set; } = new();
    
}