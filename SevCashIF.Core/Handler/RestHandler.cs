using System.Text.Json.Nodes;

namespace SevCashIF.Core;

public interface RestHandler
{
    public abstract string BaseApi();
    protected static HttpClient hc = new HttpClient();
}