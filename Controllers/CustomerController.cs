using Microsoft.AspNetCore.Mvc;
using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;
using shop.Domain.Commands.Hanlders;

namespace shop.Controllers
{
  [ApiController]
  [Route("")]
  public class CustomerController : ControllerBase
  {
    [HttpPost]
    [Route("v1/customers")]
    public CreateCustomerResponse Create([FromServices]ICreateCustomerHandler handler, [FromBody]CreateCustomerRequest command)
    {
      return handler.Handle(command);
    }
  }
}