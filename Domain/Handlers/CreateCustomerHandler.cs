using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;

namespace shop.Domain.Commands.Handlers
{
  public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
  {
    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
      // verifica se o cliente já está cadastrado
      // valida os dados
      // insere o cliente
      // envia email de boas vindas
      var result = new CreateCustomerResponse
      {
        Id = Guid.NewGuid(),
        Name = "Samuel Levy",
        Email = "samuel@nokengo.com.br",
        Date = DateTime.Now
      };

      return Task.FromResult(result);
    }
  }
}