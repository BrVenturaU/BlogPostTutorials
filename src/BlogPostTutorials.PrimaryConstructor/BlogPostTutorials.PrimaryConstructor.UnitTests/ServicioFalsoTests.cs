using BlogPostTutorials.PrimaryConstructor.Console;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostTutorials.PrimaryConstructor.UnitTests
{
    public class ServicioFalsoTests
    {
        [Fact]
        public void RetornaTextoMayuscula_Retorna_TextoEnMayuscula()
        {
            // Arrange
            var texto = "hola mundo";
            var servicio = new ServicioFalso();

            // Act
            var nuevoTexto = servicio.RetornaTextoMayuscula(texto);

            // Assert
            nuevoTexto.Should()
                .NotBe(texto)
                .And.NotBeLowerCased();
        }

    }
}
