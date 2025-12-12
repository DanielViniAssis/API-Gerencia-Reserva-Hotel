using System.ComponentModel.DataAnnotations;
using API_Gerencia_Reserva_Hotel.DTOs;

namespace API_Gerencia_Reserva_Hotel.DTOs;

public class ClienteReadDTO
{
    public long Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Cpf { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Telefone { get; set; } = string.Empty;

    public List<ReservaReadDTO>? Reservas { get; set; }
}
