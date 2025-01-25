using BlogPostTutorials.ApiCtlrAttr.Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// Aplica las convenciones y comportamientos de API
// a todos los controladores del ensamblado.
// [assembly: ApiController]

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddSingleton<IClientErrorFactory, AppClientErrorFactory>();
builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        // options.SuppressModelStateInvalidFilter = true;
        // options.SuppressInferBindingSourcesForParameters = true;
        // options.SuppressConsumesConstraintForFormFileParameters = true;
        // options.SuppressMapClientErrors = true;
        options.InvalidModelStateResponseFactory = context =>
        {
            var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Hola desde modelo inválido!.");
            var newResponse = new
            {
                path = context.HttpContext.Request.Path.ToString(),
                httpMethod = context.HttpContext.Request.Method,
                resource = (context.ActionDescriptor as ControllerActionDescriptor)?.ControllerName,
                endpoint = (context.ActionDescriptor as ControllerActionDescriptor)?.ActionName,
                errors = context
                    .ModelState
                    .ToDictionary(a => a.Key, a => a.Value?.Errors.Select(e => e.ErrorMessage))
            };
            return new BadRequestObjectResult(newResponse);
        };
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
