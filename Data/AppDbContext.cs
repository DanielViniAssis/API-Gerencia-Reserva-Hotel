using Microsoft.EntityFrameworkCore;
using API_Gerencia_Reserva_Hotel.Models;

namespace API_Gerencia_Reserva_Hotel.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // Entidades
    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Funcionario> Funcionarios { get; set; }

    public DbSet<Quarto> Quartos { get; set; }

    public DbSet<Reserva> Reservas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Especificando as configurações dos relacionamentos
        modelBuilder.Entity<Reserva>()
            .HasOne(r => r.Cliente)
            .WithMany(c => c.Reservas)
            .HasForeignKey(r => r.ClienteId);

        modelBuilder.Entity<Reserva>()
            .HasOne(r => r.Quarto)
            .WithMany(q => q.Reservas)
            .HasForeignKey(r => r.QuartoId);
        
        modelBuilder.Entity<Reserva>()
            .HasOne(r => r.Funcionario)
            .WithMany(f => f.Reservas)
            .HasForeignKey(r => r.FuncionarioId);
    }
}
