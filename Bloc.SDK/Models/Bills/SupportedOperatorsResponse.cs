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
    public record SupportedOperatorsResponse:BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public List<Datum>? Data { get; set; }
    }

    public class Datum
    {
        [JsonProperty("desc")]
        [JsonPropertyName("desc")]
        public string? Desc;

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string? Name;

        [JsonProperty("sector")]
        [JsonPropertyName("sector")]
        public string? Sector;
    }
}
