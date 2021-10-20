using System;
using System.Collections.Generic;
using BeerApp.Core.Models;

namespace BeerApp.Core.States
{
    public class DataState
    {
        public bool IsLoading { get; }
        public List<Beer> LoadedBeerList { get; }
        public bool AnErrorOccurred { get; }


        public DataState(
            bool isLoading = false,
            List<Beer> loadedBeerList = null,
            bool anErrorOccurred = false
        )
        {
            IsLoading = isLoading;
            LoadedBeerList = loadedBeerList;
            AnErrorOccurred = anErrorOccurred;
            
        }
    }
}
