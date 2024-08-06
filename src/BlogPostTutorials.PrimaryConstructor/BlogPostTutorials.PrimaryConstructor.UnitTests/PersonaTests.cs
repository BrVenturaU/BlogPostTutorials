using BlogPostTutorials.PrimaryConstructor.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostTutorials.PrimaryConstructor.UnitTests
{
    public class PersonaTests
    {

        // Recordemos que este no es el comportamiento ideal
        [Fact]
        public void Formatear_Modifica_Parametro_Altera_PropiedadNombre()
        {
            // Arrange
            var nombrePersona = "John Doe";
            var persona = new Persona(nombrePersona, 40);

            // Act
            persona.Formatear();

            // Assert

            Assert.NotEqual(nombrePersona, persona.Nombre);
        }
    }
}
