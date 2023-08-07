using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Endpoints
{
    internal class BlocAPIEndpoints:IBlocAPIEndpoints
    {
        
        private readonly string _apiVersion;
        public BlocAPIEndpoints(string apiVersion)
        {
            _apiVersion = apiVersion;
        }

        public string CreateCollectionAccount()
        {
            return $"/{_apiVersion}/accounts/collections";
        }

        public string CreateCustomers()
        {
            return $"/{_apiVersion}/customers";
        }

        public string CreateFixedAccounts()
        {
            return $"/{_apiVersion}/accounts";
        }

        public string CreateWallet()
        {
            return $"/{_apiVersion}/wallets";
        }

        public string CustomerDeviceValidation(string operatorID)
        {
            
            return $"/{_apiVersion}/bills/customer/validate/{operatorID}";
        }

        public string GetAccountbyAccountNumber(string accountNumber)
        {
            return $"/{_apiVersion}/accounts/number/{accountNumber}";
        }

        public string GetAccountById(string accountID)
        {
            return $"/{_apiVersion}/accounts/{accountID}";
        }

        public string GetAccounts()
        {
            return $"{_apiVersion}/accounts";
        }

        public string GetCustomerAccounts()
        {
            throw new NotImplementedException();
        }

        public string GetCustomerById(string customerID)
        {
            return $"/{_apiVersion}/customers/{customerID}";
        }

        public string GetCustomers()
        {
            return $"/{_apiVersion}/customers";
        }

        public string GetCustomerWallets(string customerID)
        {
            return $"/{_apiVersion}/wallets/customers/{customerID}";
        }

        public string GetOperatorProducts(string operatorID)
        {
            
            return $"/{_apiVersion}/bills/operators/{operatorID}/products";
        }

        public string GetSupportedBills()
        {
            
            return $"/{_apiVersion}/bills/supported";
        }

        public string GetSupportedOperators(string bill)
        {
            
            return $"/{_apiVersion}/bills/operators?bill={System.Web.HttpUtility.UrlEncode(bill)}";
        }

        public string GetWalletById(string walletID)
        {
            return $"{_apiVersion}/wallets/{walletID}";
        }

        public string GetWallets()
        {
            return $"/{_apiVersion}/wallets";
        }

        public string MakePayment()
        {
            return $"/{_apiVersion}/bills/payment";
        }

        public string MeansofIdentification()
        {
            throw new NotImplementedException();
        }

        public string RevalidateCustomerKYC()
        {
            throw new NotImplementedException();
        }

        public string UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public string UpgradeCustomerToKYCT1(string customerID)
        {
            return $"/{_apiVersion}/customers/upgrade/t1/{customerID}";
        }

        public string UpgradeCustomerToKYCT2(string customerID)
        {
            return $"{_apiVersion}customers/upgrade/t1/{customerID}";
        }

        public string UpgradeCustomerToKYCT3(string customerID)
        {
            return $"{_apiVersion}customers/upgrade/t1/{customerID}";
        }
    }
}
