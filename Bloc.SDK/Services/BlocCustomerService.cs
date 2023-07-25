using Bloc.SDK.Extensions;
using Bloc.SDK.Interfaces;
using Bloc.SDK.Models.Customer;

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

        public Task GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task GetCustomerByID()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
