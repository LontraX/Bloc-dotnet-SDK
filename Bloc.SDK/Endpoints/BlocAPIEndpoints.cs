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
            throw new NotImplementedException();
        }

        public string CreateCustomers()
        {
            throw new NotImplementedException();
        }

        public string CreateFixedAccounts()
        {
            throw new NotImplementedException();
        }

        public string CreateWallet()
        {
            throw new NotImplementedException();
        }

        public string CustomerDeviceValidation(string operatorID)
        {
            
            return $"/{_apiVersion}/bills/customer/validate/{operatorID}";
        }

        public string GetAccountbyAccountNumber()
        {
            throw new NotImplementedException();
        }

        public string GetAccountById()
        {
            throw new NotImplementedException();
        }

        public string GetAccounts()
        {
            throw new NotImplementedException();
        }

        public string GetCustomerAccounts()
        {
            throw new NotImplementedException();
        }

        public string GetCustomerById()
        {
            throw new NotImplementedException();
        }

        public string GetCustomers()
        {
            throw new NotImplementedException();
        }

        public string GetCustomerWallets()
        {
            throw new NotImplementedException();
        }

        public string GetOperatorProducts(string operatorID)
        {
            
            return $"/{_apiVersion}/bills/operators/{operatorID}/products";
        }

        public string GetSupportedBills()
        {
            
            return $"/{_apiVersion}/bills/supported";
        }

        public string GetSupportedOperators()
        {
            
            return $"/{_apiVersion}/bills/operators";
        }

        public string GetWalletById()
        {
            throw new NotImplementedException();
        }

        public string GetWallets()
        {
            throw new NotImplementedException();
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

        public string UpgradeCustomerToKYCT1()
        {
            throw new NotImplementedException();
        }

        public string UpgradeCustomerToKYCT2()
        {
            throw new NotImplementedException();
        }

        public string UpgradeCustomerToKYCT3()
        {
            throw new NotImplementedException();
        }
    }
}
