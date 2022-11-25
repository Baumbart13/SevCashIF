using System.Numerics;
using Newtonsoft.Json;

namespace SevCashIF.Core.Models;

public class Invoice : Entity {
    public const string ApiCommand = "invoices";

    [JsonProperty(PropertyName = "invoice_id", Required = Required.Always)]
    public override BigInteger SystemId { get; set; }

    /// <summary>
    /// Creation time. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_timestamp", Required = Required.Always)]
    public DateTime Timestamp { get; set; }
    
    /// <summary>
    /// Consecutive invoice number. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_number", Required = Required.Always)]
    public BigInteger InvoiceNumber { get; set; }

    /// <summary>
    /// Name of cashier. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_cashier", Required = Required.Always)]
    public string Cashier { get; set; } = string.Empty;
    
    /// <summary>
    /// System-ID of cashier
    /// </summary>
    [JsonProperty(PropertyName = "invoice_cashier_id")]
    public BigInteger CashierId { get; set; }

    /// <summary>
    /// Type of invoice.
    /// Test when fetching invoices.
    /// Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_mode", Required = Required.Always)]
    public string Mode { get; set; } = "default";

    /// <summary>
    /// Payment method name. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_payment", Required = Required.Always)]
    public string Payment { get; set; } = string.Empty;

    /// <summary>
    /// List of payment methods when <code>Payment</code> is "Kombiniert"
    /// </summary>
    [JsonProperty(PropertyName = "paymentMethods", Required = Required.DisallowNull)]
    public List<PaymentMethod> PaymentMethods { get; set; } = Array.Empty<PaymentMethod>().ToList();

    /// <summary>
    /// Total gross value after discounts. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_total", Required = Required.Always)]
    public decimal Total { get; set; }

    /// <summary>
    /// Amount of invoice discount
    /// </summary>
    [JsonProperty(PropertyName = "invoice_discount")]
    public decimal Discount { get; set; }
    
    /// <summary>
    /// Was the invoice canceled or not
    /// </summary>
    [JsonProperty(PropertyName = "invoice_cancellation", Required = Required.Always)]
    public bool WasCancelled { get; set; }

    /// <summary>
    /// Array of taxes by tax rate
    /// </summary>
    [JsonProperty(PropertyName = "invoice_taxes", Required = Required.Always)]
    public List<Tax> Taxes { get; set; }

    /// <summary>
    /// Total net value after discounts. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_totalNet", Required = Required.Always)]
    public decimal TotalNet { get; set; }
    
    /// <summary>
    /// Total tax value after discounts. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_totalTax", Required = Required.Always)]
    public decimal TotalTax { get; set; }

    /// <summary>
    /// Returns true when invoice references an existing one
    /// </summary>
    [JsonProperty(PropertyName = "invoice_reference")]
    public bool IsReferencing { get; set; }

    /// <summary>
    /// Additional invoice text
    /// </summary>
    [JsonProperty(PropertyName = "invoice_text", Required = Required.DisallowNull)]
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Returns true when small business is selected in settings
    /// </summary>
    [JsonProperty(PropertyName = "invoice_small_business")]
    public bool IsSmallBusiness { get; set; }
    
    /// <summary>
    /// Returns true when differential taxation is selected in settings
    /// </summary>
    [JsonProperty(PropertyName = "invoice_differential_taxation")]
    public bool IsDifferentialTaxation { get; set; }
    
    /// <summary>
    /// Currency used for the invoice. Required
    /// </summary>
    [JsonProperty(PropertyName = "invoice_currency", Required = Required.Always)]
    public string Currency { get; set; } = string.Empty;
    
    /// <summary>
    /// Own company on invoice
    /// </summary>
    [JsonProperty(PropertyName = "company", Required = Required.Always)]
    public Company Company { get; set; }
    
    /// <summary>
    /// The items with their quantity
    /// </summary>
    [JsonProperty(PropertyName = "items", Required = Required.Always)]
    public Dictionary<Article, int> Items { get; set; }
    
    /// <summary>
    /// The customer
    /// </summary>
    [JsonProperty(PropertyName = "customer", Required = Required.DisallowNull)]
    public User Customer { get; set; }
    
    //TODO: add signature and cancellation_details and Json-ify them
}