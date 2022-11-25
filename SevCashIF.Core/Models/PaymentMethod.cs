namespace SevCashIF.Core.Models;

public class PaymentMethod : Entity {
    public const string ApiAcommand = "paymentMethods";
    
    public string Name { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public decimal Amount { get; set; } = decimal.Zero;
}