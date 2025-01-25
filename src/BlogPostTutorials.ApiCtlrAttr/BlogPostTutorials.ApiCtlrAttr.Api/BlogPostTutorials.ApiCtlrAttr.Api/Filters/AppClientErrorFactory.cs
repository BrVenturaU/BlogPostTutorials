using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BlogPostTutorials.ApiCtlrAttr.Api.Filters;

public sealed class AppClientErrorFactory(ILogger<AppClientErrorFactory> logger) : IClientErrorFactory
{
    private readonly ILogger<AppClientErrorFactory> _logger = logger;
    public IActionResult? GetClientError(ActionContext actionContext, IClientErrorActionResult clientError)
    {
        _logger.LogWarning("Error del cliente.");
        return new ObjectResult("ClientErrorFactory personalizado.") { StatusCode = clientError.StatusCode };
    }
}
