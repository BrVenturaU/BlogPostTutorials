using BlogPostTutorials.ApiCtlrAttr.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostTutorials.ApiCtlrAttr.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonasController: ControllerBase
{
    private readonly List<Persona> _personas = [new Persona { Id = 1, Nombre = "John" }, new Persona { Id = 2, Nombre = "Johana" }];

    [HttpGet("{id:int}")]
    public ActionResult<Persona> ObtenerPersonaPorId(int id)
    {
        var persona = _personas.FirstOrDefault(p => p.Id == id);
        if(persona is null)
            return NotFound();

        return Ok(persona);
    }


    /// <summary>
    /// Utiliza la validación explícita o manual del ModelState retornando un <see cref="BadRequestResult" />.
    /// </summary>
    [HttpPost("CrearPersona1")]
    public ActionResult CrearPersona1([FromBody] Persona persona)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(persona);
    }

    /// <summary>
    /// Utiliza la validación explícita o manual del ModelState retornando un <see cref="ValidationProblemDetails" />
    /// </summary>
    [HttpPost("CrearPersona2")]
    public ActionResult CrearPersona2([FromBody] Persona persona)
    {
        if (!ModelState.IsValid)
            return ValidationProblem(); // es igual a return ValidationProblem(ModelState);

        return Ok(persona);
    }

    /// <summary>
    /// Deja que el atributo <see cref="ApiControllerAttribute" /> se encargue del comportamiento relacionado
    /// a la validación del ModelState.
    /// </summary>
    [HttpPost("CrearPersona3")]
    public ActionResult CrearPersona3([FromBody] Persona persona)
    {
        return Ok(persona);
    }


}
