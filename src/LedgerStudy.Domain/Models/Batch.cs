using System;
using System.Collections.Generic;

namespace LedgerStudy.Domain.Models
{
    public class Batch
    {
        public Guid Id { get; set; }
        public string BatchDescription { get; set; }
        public List<Entry> Entries { get; set; }

        public Batch()
        {
            Entries = new List<Entry>();
        }
    }
}