using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.SharedModels
{
    public record BlocAPIResponse
    {
        [JsonProperty("success")]
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        //[JsonProperty("data")]
        //[JsonPropertyName("data")]
        //public T? Data { get; set; }

        [JsonProperty("message")]
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
