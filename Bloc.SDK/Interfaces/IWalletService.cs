using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    public interface IWalletService
    {
        Task CreateWallet();
        Task GetWalletById();
        Task GetAllWallets();
    }
}
