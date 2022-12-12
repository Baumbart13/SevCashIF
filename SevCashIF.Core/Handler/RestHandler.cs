using Newtonsoft.Json;

namespace SevCashIF.Core.Handler;

public abstract class RestHandler {
    protected static HttpClient _httpClient;
    protected Queue<DateTime> Accesses = new Queue<DateTime>();
    protected abstract JsonConverter Converter();
}