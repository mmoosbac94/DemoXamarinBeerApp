using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BeerApp.Core.Models;
using System.Text.Json;
using System.Diagnostics;
using Android.Util;

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

            HttpResponseMessage httpResponseMessage = await _client.GetAsync(uri);
                
            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            List<Beer> beerList = JsonSerializer.Deserialize<List<Beer>>(content);

            return beerList;
        }

    }
}
