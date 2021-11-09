using System;
using System.Threading;
using System.Threading.Tasks;
using LedgerStudy.Cqrs.Request;
using LedgerStudy.Cqrs.Response;
using LedgerStudy.Infra.Context;
using MediatR;

namespace LedgerStudy.Cqrs.RequestHandlers
{
    public class CreateBatchRequestHandler : IRequestHandler<CreateBatchRequest, CreateBatchResponse>
    {
        private readonly ILedgerContext _context;

        public CreateBatchRequestHandler(ILedgerContext context)
        {
            _context = context;
        }

        public Task<CreateBatchResponse> Handle(CreateBatchRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _context.AddBatch(request.Batch);
                return Task.FromResult(new CreateBatchResponse(new { Result = "Batch created." }));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CreateBatchResponse(new { Result = "Batch creation failed." }));
            }
            
            
        }
    }
}