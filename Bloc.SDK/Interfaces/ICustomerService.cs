using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    internal interface ICustomerService
    {
        Task GetAllCustomersAsync();
        Task GetCustomerByIDAsync();

        Task CreateCustomerAsync();
        Task UpdateCustomerAsync();
        Task DeleteCustomerAsync();

    }
}
