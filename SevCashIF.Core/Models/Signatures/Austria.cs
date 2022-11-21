namespace SevCashIF.Core.Models.Signatures;

public class Austria : ISignature {
    /// <summary>
    /// Signature (QR) Code
    /// </summary>
    public string SignatureCode { get; set; } = string.Empty;
    
    /// <summary>
    /// Signature text
    /// </summary>
    public string SignatureText { get; set; } = string.Empty;

    /// <summary>
    /// Cancellation signature (QR) code
    /// </summary>
    public string SignatureCancellationCode { get; set; } = string.Empty;

    /// <summary>
    /// Cancellation signature text
    /// </summary>
    public string SignatureCancellationText { get; set; } = string.Empty;
}