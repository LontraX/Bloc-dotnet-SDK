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
    public record MakeBillPaymentResponse:BlocAPIResponse
    {
        [JsonProperty("data")]
        [JsonPropertyName("data")]
        public PaymentData? Data { get; set; }
    }

    public class PaymentData
    {
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonProperty("reference")]
        [JsonPropertyName("reference")]
        public string? Reference { get; set; }

        [JsonProperty("customer_name")]
        [JsonPropertyName("customer_name")]
        public string? CustomerName { get; set; }

        [JsonProperty("operator_id")]
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public string? ProductId { get; set; }

        [JsonProperty("bill_type")]
        [JsonPropertyName("bill_type")]
        public string? BillType { get; set; }

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public MetaData? MetaData { get; set; }
    }

    public class MetaData
    {
        [JsonProperty("operator_name")]
        [JsonPropertyName("operator_name")]
        public string? OperatorName { get; set; }

        [JsonProperty("token")]
        [JsonPropertyName("token")]
        public string? Token { get; set; }
    }
}
