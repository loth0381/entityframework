using Microsoft.EntityFrameworkCore;
using projectef.Models;

namespace projectef;

public class TareasCotext: DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    public TareasCotext(DbContextOptions<TareasCotext> options) : base(options){ }
}