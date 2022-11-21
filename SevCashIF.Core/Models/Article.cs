namespace SevCashIF.Core.Models;

public class Article : Entity {
    public static class DiscountUnit {
        public const string Absolute = "absolute";
        public const string Percent = "percent";
    }

    /// <summary>
    /// Required
    /// </summary>
    public string Name { get; set; } = string.Empty;

    public int Code { get; set; }
    public string UnitDescription { get; set; } = string.Empty;
    public decimal Stock { get; set; }
    public string ArticleDescription { get; set; } = string.Empty;
    public Color Color { get; set; } = Color.Default;
    public decimal NetPurchasePrice { get; set; }
    public string EAN { get; set; } = string.Empty;
    public decimal TaxRate { get; set; }
    public decimal NetSellingPrice { get; set; }
    public decimal GrossSellingPrice { get; set; }

    /// <summary>
    /// Minimum stock for warning mail (when configured)
    /// </summary>
    public decimal MinimumStock { get; set; }
    
    /// <summary>
    /// Is the article a reference to an invoice or not
    /// </summary>
    public bool IsBillReference { get; set; }
    
    public Category Category { get; set; }
    public Company Supplier { get; set; }
    public Company Manufacturer { get; set; }
    public Company ForeignCompany { get; set; }
}