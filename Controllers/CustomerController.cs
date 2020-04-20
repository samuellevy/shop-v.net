using Microsoft.AspNetCore.Mvc;
using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;
using shop.Domain.Commands.Handlers;
using MediatR;
using System.Threading.Tasks;

namespace shop.Controllers
{
  [ApiController]
  [Route("")]
  public class CustomerController : ControllerBase
  {
    [HttpPost]
    [Route("v1/customers")]
    public Task<CreateCustomerResponse> Create([FromServices]IMediator mediator, [FromBody]CreateCustomerRequest command)
    {
      return mediator.Send(command);
    }
  }
}