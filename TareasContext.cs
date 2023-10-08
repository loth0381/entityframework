using Microsoft.EntityFrameworkCore;
using projectef.Models;

namespace projectef;

public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options) : base(options){ }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria() {CategoriaId = Guid.Parse("3f96cc4c-a2ae-4862-a47d-0dc15d150502"), Nombre ="Actividades pedientes", Peso=20});
        categoriasInit.Add(new Categoria() {CategoriaId = Guid.Parse("3f96cc4c-a2ae-4862-a47d-0dc15d150594"), Nombre ="Actividades personales", Peso=50});
        modelBuilder.Entity<Categoria>(categoria =>
        { //fluer api Entity
            categoria.ToTable("Categoria");
            categoria.HasKey(p=> p.CategoriaId);

            categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150);

            categoria.Property(p=> p.Descripcion).IsRequired(false);

            categoria.Property(p=> p.Peso);

            categoria.HasData(categoriasInit);
        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("3f96cc4c-a2ae-4862-a47d-0dc15d150510"),CategoriaId = Guid.Parse("3f96cc4c-a2ae-4862-a47d-0dc15d150502"), prioridadTarea = Prioridad.Media, Titulo = "Pago de servicios publico", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("3f96cc4c-a2ae-4862-a47d-0dc15d150511"),CategoriaId = Guid.Parse("3f96cc4c-a2ae-4862-a47d-0dc15d150594"), prioridadTarea = Prioridad.Baja, Titulo = "Terminar pelicula netflix", FechaCreacion = DateTime.Now });
        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(p=> p.TareaId);
            tarea.HasOne(p=> p.Categoria).WithMany().HasForeignKey(p=> p.CategoriaId);
            tarea.Property(p=> p.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(p => p.Descripcion).IsRequired(false);
            tarea.Property(p=> p.prioridadTarea);
            tarea.Property(p=> p.FechaCreacion);
            tarea.Ignore(p=> p.Resumen);
            tarea.HasData(tareasInit);
            

        });

    }

    
}