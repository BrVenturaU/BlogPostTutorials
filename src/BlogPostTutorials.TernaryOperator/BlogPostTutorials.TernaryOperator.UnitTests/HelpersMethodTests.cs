using BlogPostTutorials.TernaryOperator.Console;

namespace BlogPostTutorials.TernaryOperator.UnitTests;

public class HelpersMethodTests
{
    [Fact]
    public void BasicTernaryOperator_Returns_Valor1GreaterThanValor2()
    {
        // Arrange
        int valor1 = 10;
        int valor2 = 5;

        // Act
        string mensaje = HelperMethods.BasicTernaryOperator(valor1, valor2);

        // Assert
        Assert.Equal("El primer valor es mayor que el segundo.", mensaje);
    }

    [Fact]
    public void BasicTernaryOperator_Returns_Valor2_Greater_Than_Valor1()
    {
        // Arrange
        int valor1 = 10;
        int valor2 = 50;

        // Act
        string mensaje = HelperMethods.BasicTernaryOperator(valor1, valor2);

        // Assert
        Assert.Equal("El segundo valor es mayor que el primero.", mensaje);
    }

    [Fact]
    public void NestedTernaryOperator_Returns_Valor1GreaterThanValor2()
    {
        // Arrange
        int valor1 = 10;
        int valor2 = 5;

        // Act
        string mensaje = HelperMethods.NestedTernaryOperator(valor1, valor2);

        // Assert
        Assert.Equal("El primer valor es mayor que el segundo.", mensaje);
    }

    [Fact]
    public void NestedTernaryOperator_Returns_Valor2GreaterThanValor1()
    {
        // Arrange
        int valor1 = 10;
        int valor2 = 50;

        // Act
        string mensaje = HelperMethods.NestedTernaryOperator(valor1, valor2);

        // Assert
        Assert.Equal("El segundo valor es mayor que el primero.", mensaje);
    }

    [Fact]
    public void NestedTernaryOperator_Returns_Valor1EqualThanValor2()
    {
        // Arrange
        int valor1 = 100;
        int valor2 = 100;

        // Act
        string mensaje = HelperMethods.NestedTernaryOperator(valor1, valor2);

        // Assert
        Assert.Equal("El primer valor y el segundo son iguales.", mensaje);
    }

    [Theory]
    [InlineData(50, 200)]
    [InlineData(150, 5000)]
    public void ConditionalRef_Assigns_ValorAsignar_ByReferenceToArray(int valorComparar, int valorAsignar)
    {
        // Arrange - Collection Expression syntax
        int[] numeros = [1, 2, 3, 4, 5];

        // Act
        HelperMethods.ConditionalRef(numeros, valorComparar, valorAsignar);

        // Assert
        Assert.Contains(valorAsignar, numeros);
    }
}