using System;
using System.Net;
using System.Threading.Tasks;
using Infrastructure.Exceptions;
using Infrastructure.Result.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> ProcessAsync<T>(
            IRequest<IResult<T>> command)
        {
            return await TryAction(async () =>
            {
                return await _mediator.Send(command) switch
                {
                    Failure<T> failure => InternalServerError(failure.Error),
                    Success<T> success => Ok(success.Payload),
                    _ => throw new InvalidOperationException("IResult state is unknown. Please use Success or Failure")
                };
            });
        }
        
        private async Task<IActionResult> TryAction(Func<Task<IActionResult>> action)
        {
            IActionResult actionResult;
            try
            {
                actionResult = await action();
            }
            catch (BadRequestException e)
            {
                actionResult = BadRequest(e.Message);
            }
            catch (Exception e)
            {
                actionResult = StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
            return actionResult;
        }
        
        private ObjectResult InternalServerError(object value)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, value);
        }
    }
}