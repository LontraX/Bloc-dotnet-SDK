using Bloc.SDK.Models.SharedModels;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace Bloc.SDK.Models.Wallet
{
    public record GetWalletByIdResponse: BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public WalletbyIdData? Data { get; set; }
    }
    public class WalletbyIdData
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("account_number")]
        [JsonPropertyName("account_number")]
        public string? AccountNumber { get; set; }

        [JsonProperty("bank_name")]
        [JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        [JsonProperty("balance")]
        [JsonPropertyName("balance")]
        public int Balance { get; set; }

        [JsonProperty("customer")]
        [JsonPropertyName("customer")]
        public Customer? Customer { get; set; }
    }

}
