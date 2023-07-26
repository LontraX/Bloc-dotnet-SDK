using Bloc.SDK.Extensions;
using Bloc.SDK.Interfaces;
using Bloc.SDK.Models.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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

        public async Task<GetWalletsResponse> GetAllWallets()
        {
            return await _httpClient.GetFromJsonAsync<GetWalletsResponse>(_endpoint.GetWallets());
        }

        public Task GetCustomerWallets(string customerID)
        {
            throw new NotImplementedException();
        }

        public async Task<GetWalletByIdResponse> GetWalletById(string walletID)
        {
            return await _httpClient.GetAndReadAsync<GetWalletByIdResponse>(_endpoint.GetWalletById(walletID));
        }
    }
}
