using HelloWrd.Elian;
using HelloWrd.Lopez;
using Microsoft.EntityFrameworkCore;

namespace HelloWrd;


class SqliteDbContext : DbContext
{
    //definir la propiedades que se convertiran en tablas
    public DbSet<Docente> Docentes { get; set; }
    public DbSet<Actividad> Actividades { get; set; }
    //Definir el controlador y la conexion a la base de datos
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Db/BdControlAct.db");
        base.OnConfiguring(optionsBuilder);    
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividad>(act => 
            act.HasOne<Docente>(a => a.Docente)
                .WithMany(d => d.Actividades));

        modelBuilder.Entity<Docente>(doc =>
            doc.HasMany<Actividad>(d => d.Actividades)
                .WithOne(a => a.Docente));
        
        base.OnModelCreating(modelBuilder);
    }
}