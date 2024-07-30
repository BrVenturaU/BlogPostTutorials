using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostTutorials.TernaryOperator.Console;

public static class HelperMethods
{
    public static string BasicTernaryOperator(int valor1, int valor2)
        => valor1 > valor2 ? "El primer valor es mayor que el segundo." : "El segundo valor es mayor que el primero.";

    public static string NestedTernaryOperator(int valor1, int valor2)
        => valor1 > valor2 ? "El primer valor es mayor que el segundo." :
            valor1 < valor2 ? "El segundo valor es mayor que el primero." : "El primer valor y el segundo son iguales.";

    public static void ConditionalRef(int[] numeros, int valorComparar, int valorAsignar)
    {
        ref var valor2 = ref ((valorComparar >= 100) ? ref numeros[2] : ref numeros[4]);
        valor2 = valorAsignar;
    }
}