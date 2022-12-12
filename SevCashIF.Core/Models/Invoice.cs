using System.Numerics;

namespace SevCashIF.Core.Models;

public class Invoice : Entity {
    public const string ApiCommand = "invoices";

    public override BigInteger SystemId { get; set; }

    /// <summary>
    /// Creation time. Required
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Consecutive invoice number. Required
    /// </summary>
    public BigInteger InvoiceNumber { get; set; }

    /// <summary>
    /// Name of cashier. Required
    /// </summary>
    public string Cashier { get; set; } = string.Empty;

    /// <summary>
    /// System-ID of cashier
    /// </summary>
    public BigInteger CashierId { get; set; }

    /// <summary>
    /// Type of invoice.
    /// Test when fetching invoices.
    /// Required
    /// </summary>
    public string Mode { get; set; } = "default";

    /// <summary>
    /// Payment method name. Required
    /// </summary>
    public string Payment { get; set; } = string.Empty;

    /// <summary>
    /// List of payment methods when <code>Payment</code> is "Kombiniert"
    /// </summary>
    public List<PaymentMethod> PaymentMethods { get; set; } = Array.Empty<PaymentMethod>().ToList();

    /// <summary>
    /// Total gross value after discounts. Required
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// Amount of invoice discount
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Was the invoice canceled or not
    /// </summary>
    public bool WasCancelled { get; set; }

    /// <summary>
    /// Array of taxes by tax rate
    /// </summary>
    public List<Tax> Taxes { get; set; }

    /// <summary>
    /// Total net value after discounts. Required
    /// </summary>
    public decimal TotalNet { get; set; }

    /// <summary>
    /// Total tax value after discounts. Required
    /// </summary>
    public decimal TotalTax { get; set; }

    /// <summary>
    /// Returns true when invoice references an existing one
    /// </summary>
    public bool IsReferencing { get; set; }

    /// <summary>
    /// Additional invoice text
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Returns true when small business is selected in settings
    /// </summary>
    public bool IsSmallBusiness { get; set; }

    /// <summary>
    /// Returns true when differential taxation is selected in settings
    /// </summary>
    public bool IsDifferentialTaxation { get; set; }

    /// <summary>
    /// Currency used for the invoice. Required
    /// </summary>
    public string Currency { get; set; } = string.Empty;

    /// <summary>
    /// Own company on invoice
    /// </summary>
    public Company Company { get; set; }

    /// <summary>
    /// The items with their quantity
    /// </summary>
    public Dictionary<Article, int> Items { get; set; }

    /// <summary>
    /// The customer
    /// </summary>
    public User Customer { get; set; }
    
    /// <summary>
    /// Signature block for AT or DE if present
    /// </summary>
    public Signatures.ISignature Signature { get; set; }
    
    /// <summary>
    /// Detailed information when invoice is cancelled
    /// </summary>
    public CancellationDetails CancellationDetails { get; set; }

    //TODO: add signature and cancellation_details and Json-ify them
}