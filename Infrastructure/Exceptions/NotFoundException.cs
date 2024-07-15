using System.Net;

namespace Infrastructure.Exceptions;

public class NotFoundException(string message) : Exception(message)
{
    public static int StatusCode { get; } = (int)HttpStatusCode.NotFound;
}