namespace SevCashIF.Core.Models.Signatures;

public class Germany : ISignature {
    /// <summary>
    /// QR code string
    /// </summary>
    public string TseQrCode { get; set; } = string.Empty;

    /// <summary>
    /// TSE transaction data
    /// </summary>
    public List<Int16> TseData { get; set; }

    /// <summary>
    /// QR code string of cancellation
    /// </summary>
    public string TseCancellationQrCode { get; set; } = string.Empty;

    /// <summary>
    /// TSE transaction data cancellation
    /// </summary>
    public List<Int16> TseCancellationData { get; set; }
}