using HelloWrd;
using HelloWrd.Lopez;
using HelloWrd.Elian;
//codigoanterior();
//CrearBaseDeDatos();
static void EliminarBaseDeDatos()
{
    using  (var db = new )
}



static void CrearBaseDeDatos()
{
    //Resources tienen metodos para abrir y cerrar acciones
    using ( var Db = new SqliteDbContext()) 
    {
       db.Database.EnsureCreated();
    }
}


static void codigoanterior()
{
Console.WriteLine("Hello, World!");

//Crear docentes y actividades
var docente1 = new Docente();
docente1.Nombres = "Jose Luis";
docente1.Apellidos = "Gaxiola Castro";
docente1.NumeroDeEmpleado = 1234;

var actividad1 = new Actividad
{
    FechaDeRegistro = DateTime.Now,
    DocenteId = docente1.Id,
    Ejetematico = "Eje1",
    Subeje = "Subeje2",
    Descripcion = "No dormirse en clase"
};

var actividad2 = new Actividad
{
    FechaDeRegistro = DateTime.Today,
    DocenteId = docente1.Id,
    Ejetematico = "Eje2",
    Subeje = "subeje3",
    Descripcion = "Trabajar en viernes"
};

// TODO: Imprimir la descripcion de las actividades creadas y 
// que muestre el nombre del docente

Console.WriteLine($"Actividad: {actividad1.Descripcion}, Docente: {actividad1.DocenteId}");
Console.WriteLine($"Actividad: {actividad2.Descripcion}, Docente: {actividad2.DocenteId}");

// SELECT * FROM Actividades WHERE Docenteid=1;
//Retornar 2 registros vinculados al profesor 1 
docente1.Actividad.Add(actividad1);
docente1.Actividad.Add(actividad2);
//SELECT * FROM Docentes WHERE id=[actividad1.Docenteid];
actividad1.Docente = docente1;
actividad2.Docente = docente1;

// TODO: Imprimir la descripcion de las actividades creadas
//y que muestren el nombre del docente
Console.WriteLine($"Docente: {docente1.Nombres} {docente1.Apellidos}");
Console.WriteLine("Actividad");
foreach (var Actividad in docente1.Actividad)
{
    Console.WriteLine(Actividad.Descripcion);
}
}