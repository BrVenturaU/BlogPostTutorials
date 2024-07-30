
// Descomenta el que quieras ejecutar y comenta los que no.

// BasicTernaryOperatorComparison();
// NestedTernaryOperatorComparison();
ConditionalRef();

void BasicTernaryOperatorComparison()
{
    int valor1 = 10;
    int valor2 = 20;

    if (valor1 > valor2)
    {
        Console.WriteLine("Con if-else: El primer valor es mayor que el segundo.");
    }
    else
    {
        Console.WriteLine("Con if-else: El segundo valor es mayor que el primero.");
    }

    string mensaje = valor1 > valor2 ? "Con ternary: El primer valor es mayor que el segundo." : "Con ternary: El segundo valor es mayor que el primero.";
    Console.WriteLine(mensaje);
}

void NestedTernaryOperatorComparison()
{
    int valor1 = 10;
    int valor2 = 10;

    if (valor1 > valor2)
    {
        Console.WriteLine("Con if-else: El primer valor es mayor que el segundo.");
    }
    else if (valor1 < valor2)
    {
        Console.WriteLine("Con if-else: El segundo valor es mayor que el primero.");
    }
    else
    {
        Console.WriteLine("Con if-else: El primer valor y el segundo son iguales.");
    }

    string mensaje = valor1 > valor2 ? "Con ternary: El primer valor es mayor que el segundo." :
        valor1 < valor2 ? "Con ternary: El segundo valor es mayor que el primero." : "Con ternary: El primer valor y el segundo son iguales.";
    Console.WriteLine(mensaje);
}

void ConditionalRef()
{
    var numeros = new int[] { 1, 2, 3, 4, 5 };
    var valor1 = 100;
    ref var valor2 = ref ((valor1 >= 100) ? ref numeros[2] : ref numeros[4]);
    valor2 = 10000;
    Console.WriteLine(string.Join(" ", numeros));
}