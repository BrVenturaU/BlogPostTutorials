using BlogPostTutorials.PrimaryConstructor.Console;
using FluentAssertions;

namespace BlogPostTutorials.PrimaryConstructor.UnitTests
{
    public class GatoTests
    {
        [Fact]
        public void ConstructorDeCopia_Retorna_NuevoGato()
        {
            // Arrange
            var gato = new Gato("Tom", "Masculino", 5, "Gris");

            // Act
            var gatoCopia = new Gato(gato);

            // Assert
            gatoCopia.Should()
                .BeEquivalentTo(gato)
                .And.NotBeSameAs(gato);
        }

        [Fact]
        public void ObtenerInformacionGatoEnCopia_Retorna_MismaInformacion()
        {
            // Arrange
            var gato = new Gato("Tom", "Masculino", 5, "Gris");
            var gatoCopia = new Gato(gato);

            // Act
            var informacionGato = gato.ObtenerInformacionGato();
            var informacionGatoCopia = gatoCopia.ObtenerInformacionGato();

            // Assert
            informacionGatoCopia.Should()
                .Be(informacionGato);
        }

        [Fact]
        public void CambioPropiedadNombreEnCopia_NoAfecta_PropiedadNombreGatoOriginal()
        {
            // Arrange
            var gato = new Gato("Tom", "Masculino", 5, "Gris");
            var gatoCopia = new Gato(gato);

            // Act
            gatoCopia.Nombre = "Harry";

            // Assert
            gatoCopia.Nombre.Should()
                .NotBe(gato.Nombre);
        }

        [Fact]
        public void CopiarGato_Retorna_MismoObjeto()
        {
            // Arrange
            var gato = new Gato("Tom", "Masculino", 5, "Gris");

            // Act
            var gatoCopia = gato.CopiarGato();

            // Assert
            gatoCopia.Should()
                .BeEquivalentTo(gato)
                .And.BeSameAs(gato);
        }

        [Fact]
        public void CambioPropiedadNombreCopiarGato_Afecta_PropiedadNombreGatoOriginal()
        {
            // Arrange
            var gato = new Gato("Tom", "Masculino", 5, "Gris");
            var gatoCopia = gato.CopiarGato();

            // Act
            gatoCopia.Nombre = "Harry";

            // Assert
            gatoCopia.Nombre.Should()
                .Be(gato.Nombre);

        }
    }
}