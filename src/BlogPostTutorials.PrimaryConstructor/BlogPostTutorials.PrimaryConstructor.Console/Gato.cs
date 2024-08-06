using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostTutorials.PrimaryConstructor.Console;

public class Gato
{
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public int Edad { get; set; }
    public string Color { get; set; }
    private static int _cantidadDePatas;

    // Constructor sin parametos.
    // Sí no vamos a definir otro constructor o no lo necesitamos
    // podemos borrarlo.
    public Gato()
    {
        
    }

    // Constructor con parametros
    public Gato(string nombre, string genero, int edad, string color)
    {
        Nombre = nombre;
        Genero = genero;
        Edad = edad;
        Color = color;
    }

    // Constructor privado
    private Gato(string nombre)
    {
        Nombre = nombre;
    }

    // Constructor estatico
    static Gato()
    {
        _cantidadDePatas = 4;
    }

    // Constructor de copia
    public Gato(Gato gato)
    {
        Nombre = gato.Nombre;
        Genero = gato.Genero;
        Edad = gato.Edad;
        Color = gato.Color;
    }

    public Gato CopiarGato()
    {
        return this;
    }

    public string ObtenerInformacionGato()
    {
        return $"El gato se llama {Nombre} tiene {Edad} años y es color {Color} y tiene {_cantidadDePatas} patas.";
    }
}
