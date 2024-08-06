using BlogPostTutorials.PrimaryConstructor.Console;

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

            Assert.NotSame(gato, gatoCopia);
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

            Assert.Equal(informacionGato, informacionGatoCopia);
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

            Assert.NotEqual(gato.Nombre, gatoCopia.Nombre);
        }

        [Fact]
        public void CopiarGato_Retorna_MismoObjeto()
        {
            // Arrange
            var gato = new Gato("Tom", "Masculino", 5, "Gris");

            // Act
            var gatoCopia = gato.CopiarGato();

            // Assert
            Assert.Same(gato, gatoCopia);

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
            Assert.Equal(gato.Nombre, gatoCopia.Nombre);

        }
    }
}