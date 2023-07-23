using Bloc.SDK.Models.Bills;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    public interface IBillsPaymentService
    {
        /// <summary>
        ///     Use this to get the list of supported bills available on Bloc.
        /// </summary>
        /// <returns></returns>
        Task<SupportedBillsResponse> GetSupportedBills();

        /// <summary>
        ///     An operator refers to the service provider of the bill product you want to purchase. 
        ///     The list of operators returned depends on the bill payment product selected.
        ///     To get this, use this method and pass a value for the bill parameter.
        /// </summary>
        /// <param name="bill">The bill product you want to purchase e.g electricity</param>
        /// <returns></returns>
        Task<SupportedOperatorsResponse> GetSupportedOperators(string bill);

        /// <summary>
        ///     Returns the list of products offered by a particular operator.
        /// </summary>
        /// <param name="bill">This is the bill type that the service provider offers. It could either be telco, television or electricity.</param>
        /// <param name="operatorID">This is the unique operator id of the service provider</param>
        /// <returns></returns>
        Task<ListOfOperatorsProductsResponse> GetListOfOperatorProducts(string operatorID, string bill);

        /// <summary>
        ///     This is only required for Electricity and TV Subscription products that must verify that the customer exists before processing payment.
        /// </summary>
        /// <param name="bill">This is the bill type that the service provider offers. It could either be telco, television or electricity.</param>
        /// <param name="operatorID">This is the unique operator id of the service provider</param>
        /// <param name="deviceNumber">This is the device number (Electricity) or smart card number (TV subscription)</param>
        /// <param name="meterNumber">This is the type of meter, if it is an electricity payment. It is either prepaid or postpaid. Leave it blank if you are verifying for Television.</param>
        /// <returns></returns>
        Task<CustomerValidationResponse> CustomerValidation(string operatorID,string bill,string deviceNumber, string meterNumber);

        /// <summary>
        ///    Makes a Bills payment
        ///    Whenever you successfully pass a Bills Payment transaction, we deduct the amount from your Main Balance.
        ///    This means you always have to keep your Main Balance funded to continue to process Bills Payment transactions successfully.
        /// </summary>
        /// <param name="billPaymentRequest"></param>

        /// <returns></returns>
        Task<MakeBillPaymentResponse> MakeBillPayment(MakeBillPaymentRequest billPaymentRequest);
    }
}
