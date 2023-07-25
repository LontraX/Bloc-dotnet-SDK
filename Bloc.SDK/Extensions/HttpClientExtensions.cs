using Bloc.SDK.Models.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bloc.SDK.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<TResponse> PostFileAndReadAsAsync<TResponse>(this HttpClient client, string uri, HttpContent content)
        {
            var response = await client.PostAsync(uri, content);
            return await response.Content.ReadFromJsonAsync<TResponse>();
                //?? throw new BlocAPIExceptionResponse(message = response.Content.);
        }

        public static async Task<TResponse> PostAndReadAsAsync<TResponse>(this HttpClient client, string uri, object requestModel)
        {
            // Serialize the requestModel into JSON and create a StringContent to hold the JSON data
            var jsonRequest = JsonSerializer.Serialize(requestModel);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            // Perform the HTTP POST request
            var response = await client.PostAsync(uri, content);

            // Read the content of the response and deserialize it to the specified type TResponse
            var responseContent = await response.Content.ReadAsStringAsync();

            // If the response has content, deserialize it; otherwise, set the data to default(TResponse)
            return string.IsNullOrEmpty(responseContent) ? default : JsonSerializer.Deserialize<TResponse>(responseContent);
        }

    }
}
