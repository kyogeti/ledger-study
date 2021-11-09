using System;
using LedgerStudy.Cqrs.Response;
using MediatR;

namespace LedgerStudy.Cqrs.Request
{
    public class GetAccountBalanceRequest : IRequest<GetAccountBalanceResponse>
    {
        public Guid AccountId { get; set; }
    }
}