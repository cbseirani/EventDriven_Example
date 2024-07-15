using LogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace MainApi.Controllers;

/// <summary>
/// Sample controller for runtime testing of REST API exception handling
/// </summary>
/// <param name="exceptionService"></param>
[ApiController]
[Route("[controller]")]
public class ExceptionController(IExceptionService exceptionService) : ControllerBase
{
    /// <summary>
    /// Returns a NotFound 404 error and logs it
    /// </summary>
    [HttpGet("NotFound")]
    public Task GetNotFoundError() => exceptionService.ThrowNotFoundException();
    
    /// <summary>
    /// Returns a BadRequest error and logs it
    /// </summary>
    [HttpGet("Validation")]
    public Task GetValidationError() => exceptionService.ThrowValidationException();
}