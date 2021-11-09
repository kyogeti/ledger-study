using System;
using System.Collections.Generic;
using System.Linq;
using LedgerStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LedgerStudy.Infra.Context
{
    public class LedgerContext : ILedgerContext
    {
        private readonly DefaultContext _context;

        public LedgerContext(DefaultContext context)
        {
            _context = context;
        }

        public void AddBatch(Batch batch)
        {
            _context.Batches.Add(batch);
            _context.SaveChanges();
        }

        public void AddBatches(IEnumerable<Batch> batches)
        {
            _context.Batches.AddRange(batches);
            _context.SaveChanges();
        }

        public Account GetAccountDetails(Guid accountId) => _context.Accounts
            .Include(x => x.Entries)
            .Where(x => x.Id == accountId)?
            .FirstOrDefault();

        public List<Entry> GetEntriesByAccount(Guid accountId) => _context.Entries
            .Include(x => x.Account)
            .Include(x => x.Batch)
            .Where(x => x.AccountId == accountId)?
            .ToList();
    }
}