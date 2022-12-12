using System.Text.Json;
using SevCashIF.Core.Models;

namespace SevCashIF.Core.Json;

public class HelloCashSerializer : JsonNamingPolicy {
    private readonly Dictionary<string, string> _nameMapping = new Dictionary<string, string> {
#region Invoice

        [nameof(Invoice.SystemId)]                  = "invoice_id",
        [nameof(Invoice.Timestamp)]                 = "invoice_timestamp",
        [nameof(Invoice.InvoiceNumber)]             = "invoice_number",
        [nameof(Invoice.Cashier)]                   = "invoice_cashier",
        [nameof(Invoice.CashierId)]                 = "invoice_cashier_id",
        [nameof(Invoice.Mode)]                      = "invoice_mode",
        [nameof(Invoice.Payment)]                   = "invoice_payment",
        [nameof(Invoice.Total)]                     = "invoice_total",
        [nameof(Invoice.Discount)]                  = "invoice_discount",
        [nameof(Invoice.WasCancelled)]              = "invoice_cancellation",
        [nameof(Invoice.Taxes)]                     = "taxes",
        [nameof(Invoice.TotalNet)]                  = "invoice_totalNet",
        [nameof(Invoice.TotalTax)]                  = "invoice_totalTax",
        [nameof(Invoice.Text)]                      = "invoice_text",
        [nameof(Invoice.IsReferencing)]             = "invoice_reference",
        [nameof(Invoice.IsSmallBusiness)]           = "invoice_small_business",
        [nameof(Invoice.IsDifferentialTaxation)]    = "invoice_differential_taxation",
        [nameof(Invoice.Currency)]                  = "invoice_currency",
        [nameof(Invoice.Company)]                   = "company",
        [nameof(Invoice.Items)]                     = "items",
        [nameof(Invoice.Customer)]                  = "customer",
        [nameof(Invoice.Signature)]                 = "signature",
        [nameof(Invoice.CancellationDetails)]       = "cancellation_details",
#endregion
#region Company
        [nameof(Company.Name)]                      = "name",
            // TODO: implement Naming convention for Company
#endregion // Company
#region Signature
            // TODO: implement Naming convention for Signature
#region Austria
            // TODO: implement Naming convention for Austrian Signature
#endregion // Austria
#region Germany
            // TODO: implement Naming convention for German Signature
#endregion // Germany
#endregion // Signature
#region CancellationDetails
          // TODO: implement Naming convention for Cancellation Details  
#endregion
#region User
        [nameof(User.Salutation)] = "user_salutation",
        [nameof(User.FirstName)] = "user_firstname",
        [nameof(User.Surname)] = "user_surname",
        [nameof(User.CompName)] = "user_company",
        [nameof(User.Email)] = "user_email",
        [nameof(User.Phone)] = "user_phoneNumber",
        [nameof(User.PostalCode)] = "user_postalCode",
        [nameof(User.City)] = "user_city",
        [nameof(User.Street)] = "user_street",
        [nameof(User.HouseNumber)] = "user_houseNumber",
        [nameof(User.Birthday)] = "user_birthday",
        [nameof(User.UidNumber)] = "user_uidNumber",
        [nameof(User.Notes)] = "user_notes",

#endregion // User

#region Article

        [nameof(Article.Name)] = "item_name",
        [nameof(Article.Stock)] = "item_quantity",
        [nameof(Article.GrossSellingPrice)] = "item_price",
        [nameof(Article.TaxRate)] = "item_taxRate",
        [nameof(Article.ItemDiscountUnit)] = "item_discount_unit",
        [nameof(Article.ItemDiscountUnitValue)] = "item_discount_value",

#endregion // Article
    };

    public override string ConvertName(string name) {
        return _nameMapping.GetValueOrDefault(name, name);
    }
}