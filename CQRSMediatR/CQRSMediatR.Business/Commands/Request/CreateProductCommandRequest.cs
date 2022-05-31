using CQRSMediatR.Business.Commands.Response;
using MediatR;

namespace CQRSMediatR.Business.Commands.Request
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
