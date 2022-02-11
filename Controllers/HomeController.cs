using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using MediatoR.Models;

namespace MediatoR.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        protected readonly IMediator _mediator;

        public HomeController(IMediator mediator) 
        { 
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<int> Index()
        {
            var request = new AddRequest(3, 5);
            var response = await _mediator.Send(request);

            return response.Total;
        }
    }
}
