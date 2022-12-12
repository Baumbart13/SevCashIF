using System.Text.Json;

namespace SevCashIF.Core.Json.Serializer.HelloCash; 

public class Invoice : ApiNamingPolicy{
    protected override Dictionary<string, string> NameMapping() {
        return new Dictionary<string, string> {
            [nameof(Models.Invoice.SystemId)]                  = "invoice_id",
            [nameof(Models.Invoice.Timestamp)]                 = "invoice_timestamp",
            [nameof(Models.Invoice.InvoiceNumber)]             = "invoice_number",
            [nameof(Models.Invoice.Cashier)]                   = "invoice_cashier",
            [nameof(Models.Invoice.CashierId)]                 = "invoice_cashier_id",
            [nameof(Models.Invoice.Mode)]                      = "invoice_mode",
            [nameof(Models.Invoice.Payment)]                   = "invoice_payment",
            [nameof(Models.Invoice.Total)]                     = "invoice_total",
            [nameof(Models.Invoice.Discount)]                  = "invoice_discount",
            [nameof(Models.Invoice.WasCancelled)]              = "invoice_cancellation",
            [nameof(Models.Invoice.Taxes)]                     = "taxes",
            [nameof(Models.Invoice.TotalNet)]                  = "invoice_totalNet",
            [nameof(Models.Invoice.TotalTax)]                  = "invoice_totalTax",
            [nameof(Models.Invoice.Text)]                      = "invoice_text",
            [nameof(Models.Invoice.IsReferencing)]             = "invoice_reference",
            [nameof(Models.Invoice.IsSmallBusiness)]           = "invoice_small_business",
            [nameof(Models.Invoice.IsDifferentialTaxation)]    = "invoice_differential_taxation",
            [nameof(Models.Invoice.Currency)]                  = "invoice_currency",
            [nameof(Models.Invoice.Company)]                   = "company",
            [nameof(Models.Invoice.Items)]                     = "items",
            [nameof(Models.Invoice.Customer)]                  = "customer",
            [nameof(Models.Invoice.Signature)]                 = "signature",
            [nameof(Models.Invoice.CancellationDetails)]       = "cancellation_details",
        };
    }
}