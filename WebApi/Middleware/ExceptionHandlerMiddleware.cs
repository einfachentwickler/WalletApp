using BusinessLogic.DTO;
using System.Net;
using WebApi.Constants;

namespace WebApi.Middleware;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch
        {
            await HandleExceptionAsync(httpContext);
        }
    }
    private static async Task HandleExceptionAsync(HttpContext context)
    {
        context.Response.ContentType = WebApiConstants.CONTENT_TYPE_JSON;
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        ErrorDetails details = new()
        {
            Code = HttpStatusCode.InternalServerError,
            Message = "Internal Server Error"
        };

        await context.Response.WriteAsJsonAsync(details);
    }
}