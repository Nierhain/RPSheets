using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPSheets.Queries;

namespace RPSheets.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SheetsController: ControllerBase
    {
        private readonly IMediator _mediator;

        public SheetsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllSheetsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get()
        {
            var query = new GetSheetQuery();
            var result = await _mediator.Send(query);
        }
    }
}