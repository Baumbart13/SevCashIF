namespace SevCashIF.Core.Models; 

public class PaymentMethod : Entity {
    public string Name { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}