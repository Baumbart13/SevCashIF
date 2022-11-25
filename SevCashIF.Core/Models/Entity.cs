using System.Numerics;

namespace SevCashIF.Core.Models;

public abstract class Entity {
    /// <summary>
    /// System-ID of the entity
    /// </summary>
    public virtual BigInteger SystemId { get; set; }
}