using Bloc.SDK.Models.SharedModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Bills
{
    public record CustomerValidationResponse:BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public Data? Data { get; set; }
    }
    public class Data
    {
        [JsonProperty("address")]
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonProperty("payment_reference")]
        [JsonPropertyName("payment_reference")]
        public string? PaymentReference { get; set; }
    }
}
