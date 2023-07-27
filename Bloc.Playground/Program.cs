
using Bloc.SDK;
using Bloc.SDK.Models.Customer;
using Bloc.SDK.Models.Wallet;
using Bloc.SDK.Services;
using OpenAI.Managers;
using OpenAI;
using OpenAI.ObjectModels.RequestModels;








//var setting = new settings { ApiKey = "", ApiVersion= "1.0", BaseDomain = "" };
var _blocService = new BlocService(new BlocOptions { ApiKey = "sk_test_64bc8b16d8fd001b7e405e4f64bc8b16d8fd001b7e405e50", ApiVersion = "v1", BaseDomain = "https://api.blochq.io/" });
var request = new CreateCustomerRequest { CustomerType = "erson", Bvn = "00000000000", Email = "ayooladeji@abc.xyz", FirstName = "Ayo", LastName = "Oladeji", PhoneNumber = "08012345678" };
//var response = await _blocService.CreateCustomer(request);
//var response = await _blocService.GetAllCustomers();
//Console.WriteLine(response.Message);
//var ss = response;

//var rr = new CreateWalletRequest { Alias = "zari", CustomerId = "fgfgfgfg", PreferredBank = "corpus" };
//var createwallet = await _blocService.CreateWallet(rr);

//var ww = await _blocService.Wallet.GetAllWallets();

//var xx = await _blocService.Wallet.GetWalletById("6667777888888");

var bn = await _blocService.GetCustomerWallets("3333333333");
Console.WriteLine(bn.Message);


