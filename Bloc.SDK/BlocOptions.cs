using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc.SDK
{
    public class BlocOptions
    {
        private const string BlocDefaultApiVersion = "v1";
        private const string BlocDefaultBaseDomain = "https://api.blochq.io/";


        /// <summary>
        ///     The Bloc API uses API keys for authentication. Visit your
        ///     <a href="https://docs.blochq.io/docs/quick-start">API Keys page</a> to retrieve the API key you'll use in
        ///     your requests.
        ///     Remember that your API key is a secret! Do not share it with others or expose it in any client-side code(browsers,
        ///     apps). Production requests must be routed through your own backend server where your API key can be securely loaded
        ///     from an environment variable or key management service.
        /// </summary>
        public string ApiKey { get; set; } = null!;

        public string Validate()
        {
            return string.Empty;
        }



    }
}
