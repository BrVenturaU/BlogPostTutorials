using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostTutorials.PrimaryConstructor.Console;

public class ServicioFalso 
{
    public string RetornaTextoMayuscula(string texto)
    {
        return texto.ToUpper();
    }
}

public class OtroServicio(ServicioFalso servicioFalso)
{

    public string ObtenerMensaje()
    {
        return servicioFalso.RetornaTextoMayuscula("Hola Mundo");
    }

    public void HacerAlgo()
    {
        servicioFalso = null;
    }
}

public class OtroServicio2
{
    private readonly ServicioFalso _servicioFalso;

    public OtroServicio2(ServicioFalso servicioFalso)
    {
        _servicioFalso = servicioFalso;
    }

    public string ObtenerMensaje()
    {
        return _servicioFalso.RetornaTextoMayuscula("Hola Mundo");
    }

    public void HacerAlgo()
    {
        // Error de compilación, no se puede asignar un valor a un campo de solo lectura, solo durante la inicialización
        //_servicioFalso = null; 
    }
}
public class OtroServicio3(ServicioFalso servicioFalso)
{
    private readonly ServicioFalso _servicioFalso = servicioFalso;

    public string ObtenerMensaje()
    {
        return _servicioFalso.RetornaTextoMayuscula("Hola Mundo");
    }

    public void HacerAlgo()
    {
        // Error de compilación, no se puede asignar un valor a un campo de solo lectura, solo durante la inicialización
        //_servicioFalso = null;
        // Es posible al parametro pero no al campo de solo lectura
        servicioFalso = null;
    }
}
