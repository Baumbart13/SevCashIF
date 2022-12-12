using System.Numerics;

namespace SevCashIF.Core.Models;

public class CancellationDetails {
    public BigInteger Number { get; set; }
    public string Cashier { get; set; } = string.Empty;
    public BigInteger CashierId { get; set; }
    public DateTime Timestamp { get; set; }
    public string Text { get; set; } = string.Empty;
}