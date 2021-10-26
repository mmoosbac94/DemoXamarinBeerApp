using System;
using System.Collections.Generic;
using BeerApp.Core.Models;

namespace BeerApp.Core.States
{
    public class DataState
    {
        public bool IsLoading { get; }
        public List<Beer> LoadedBeerList { get; }
        public Exception ErrorMessage { get; }


        public DataState(
            bool isLoading = false,
            List<Beer> loadedBeerList = null,
            Exception errorMessage = null
        )
        {
            IsLoading = isLoading;
            LoadedBeerList = loadedBeerList;
            ErrorMessage = errorMessage;
            
        }
    }
}
