using System.ComponentModel.DataAnnotations;

namespace BlogPostTutorials.ApiCtlrAttr.Api.Entities;

public class Persona
{
    [Required(ErrorMessage = "El identificador de la persona es requerido.")]
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre de la persona es requerido.")]
    public string Nombre { get; set; }
    [Range(0, 200, ErrorMessage = "La edad de la persona tiene que ser un valor entre 0 y 200.")]
    public int Edad { get; set; }
}