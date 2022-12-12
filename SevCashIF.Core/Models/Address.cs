using System.Numerics;

namespace SevCashIF.Core.Models;

public record Address {
    public string Street { get; set; } = string.Empty;
    public BigInteger HouseNumber { get; set; }
    public BigInteger PostalCode { get; set; }
    public string City { get; set; } = string.Empty;
}