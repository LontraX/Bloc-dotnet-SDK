using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Models.Customer
{
    public class UpgradeCustomerToKYC1Request
    {
        public string? place_of_birth { get; set; }
        public DateTime dob { get; set; }
        public string? gender { get; set; }
        public string? country { get; set; }
        public CustomerAddress? address { get; set; }
        public string? image { get; set; }
    }

    public class CustomerAddress
    {
        public string? street { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? country { get; set; }
        public string? postal_code { get; set; }
    }
}
