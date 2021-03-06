using CQRSMediatR.Business.Commands.Request;
using CQRSMediatR.Business.Commands.Response;
using CQRSMediatR.Business.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatR.Business.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new Product()
            {
                Id = id,
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                CreateTime = DateTime.Now
            });
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id
            };
        }
    }
}
