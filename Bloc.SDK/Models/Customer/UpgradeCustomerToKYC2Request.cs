using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Customer
{
    public class UpgradeCustomerToKYC2Request
    {
        [JsonProperty("means_of_id")]
        public string? MeansOfId { get; set; }

        [JsonProperty("image")]
        public string? Image { get; set; }
    }
}

