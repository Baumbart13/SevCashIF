using System.Numerics;

namespace SevCashIF.Core.Models;

public class User : Entity {
    public const string ApiCommand = "users";

    /// <summary>
    /// User's salutation, e.g. 'Mr.'
    /// </summary>
    public string Salutation { get; set; } = string.Empty;

    /// <summary>
    /// First/Given name
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Surname/Last name
    /// </summary>
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// User's company name
    /// </summary>
    public string CompName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public BigInteger PostalCode { get; set; }
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string HouseNumber { get; set; } = string.Empty;
    public DateOnly Birthday { get; set; }
    public BigInteger UidNumber { get; set; }

    public BigInteger VATNumber {
        get => UidNumber;
        set => UidNumber = value;
    }

    public string Notes { get; set; } = string.Empty;

    /// <summary>
    /// Consecutive user number. Required
    /// </summary>
    public BigInteger Number { get; set; }

    /// <summary>
    /// Creation time of the user
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// User's country as ISO 3166-1 alpha-2 code
    /// </summary>
    public string Country {
        get => _country;
        set {
            if (value.Length == 2) _country = value;
        }
    }
    private string _country = string.Empty;

    /// <summary>
    /// Custom field that have value for the user
    /// </summary>
    public Dictionary<string, string> CustomFields { get; set; }
}