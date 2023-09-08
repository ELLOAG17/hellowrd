using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HelloWrd.Lopez;
namespace HelloWrd.Elian;


//PascalCase
[Table("Docente")]
class Docente
{
  public int Id { get; private set; }  

  [Required]

  public int NumeroDeEmpleado { get; set; }

  [Required, MaxLength(50)]

  public string? Nombres { get; set; }

  [Required, MaxLength(50)]

  public string? Apellidos { get; set; }

  [NotMapped]

  public List<Actividad> Actividad {get; set;}

  public Docente()
  {
    this.Id = new Random().Next(1, 100);
    this.Actividad = new List<Actividad>();

  }

}

internal class requiredAttribute : Attribute
{
}
