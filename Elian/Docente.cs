using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HelloWrd.Lopez;
namespace HelloWrd.Elian;


//PasacalCase
[Table("Docentes")]
class Docente
{
    public int Id { get; private set;}

    [Required]
    public int NumDeEmpleado {get; set;}

    [Required, MaxLength(50)]
    public string? Nombres {get; set;}


    [Required, MaxLength(50)]
    public string? Apellidos {get; set;}

    [NotMapped]
    public List<Actividad> Actividades { get; set; }

    // public Docente()
    // {
    //     this.Id = new Random().Next(1,100);
    //     this.Actividades = new List<Actividad>();
    // }
}