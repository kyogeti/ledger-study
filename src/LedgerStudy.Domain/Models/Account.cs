using System;
using System.Collections.Generic;

namespace LedgerStudy.Domain.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }

        public Account()
        {
            Entries = new List<Entry>();
        }
    }
}