using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Bills
{
    internal class MakePaymentRequest
    {
        /// <summary>
        ///     This is the amount to be paid. It should always be passed in kobo. 
        ///    You can do this by multiplying the NGN amount by 100.
        /// </summary>
        /// <seealso href="https://docs.blochq.io/docs/make-a-payment" />
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public int Amount { get; set; }


        /// <summary>
        ///     This is the unique id of the product being bought.
        /// </summary>
        /// <seealso href="https://docs.blochq.io/docs/make-a-payment" />
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public string? ProductId { get; set; }

        /// <summary>
        ///     This is the unique operator id of the service provider.
        /// </summary>
        /// <seealso href="https://docs.blochq.io/docs/make-a-payment" />
        [JsonProperty("operator_id")]
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }


        /// <summary>
        ///     You can leave this blank if you want to. 
        ///     However, if you want the amount to be debited from another fixed account created in your workspace, 
        ///     provide the account_id here.
        /// </summary>
        /// <seealso href="https://docs.blochq.io/docs/make-a-payment" />
        [JsonProperty("account_id")]
        [JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// Depending on the type of bill being paid, the required attributes differ.
        /// </summary>
        /// <seealso href="https://docs.blochq.io/docs/make-a-payment" />
        [JsonProperty("device_details")]
        [JsonPropertyName("device_details")]
        public DeviceDetails? DeviceDetails { get; set; }
    }

    public class DeviceDetails
    {
        /// <summary>
        /// This field represents the type of supported meter for the service. 
        /// The accepted values for this field are postpaid or prepaid
        /// </summary>
        [JsonProperty("meter_type")]
        [JsonPropertyName("meter_type")]
        public string? MeterType { get; set; }
        /// <summary>
        /// For Television: This field represents the unique identifier for the decoder. 
        /// This is mostly the decoder/smartcard number.
        ///                  
        /// For Electricity: This field represents the unique identifier for the selected meter type. 
        /// This is mostly the meter number.
        /// </summary>

        [JsonProperty("device_number")]
        [JsonPropertyName("device_number")]
        public string? DeviceNumber { get; set; }

        /// <summary>
        /// This field represents the phone number of the intended recipient.
        /// </summary>
        [JsonProperty("beneficiary_msisdn")]
        [JsonPropertyName("beneficiary_msisdn")]
        public string? BeneficiaryMsisdn { get; set; }
    }
}
