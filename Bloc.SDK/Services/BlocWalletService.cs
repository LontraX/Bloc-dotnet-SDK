using Bloc.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Services
{
    public partial class BlocService : IWalletService
    {
        public Task CreateWallet(string customerID)
        {
            throw new NotImplementedException();
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
