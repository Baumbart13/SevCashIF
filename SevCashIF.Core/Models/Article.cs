namespace SevCashIF.Core.Models;

public class Article : Entity {
    public static class DiscountUnit {
        public const string Absolute = "absolute";
        public const string Percent = "percent";
    }

    public string Name { get; set; } = string.Empty;
    public decimal Quantity { get; set; } = decimal.MinusOne;
    public decimal PricePerItem { get; set; } = decimal.Zero;
    public decimal TaxRate { get; set; } = decimal.Zero;
}