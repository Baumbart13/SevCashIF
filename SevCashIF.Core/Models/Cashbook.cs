using System.Numerics;

namespace SevCashIF.Core.Models;

public class Cashbook {
    public const string ApiCommand = "cashBook";

    public class Entry : Entity {
        public DateTime Timestamp { get; set; }
        public BigInteger Number { get; set; }
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gross amount
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// SystemID of the employee who created the entry
        /// </summary>
        public BigInteger EmployeeId { get; set; }

        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 0/1 - Was the entry automatically created or not?
        /// For example, creating an invoice with cash payment
        /// </summary>
        public bool IsSystemEntry { get; set; }

        /// <summary>
        /// 'test' when fetching test entries, else 'default'
        /// </summary>
        public string Mode { get; set; } = string.Empty;

        /// <summary>
        /// Corporate or private
        /// 'geschäftlich' or 'privat'
        /// </summary>
        public string BusinessType { get; set; } = string.Empty;

        public BigInteger InvoiceNumber { get; set; }
        public bool WasCancelled { get; set; }
    }

    public List<Entry> Entries { get; set; }
}