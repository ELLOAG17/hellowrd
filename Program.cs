// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var Docente1 = new Docente();
Docente1.Nombres= "Elian Lopez";
Docente1.Apellidos= "Aguilar";
Docente1.NumeroDeEmpleado= "1234";

//Docente1.id= 1;
var Actividad1 = new Actividad
{
    FechaDeRegistro = DateTime.Now,
    DocenteId = Docente1.Id,
    EjeTematico ="eje1";
    Subeje = "Subeje2";
    Descripcion="nodormirseenclase";

};

var Actividad2 = new Actividad
{
    FechaDeRegistro = DateTime.Today,
    DocenteId = Docente1.Id,
    EjeTematico ="eje2";
    Subeje = "Subeje3";
    Descripcion="Trabajar en viernes";
};

Console.WriteLine($"Actividad: {Actividad1.Descripcion}");
Console.WriteLine($"Actividad: {Actividad2.Descripcion}");