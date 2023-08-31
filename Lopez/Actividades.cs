namespace HolaMundo.Lopez;

class Actividad
{
    public int id {get; set;}

    public DateTime fechaderegistro {get; set;}
    public int docenteid {get; set;}
    public string? ejetematico {get; set;}
    public string? subeje {get; set;}
    public string? descripcion {get; set;}

    public Actividad(){
        this.id = new random().next(1,100);
    }
    
}