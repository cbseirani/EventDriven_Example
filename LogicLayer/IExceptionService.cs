namespace LogicLayer;

public interface IExceptionService
{
    Task<bool> ThrowNotFoundException();
    Task<bool> ThrowValidationException();
}