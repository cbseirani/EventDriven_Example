using Infrastructure.Exceptions;

namespace LogicLayer.Implementation;

/*
 * Sample logical service layer class for runtime testing of exception handling 
 */
public class ExceptionService : IExceptionService
{
    public Task<bool> ThrowNotFoundException() => throw new NotFoundException("Item not found!");

    public Task<bool> ThrowValidationException() => throw new ValidationException("Request missing value!");
}