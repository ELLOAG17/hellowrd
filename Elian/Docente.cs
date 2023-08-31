namespace HolaMundo.Elian;

//PascalCase
class Docente
{
    public int id { get; set;}

    public int NumeroDeEmpleado { get; set;}

    public string? Nombres { get; set;}

    public string? Apellidos {get; set;}

    public docente(){
        this.id = new random().next(1,100);
        
    }
}
