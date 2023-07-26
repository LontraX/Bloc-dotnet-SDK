using Bloc.SDK.Extensions;
using Bloc.SDK.Interfaces;
using Bloc.SDK.Models.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Services
{
    public partial class BlocService : IWalletService
    {
        public async Task<CreateWalletResponse> CreateWallet(CreateWalletRequest createWalletRequest)
        {
            return await _httpClient.PostAndReadAsAsync<CreateWalletResponse>(_endpoint.CreateWallet(),createWalletRequest);
        }

        public Task GetAllWallets()
        {
            throw new NotImplementedException();
        }

        public Task GetCustomerWallets(string customerID)
        {
            throw new NotImplementedException();
        }

        public Task GetWalletById(string walletID)
        {
            throw new NotImplementedException();
        }
    }
}
