using System;
using System.Threading.Tasks.Dataflow;
using LedgerStudy.Domain.Enums;

namespace LedgerStudy.Domain.Models
{
    public class Entry
    {
        public Guid Id { get; set; }
        public Batch Batch { get; set; }
        public Guid BatchId { get; set; }
        public DateTime CompetenceDate { get; set; }
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public EntryType EntryType { get; set; }
        public decimal Amount { get; set; }
        public string History { get; set; }
    }
}