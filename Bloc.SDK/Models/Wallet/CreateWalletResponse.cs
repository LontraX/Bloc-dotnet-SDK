using Bloc.SDK.Models.SharedModels;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace Bloc.SDK.Models.Wallet
{
    public record CreateWalletResponse:BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public Data? Data { get; set; }
    }

    public class Data
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

    public class Customer
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonProperty("kyc_tier")]
        [JsonPropertyName("kyc_tier")]
        public string? KycTier { get; set; }

        [JsonProperty("phone_number")]
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("customer_type")]
        [JsonPropertyName("customer_type")]
        public string? CustomerType { get; set; }

        [JsonProperty("bvn")]
        [JsonPropertyName("bvn")]
        public string? Bvn { get; set; }
    }
}
