using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    public interface IBlocService
    {
        public IBillsPaymentService BillsPayment { get; }
        public ICustomerService Customer { get; }
        public ITransferService Transfer { get; }
        public IVirtualAccountService VirtualAccount { get; }
        public IWalletService Wallet { get; }
    }
}
