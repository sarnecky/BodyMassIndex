using System.Net;
using System.Threading.Tasks;
using Business.Commands.CreateBMIResult;
using Business.Queries.GetResults;
using Contracts.Requests;
using Contracts.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BmiResultsController : BaseController
    {
        public BmiResultsController(IMediator mediator) 
            : base(mediator) {}

        [HttpPost]
        [ProducesResponseType(typeof(BmiResultResource), (int) HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BmiResultResource), (int) HttpStatusCode.NotFound)]
        public Task<IActionResult> Create([FromBody] BmiResultDto bmiResultDto) =>
            ProcessAsync(new CreateBmiResultCommand(bmiResultDto));
        
        [HttpGet]
        [ProducesResponseType(typeof(BmiResultResource), (int) HttpStatusCode.Created)]
        [ProducesResponseType(typeof(BmiResultResource), (int) HttpStatusCode.NotFound)]
        public Task<IActionResult> GetAll() =>
            ProcessAsync(new GetResultsQuery());
    }
}