using API_Gerencia_Reserva_Hotel.Data;
using API_Gerencia_Reserva_Hotel.DTOs;
using API_Gerencia_Reserva_Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Gerencia_Reserva_Hotel.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClientesController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public ClientesController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpPost]
    public async Task<IActionResult> AddCliente(ClienteCreateDTO clienteDto)
    {
        var cliente = new Cliente
        {
            Nome = clienteDto.Nome,
            Cpf = clienteDto.Cpf,
            Email = clienteDto.Email,
            Telefone = clienteDto.Telefone
        };

        _appDbContext.Clientes.Add(cliente);
        await _appDbContext.SaveChangesAsync();

        return Ok(cliente);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cliente>>> GetAllClientes()
    {
        var clientes = await _appDbContext.Clientes.ToListAsync();

        return Ok(clientes);
    }
}