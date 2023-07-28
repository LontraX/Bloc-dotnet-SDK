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
        string GetCustomerById(string customerID);
        string MeansofIdentification();

        string RevalidateCustomerKYC();


        // wallets endpoints
        string CreateWallet();
        string GetWallets();
        string GetWalletById(string walletID);
        string GetCustomerWallets(string customerID);







        // accounts endpoints
        string CreateFixedAccounts();
        string GetAccounts();
        string CreateCollectionAccount();
        string GetAccountById(string accountID);
        string GetAccountbyAccountNumber();

        string GetCustomerAccounts();





        string GetSupportedBills();
        string GetSupportedOperators(string bill);
        string GetOperatorProducts(string operatorID);
        string CustomerDeviceValidation(string operatorID);
        string MakePayment();
    }
}
