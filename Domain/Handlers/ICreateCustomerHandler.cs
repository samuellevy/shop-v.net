using System;
using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;

namespace shop.Domain.Commands.Hanlders
{
  public interface ICreateCustomerHandler
  {
    CreateCustomerResponse Handle(CreateCustomerRequest request);
  }
}