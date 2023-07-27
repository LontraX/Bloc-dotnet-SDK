using Bloc.SDK.Models.SharedModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Wallet
{
    public record GetCustomerWalletsResponse:BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public List<Datum>? Data { get; set; }

        [JsonProperty("metadata")]
        [JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

    }

}
