using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostTutorials.PrimaryConstructor.Console;

public record PersonaRecord(string Nombre, int Edad);

// Equivalente de record anterior en forma convencional
public record PersonaRecord2
{
    public string Nombre { get; init; }
    public int Edad { get; init; }

    public PersonaRecord2(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

public record PersonaRecordDto(string Nombre, int Edad);

public class Persona(string nombre, int edad)
{
    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }


    public void Formatear()
    {
        nombre = nombre.ToUpper();
    }
}

public class PersonaDto(string nombre, int edad)
{
    public string Nombre { get; set; } = nombre;
    public int Edad { get; set; } = edad;
}

// Equivalente de clase anterior en forma convencional
public class Persona2
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona2(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}
