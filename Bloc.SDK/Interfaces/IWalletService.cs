using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    /// <summary>
    /// Wallets provide a simple way to show your customers their balances with your organization.
    /// With wallets, you don't need to submit the KYC details of your customer. 
    /// All the funds received from all customers are held in your Main Balance 
    /// and you use the Wallet API to create wallets that show customers how much they have with you.
    /// With wallets, you can provide alternative ways of funding beyond just bank transfers.Other methods such as Crypto, Card, Direct Debit, etc could also work.
    /// </summary>
    public interface IWalletService
    {
        /// <summary>
        ///     All wallets must be owned by a customer.
        ///     To create a wallet, use this method and pass the customerID as a parameter.
        /// </summary>
        /// <param name="customerID">This is the unique id of the customer you want to create a wallet for.</param>
        /// <returns></returns>
        Task CreateWallet(string customerID);

        /// <summary>
        ///    Gets the details of a particular wallet,
        /// </summary>
        /// <param name="walletID">This is the unique id of the wallet you want to view.</param>
        /// <returns></returns>
        Task GetWalletById(string walletID);


        /// <summary>
        ///   Gets the details of all the wallets created by your organization
        /// </summary>
        /// <returns></returns>
        Task GetAllWallets();

        /// <summary>
        ///   Gets all wallets associated with a customer
        /// </summary>
        /// <param name="customerID">This is the unique id of the customer.</param>
        /// <returns></returns>
        Task GetCustomerWallets(string customerID);
    }
}
