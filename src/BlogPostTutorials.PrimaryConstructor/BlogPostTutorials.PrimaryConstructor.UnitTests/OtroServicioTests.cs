using BlogPostTutorials.PrimaryConstructor.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// No se hace tests de: OtroServicio2, OtroServicio3  porque
// son la misma clase, solucionando el problema que se está probando de la clase OtroServicio.
// en términos generales, no añaden nada, son solo demostrativas.
namespace BlogPostTutorials.PrimaryConstructor.UnitTests
{
    public class OtroServicioTests
    {
        [Fact]
        public void ObtenerMensaje_Retorna_Mensaje()
        {
            // Arrange
            var servicioFalso = new ServicioFalso();
            var otroServicio = new OtroServicio(servicioFalso);

            // Act
            var mensaje = otroServicio.ObtenerMensaje();

            // Assert
            Assert.NotEmpty(mensaje);
        }

        [Fact]
        public void ObtenerMensaje_Arroja_Excepcion_SiHacerAlgoSeEjecutaAntes()
        {
            // Arrange
            var servicioFalso = new ServicioFalso();
            var otroServicio = new OtroServicio(servicioFalso);

            // Act
            otroServicio.HacerAlgo();

            // Assert
            Assert.Throws<NullReferenceException>(otroServicio.ObtenerMensaje);
        }
    }
}
