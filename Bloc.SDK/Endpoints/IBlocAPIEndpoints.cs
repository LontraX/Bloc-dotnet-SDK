using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Endpoints
{
    internal interface IBlocAPIEndpoints
    {
        // customers endpoints
        string CreateCustomers();
        string GetCustomers();

        string UpgradeCustomerToKYCT1();
        string UpgradeCustomerToKYCT2();
        string UpgradeCustomerToKYCT3();
        string UpdateCustomer();
        string GetCustomerById();
        string MeansofIdentification();

        string RevalidateCustomerKYC();


        // wallets endpoints
        string CreateWallet();
        string GetWallets();
        string GetWalletById();
        string GetCustomerWallets();







        // accounts endpoints
        string CreateFixedAccounts();
        string GetAccounts();
        string CreateCollectionAccount();
        string GetAccountById();
        string GetAccountbyAccountNumber();

        string GetCustomerAccounts();





        string GetSupportedBills();
        string GetSupportedOperators();
        string GetOperatorProducts();
        string CustomerDeviceValidation();
        string MakePayment();
    }
}
