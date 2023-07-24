using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Customer
{
    public class CreateCustomerRequest
    {
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonProperty("phone_number")]
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("bvn")]
        [JsonPropertyName("bvn")]
        public string? Bvn { get; set; }

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("customer_type")]
        [JsonPropertyName("customer_type")]
        public string? CustomerType { get; set; }

    }
}
