using System.Net;

namespace BusinessLogic.DTO;

public class ErrorDetails
{
    public HttpStatusCode Code { get; set; }

    public string? Message { get; set; }
}