namespace SevCashIF.Core.Models;

public class Service : Entity {
    /// <summary>
    /// Required
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Required
    /// </summary>
    public string EAN { get; set; } = string.Empty;

    /// <summary>
    /// Required
    /// </summary>
    public decimal TaxRate { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    public decimal NetSellingPrice { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    public decimal GrossSellingPrice { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    public string Comment { get; set; } = string.Empty;

    /// <summary>
    /// Required
    /// </summary>
    public Color Color { get; set; } = Color.Default;
    
    public Category Category { get; set; }
}