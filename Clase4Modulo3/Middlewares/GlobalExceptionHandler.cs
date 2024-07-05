using Clase4Modulo3.Exceptions;

namespace Clase4Modulo3.Middlewares
{
    public class GlobalExceptionHandler : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            try
            {
                await next(context);

            }
            catch (ValidationNegocioException ex)
            {
                context.Response.StatusCode = 400;
                context.Response.ContentType = "application/json";


                var respuesta = new
                {
                    Error = $"Error de validacion en la API  {context.Request.Path.Value} + {context.Request.Method}"
                };
                await context.Response.WriteAsJsonAsync(respuesta);
                
            }



        }
    }
}
