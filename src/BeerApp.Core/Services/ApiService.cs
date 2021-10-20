using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BeerApp.Core.Models;
using System.Text.Json;
using System.Diagnostics;

namespace BeerApp.Core.Services
{

    public interface IApiService
    {
        Task<List<Beer>> GetFoodParingBeerDataAsync(string food);
    }

    public class ApiService : IApiService
    {
        private readonly HttpClient _client;
        private readonly string _rootURL = "https://api.punkapi.com/v2/";

        public ApiService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Beer>> GetFoodParingBeerDataAsync(string food)
        {
            var uri = new Uri($"{_rootURL}beers?food={food}");
            var beerList = new List<Beer>();

            try
            {

                HttpResponseMessage httpResponseMessage = await _client.GetAsync(uri);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    var content = await httpResponseMessage.Content.ReadAsStringAsync();
                    beerList = JsonSerializer.Deserialize<List<Beer>>(content);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: ", ex.Message);
            }

            return beerList;
        }

    }
}
