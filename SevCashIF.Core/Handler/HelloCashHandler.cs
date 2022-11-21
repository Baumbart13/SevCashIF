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
}