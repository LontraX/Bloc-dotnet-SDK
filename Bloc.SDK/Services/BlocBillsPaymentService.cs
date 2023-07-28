using Bloc.SDK.Extensions;
using Bloc.SDK.Interfaces;
using Bloc.SDK.Models.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Services
{
    public partial class BlocService : IBillsPaymentService
    {
        public Task<CustomerValidationResponse> CustomerValidation(string operatorID, string bill, string deviceNumber, string meterNumber)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfOperatorsProductsResponse> GetListOfOperatorProducts(string operatorID, string bill)
        {
            throw new NotImplementedException();
        }

        public async Task<SupportedBillsResponse> GetSupportedBills()
        {
            return await _httpClient.GetAndReadAsync<SupportedBillsResponse>(_endpoint.GetSupportedBills());
        }

        public async Task<SupportedOperatorsResponse> GetSupportedOperators(string bill)
        {
            return await _httpClient.GetAndReadAsync<SupportedOperatorsResponse>(_endpoint.GetSupportedOperators(bill));
        }

        public Task<MakeBillPaymentResponse> MakeBillPayment(MakeBillPaymentRequest billPaymentRequest)
        {
            throw new NotImplementedException();
        }
    }
}
