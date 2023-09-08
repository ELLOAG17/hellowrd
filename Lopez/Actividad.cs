using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HelloWrd.Elian;
namespace HelloWrd.Lopez;


[Table("Actividad")]

class Actividad
{
    public int Id { get; private set; }

    [Required]

    public DateTime FechaDeRegistro { get; set; }

    [Required]

    public int DocenteId { get; set; }

    [Required , MaxLength(100)]

    public string? EjeTematico { get; set; }

    [Required , MaxLength(100)]

    public string? Subeje { get; set; }

    [Required , MaxLength(300)]
    public string? Descripcion { get; set; }

    [NotMapped]
    
    public Docente? Docente { get; set;}

    public Actividad()
    {
        this.Id = new Random().Next(1, 100);
    }

}