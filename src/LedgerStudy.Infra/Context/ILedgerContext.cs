using System;
using System.Collections.Generic;
using LedgerStudy.Domain.Models;

namespace LedgerStudy.Infra.Context
{
    public interface ILedgerContext
    {
        void AddBatch(Batch batch);
        void AddBatches(IEnumerable<Batch> batches);
        Account GetAccountDetails(Guid accountId);
        List<Entry> GetEntriesByAccount(Guid accountId);
    }
}