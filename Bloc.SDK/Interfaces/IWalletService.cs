﻿using Bloc.SDK.Models.Wallet;
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
        ///     To create a wallet, use this method.
        /// </summary>
        /// <returns></returns>
        Task<CreateWalletResponse> CreateWallet(CreateWalletRequest createWalletRequest);

        /// <summary>
        ///    Gets the details of a particular wallet,
        /// </summary>
        /// <param name="walletID">This is the unique id of the wallet you want to view.</param>
        /// <returns></returns>
        Task<GetWalletByIdResponse> GetWalletById(string walletID);


        /// <summary>
        ///   Gets the details of all the wallets created by your organization
        /// </summary>
        /// <returns></returns>
        Task<GetWalletsResponse> GetAllWallets();

        /// <summary>
        ///   Gets all wallets associated with a customer
        /// </summary>
        /// <param name="customerID">This is the unique id of the customer.</param>
        /// <returns></returns>
        Task<GetCustomerWalletsResponse> GetCustomerWallets(string customerID);
    }
}
