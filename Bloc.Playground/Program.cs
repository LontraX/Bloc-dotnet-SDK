
using Bloc.SDK;
using Bloc.SDK.Models.Customer;
using Bloc.SDK.Services;






// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var setting = new settings { ApiKey = "", ApiVersion= "1.0", BaseDomain = "" };
var _blocService = new BlocService(new BlocOptions { ApiKey = "sk_test_64bc8b16d8fd001b7e405e4f64bc8b16d8fd001b7e405e50", ApiVersion = "v1", BaseDomain = "https://api.blochq.io/" });
var request = new CreateCustomerRequest { CustomerType = "Personal", Bvn = "00000000000", Email = "ayooladeji@abc.xyz", FirstName = "Ayo", LastName = "Oladeji", PhoneNumber = "08012345678" };
var response = await _blocService.Customer.CreateCustomer(request);
Console.WriteLine(response.Message);
var ss = response;