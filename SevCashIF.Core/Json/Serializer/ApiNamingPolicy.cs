using System.Text.Json;

namespace SevCashIF.Core.Json.Serializer; 

public abstract class ApiNamingPolicy : JsonNamingPolicy {
    protected abstract Dictionary<string, string> NameMapping();
    public override string ConvertName(string name) {
        return NameMapping().GetValueOrDefault(name, name);
    }
}