using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.SharedModels
{
    public class BlocAPIExceptionResponse:Exception
    {
        [JsonProperty("success")]
        [JsonPropertyName("success")]
        public bool Success { get; set; } = false;

        [JsonProperty("message")]
        [JsonPropertyName("message")]
        public string? ResponseMessage { get; set; }

        // Constructor to initialize the base Exception class with the response message
        public BlocAPIExceptionResponse(string message) : base(message)
        {
            
        }
    }
}
