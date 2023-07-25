using Newtonsoft.Json;
using System.Text.Json.Serialization;


namespace Bloc.SDK.Models.Customer
{
    public class CreateCustomerResponse
    {
        [JsonProperty("success")]
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public Data? Data { get; set; }

        [JsonProperty("message")]
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }

    public class Address
    {
        [JsonProperty("street")]
        [JsonPropertyName("street")]
        public string? Street { get; set; }
    }

    public class Data
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonProperty("full_name")]
        [JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        [JsonProperty("phone_number")]
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("organization_id")]
        [JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        [JsonProperty("environment")]
        [JsonPropertyName("environment")]
        public string? Environment { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonProperty("group")]
        [JsonPropertyName("group")]
        public string? Group { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("SyncData")]
        [JsonPropertyName("SyncData")]
        public SyncData SyncData { get; set; }

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("kyc_tier")]
        [JsonPropertyName("kyc_tier")]
        public string? KycTier { get; set; }

        [JsonProperty("bvn")]
        [JsonPropertyName("bvn")]
        public string? Bvn { get; set; }

        [JsonProperty("date_of_birth")]
        [JsonPropertyName("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("customer_type")]
        [JsonPropertyName("customer_type")]
        public string? CustomerType { get; set; }

        [JsonProperty("source")]
        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonProperty("address")]
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
    }

    public class SyncData
    {
        [JsonProperty("ID")]
        [JsonPropertyName("ID")]
        public string? ID { get; set; }

        [JsonProperty("Provider")]
        [JsonPropertyName("Provider")]
        public string? Provider { get; set; }
    }

}
