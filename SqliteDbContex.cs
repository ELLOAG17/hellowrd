using HelloWrd.Elian;
using HelloWrd.Lopez;
using Microsoft.EntityFrameworkCore;

namespace HelloWrd;

class SqliteDbContext : DbContext
{
    //Definir las propiedades que se conviertan en tablas 
    public DbSet<Docente> Docente { get; set; }

    public DbSet<Actividad> Actividad { get; set; }

    //Definir el controlador y la conexion a la base de datos 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Db/Bd");
        base.OnConfiguring(optionsBuilder);
    }

    
    
    
    
}