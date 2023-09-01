namespace HolaMundo.Elian;

//PascalCase
class Docente
{
    public int Id { get;}

    public int NumeroDeEmpleado { get; set;}

    public string? Nombres { get; set;}

    public string? Apellidos {get; set;}

    public Docente(){
        this.Id = new random().next(1,100);
        
    }
}
