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
        Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest createCustomerRequest);
        Task<GetCustomersResponse> GetAllCustomers();
        Task UpgradeCustomerToKYCT1();
        Task UpgradeCustomerToKYCT2();
        Task UpgradeCustomerToKYCT3();
        Task GetCustomerByID(string customerID);

        Task MeansOfIdentification();
        Task RevalidateCustomerKYC();
        Task UpdateCustomer();
        

    }
}
