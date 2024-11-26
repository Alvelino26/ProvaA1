using Microsoft.EntityFrameworkCore;

namespace Projeto.Models;

public class AppDataContext : DbContext
{
    public DbSet<Tarefa>? Tarefas { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Gabriel.db");
    }

}