using CQRSMediatR.Business.Commands.Response;
using MediatR;
using System;

namespace CQRSMediatR.Business.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
