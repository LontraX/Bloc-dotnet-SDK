using Bloc.SDK.Endpoints;
using Bloc.SDK.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK.Services
{
    public partial class BlocService:IBlocService,IDisposable
    {
        private readonly IBlocAPIEndpoints _endpoint;
        private readonly HttpClient _httpClient;
        private bool _disposeHttpClient;


        [ActivatorUtilitiesConstructor]
        public BlocService(IOptions<BlocOptions> settings, HttpClient httpClient)
            :this(settings.Value,httpClient)
        {

        }
        public BlocService(BlocOptions settings, HttpClient? httpClient = null)
        {
            settings.Validate();
            if (httpClient == null)
            {
                _disposeHttpClient = true;
                _httpClient = new HttpClient();
            }
            else
            {
                _httpClient = httpClient;
            }

            _httpClient.BaseAddress = new Uri(settings.BaseDomain);
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {settings.ApiKey}");
            _endpoint = new BlocAPIEndpoints(settings.ApiVersion);
        }

        public IBillsPaymentService BillsPayment => this;

        public ICustomerService Customer => this;

        public ITransferService Transfer => this;

        public IVirtualAccountService VirtualAccount => this;

        public IWalletService Wallet => this;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_disposeHttpClient && _httpClient != null)
                {
                    _httpClient.Dispose();
                }
            }
        }
    }
}
