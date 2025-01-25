using Microsoft.AspNetCore.Mvc;

namespace BlogPostTutorials.ApiCtlrAttr.Api.Controllers;

/// <summary>
/// Aplica las convenciones y comportamientos de API a todos los 
/// controladores que hereden de esta clase.
/// </summary>
[ApiController]
public sealed class AppBaseController: ControllerBase
{
}
