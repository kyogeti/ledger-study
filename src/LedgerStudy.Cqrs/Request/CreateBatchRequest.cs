using LedgerStudy.Cqrs.Response;
using LedgerStudy.Domain.Models;
using MediatR;

namespace LedgerStudy.Cqrs.Request
{
    public class CreateBatchRequest : IRequest<CreateBatchResponse>
    {
        public Batch Batch { get; set; }
    }
}