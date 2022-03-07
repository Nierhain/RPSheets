using Microsoft.AspNetCore.Mvc;
using RPSheets.Services;

namespace RPSheets.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SheetsController: ControllerBase
    {
        private readonly SheetsService _service;

        public SheetsController(SheetsService service)
        {
            _service = service;
        }
    }
}
