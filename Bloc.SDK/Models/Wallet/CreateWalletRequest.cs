using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace Bloc.SDK.Models.Wallet
{
    public class CreateWalletRequest
    {
        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("preferred_bank")]
        [JsonPropertyName("preferred_bank")]
        public string? PreferredBank { get; set; }

        [JsonProperty("alias")]
        [JsonPropertyName("alias")]
        public string? Alias { get; set; }
    }
}
