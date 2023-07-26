using Bloc.SDK.Models.SharedModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Customer
{
    public record GetCustomersResponse:BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public List<Datum>? Data { get; set; }

        [JsonProperty("metadata")]
        [JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("has_next")]
        [JsonPropertyName("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("has_previous")]
        [JsonPropertyName("has_previous")]
        public bool HasPrevious { get; set; }
    }

    public class Datum
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
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("SyncData")]
        [JsonPropertyName("SyncData")]
        public SyncData? SyncData { get; set; }

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

        [JsonProperty("place_of_birth")]
        [JsonPropertyName("place_of_birth")]
        public string? PlaceOfBirth { get; set; }

        [JsonProperty("gender")]
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        [JsonProperty("image_url")]
        [JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

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

        [JsonProperty("means_of_identity")]
        [JsonPropertyName("means_of_identity")]
        public string? MeansOfIdentity { get; set; }

        [JsonProperty("means_of_identity_url")]
        [JsonPropertyName("means_of_identity_url")]
        public string? MeansOfIdentityUrl { get; set; }
    }

}
