using System.Net;

namespace Infrastructure.Exceptions;

public class ValidationException(string message) : Exception(message)
{
    public static int StatusCode { get; } = (int)HttpStatusCode.BadRequest;
}