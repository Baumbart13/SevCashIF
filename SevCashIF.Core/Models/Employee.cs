namespace SevCashIF.Core.Models;

public class Employee : User {
    /// <summary>
    /// Name of the emplyoee
    /// </summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Date when employee was last edited
    /// </summary>
    public DateTime UpdatedAt { get; set; }
}