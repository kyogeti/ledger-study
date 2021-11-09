using System.Collections.Generic;
using LedgerStudy.Domain.Models;

namespace LedgerStudy.Cqrs.Response
{
    public class GetAccountBalanceResponse : DefaultResponse<object>
    {
        public GetAccountBalanceResponse(object response) : base(response)
        {
        }
    }
}