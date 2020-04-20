using System;
using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;

namespace shop.Domain.Commands.Hanlders
{
  public class CreateCustomerHandler : ICreateCustomerHandler
  {
    public CreateCustomerResponse Handle(CreateCustomerRequest request)
    {
      // verifica se o cliente já está cadastrado
      // valida os dados
      // insere o cliente
      // envia email de boas vindas
      return new CreateCustomerResponse
      {
        Id = Guid.NewGuid(),
        Name = "Samuel Levy",
        Email = "samuel@nokengo.com.br",
        Date = DateTime.Now
      };
    }
  }
}