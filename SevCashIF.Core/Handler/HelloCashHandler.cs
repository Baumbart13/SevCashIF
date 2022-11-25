using System.Numerics;
using SevCashIF.Core.Models;

namespace SevCashIF.Core.Handler;

public class HelloCashHandler : RestHandler {
    private static readonly Uri BaseAddress = new Uri("https://api.hellocash.business/api/v1/");
    public static string AuthToken { get; set; } = string.Empty;

    protected static HttpClient HttpClient {
        get {
            if (_httpClient == null) {
                HttpClient = new HttpClient();
                return _httpClient;
            }

            if (!_httpClient.BaseAddress.Equals(BaseAddress)) {
                _httpClient.BaseAddress = BaseAddress;
            }

            if (!_httpClient.DefaultRequestHeaders.Contains("authorization")) {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", AuthToken);
            }

            return _httpClient;
        }

        set {
            _httpClient = value;
            _httpClient.BaseAddress = new Uri("https://api.hellocash.business/api/v1/");
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", AuthToken);
        }
    }

#region Get from API

    public Invoice GetInvoice(BigInteger systemId) {
        if (systemId < 0) {
            throw new ArgumentException("The system-ID cannot be less than zero");
        }
        
        // TODO: implement Json-Serialization successfully

        using var response = _httpClient.GetAsync($"{Invoice.ApiCommand}/{systemId}").Result;
        /*var invoice = new Invoice {
            SystemId = systemId,
            Timestamp = timestamp,
            Cashier = cashier,
            CashierId = cashierId,
            Mode = null,
            Payment = null,
            Total = 0,
            Company = company,
            Currency = currency,
            Discount = discount,
            WasCancelled = false,
            Taxes = null,
            TotalNet = 0,
            TotalTax = 0,
            InvoiceNumber = invoiceNumber,
            IsDifferentialTaxation = isDifferentialTaxation,
            IsReferencing = isReferencing,
            IsSmallBusiness = isSmallBusiness,
            Items = items
        };*/
        return new Invoice();
    }

#endregion // get from api

#region Send to API

#endregion
}