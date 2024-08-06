using BlogPostTutorials.PrimaryConstructor.Console;

//var persona = new Persona("John Doe", 30);
// Error en tiempo de compilación, los miembros no existen en Persona.
//persona.nombre = "";
//persona.edad;

//var personaRecord = new PersonaRecord("John Doe", 30);
// Los miembros son accesibles en el tipo PersonaRecord
//personaRecord.Nombre;
//personaRecord.Edad;

//ConstructoresBasicos();

//ConstructoresPrimarios();

InyeccionDependenciaSimplificado();


void ConstructoresBasicos()
{
    var gato1 = new Gato();
    var gato2 = new Gato("Tom", "Masculino", 5, "Gris");
    var gatoCopia = new Gato(gato2);

    Console.WriteLine(gato1.ObtenerInformacionGato());
    Console.WriteLine(gato2.ObtenerInformacionGato());
    Console.WriteLine(gatoCopia.ObtenerInformacionGato());

    gato2.Nombre = "Tommy";

    Console.WriteLine(gato2.ObtenerInformacionGato());
    Console.WriteLine(gatoCopia.ObtenerInformacionGato());
}

void ConstructoresPrimarios()
{
    var nombrePersona = "John Doe";
    var persona = new Persona(nombrePersona, 40);
    Console.WriteLine(persona.Nombre);
    Console.WriteLine($"Los nombres son iguales: {nombrePersona.Equals(persona.Nombre)}");

    persona.Formatear();

    Console.WriteLine(persona.Nombre);
    Console.WriteLine($"Los nombres son iguales: {nombrePersona.Equals(persona.Nombre)}");
}

void InyeccionDependenciaSimplificado()
{
    var servicioFalso = new ServicioFalso();
    var otroServicio = new OtroServicio(servicioFalso);

    var mensaje = otroServicio.ObtenerMensaje();
    Console.WriteLine(mensaje);

    otroServicio.HacerAlgo();
    mensaje = otroServicio.ObtenerMensaje();
    Console.WriteLine(mensaje);
}