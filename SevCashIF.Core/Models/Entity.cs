using System.Numerics;

namespace SevCashIF.Core.Models;

public abstract class Entity {
    /// <summary>
    /// System-ID of the entity
    /// </summary>
    public BigInteger SystemId { get; set; }
}