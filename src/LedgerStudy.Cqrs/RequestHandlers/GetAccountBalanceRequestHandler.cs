using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LedgerStudy.Cqrs.Request;
using LedgerStudy.Cqrs.Response;
using LedgerStudy.Domain.Enums;
using LedgerStudy.Infra.Context;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LedgerStudy.Cqrs.RequestHandlers
{
    public class GetAccountBalanceRequestHandler : IRequestHandler<GetAccountBalanceRequest, GetAccountBalanceResponse>
    {
        private readonly ILedgerContext _context;

        public GetAccountBalanceRequestHandler(ILedgerContext context)
        {
            _context = context;
        }

        public Task<GetAccountBalanceResponse> Handle(GetAccountBalanceRequest request, CancellationToken cancellationToken)
        {
            var account = _context.GetAccountDetails(request.AccountId);
            var entries = _context.GetEntriesByAccount(request.AccountId);
            var totalCredit = entries
                .Where(x => x.EntryType == EntryType.Credit)
                .Sum(x => x.Amount);

            var totalDebit = entries
                .Where(x => x.EntryType == EntryType.Debit)
                .Sum(x => x.Amount);

            var result = new
            {
                Details = account,
                TotalCredit = totalCredit,
                TotalDebit = totalDebit,
                Balance = totalDebit - totalCredit,
                Entries = entries
            };

            return Task.FromResult(new GetAccountBalanceResponse(result));
        }
    }
}