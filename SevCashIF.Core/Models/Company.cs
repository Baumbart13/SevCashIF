namespace SevCashIF.Core.Models;

public class Company : Entity {
    public string Name { get; set; } = string.Empty;
    public Address Address { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string EMail { get; set; } = string.Empty;
    public Uri Website { get; set; } = new Uri(string.Empty);
    public User ContactPerson { get; set; }

    /// <summary>
    /// VAT-number
    /// </summary>
    public string CompanyRegister { get; set; } = string.Empty;

    public string TaxNumber { get; set; } = string.Empty;

    public string IBAN { get; set; } = string.Empty; // TODO: implement check for valid IBAN
    public string BIC { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
}