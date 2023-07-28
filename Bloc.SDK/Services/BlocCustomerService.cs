using Bloc.SDK.Extensions;
using Bloc.SDK.Interfaces;
using Bloc.SDK.Models.Customer;
using System.Net.Http.Json;

namespace Bloc.SDK.Services
{
    public partial class BlocService : ICustomerService
    {
        public async Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest createCustomerRequest)
        {
            return await _httpClient.PostAndReadAsAsync<CreateCustomerResponse>(_endpoint.CreateCustomers(), createCustomerRequest);
        }

        public Task DeleteCustomer()
        {
            throw new NotImplementedException();
        }

        public async Task<GetCustomersResponse> GetAllCustomers()
        {
            return await _httpClient.GetAndReadAsync<GetCustomersResponse>(_endpoint.GetCustomers());

        }

        public Task GetCustomerByID(string customerID)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
