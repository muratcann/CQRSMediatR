using CQRSMediatR.Business.Queries.Response;
using MediatR;
using System;

namespace CQRSMediatR.Business.Queries.Request
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
