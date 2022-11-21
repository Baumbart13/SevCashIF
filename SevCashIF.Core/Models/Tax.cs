namespace SevCashIF.Core.Models; 

public class Tax {
    /// <summary>
    /// Tax-rate
    /// </summary>
    public decimal TaxRate { get; set; }
    
    /// <summary>
    /// Gross amount of tax rate
    /// </summary>
    public decimal TaxGross { get; set; }
    
    /// <summary>
    /// Net amount of tax rate
    /// </summary>
    public decimal TaxNet { get; set; }
    
    /// <summary>
    /// Tax amount of tax rate
    /// </summary>
    public decimal TaxAmount { get; set; }
}