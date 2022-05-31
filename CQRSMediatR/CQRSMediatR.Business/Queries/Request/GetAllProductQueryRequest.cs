using CQRSMediatR.Business.Queries.Response;
using MediatR;
using System.Collections.Generic;

namespace CQRSMediatR.Business.Queries.Request
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {

    }
}
