namespace HolaMundo.Lopez;

class Actividad
{
    public int Id {get; set;}

    public DateTime FechaDeRegistro {get; set;}
    public int DocenteId {get; set;}
    public string? EjeTematico {get; set;}
    public string? Subeje {get; set;}

    public string? Descripcion {get; set;}

    public string? Docente {get; set;}



    public Actividad(){
        this.Id = new random().next(1,100);
    }
    
}