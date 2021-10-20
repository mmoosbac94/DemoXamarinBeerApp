using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BeerApp.Core.Models;
using BeerApp.Core.Services;

namespace BeerApp.Core.Repositories
{

    public interface IBeerRepository
    {
        Task<List<Beer>> GetFoodParingBeerDataAsync(string food);
    }

    public class BeerRepository : IBeerRepository
    {

        private readonly IApiService _apiService;

        public BeerRepository(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<Beer>> GetFoodParingBeerDataAsync(string food)
        {
            return await _apiService.GetFoodParingBeerDataAsync(food);
           
        }
    }
}
