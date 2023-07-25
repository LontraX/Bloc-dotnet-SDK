using Bloc.SDK.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Interfaces
{
    public interface ICustomerService
    {
        Task GetAllCustomers();
        Task GetCustomerByID(string customerID);

        Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest createCustomerRequest);
        Task UpdateCustomer();
        Task DeleteCustomer();

    }
}
