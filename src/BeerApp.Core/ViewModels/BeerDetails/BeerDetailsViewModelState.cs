using System;
using System.Collections.Generic;
using BeerApp.Core.Models;

namespace BeerApp.Core.ViewModels.BeerDetails
{
    public partial class BeerDetailsViewModel
    {
        private string _beerName;
        public string BeerName
        {
            get => _beerName;
            set
            {
                _beerName = value;
                RaisePropertyChanged(() => BeerName);
            }
        }

        private string _beerURL;
        public string BeerURL
        {
            get => _beerURL;
            set
            {
                _beerURL = value;
                RaisePropertyChanged(() => BeerURL);
            }
        }

        private List<FoodPair> _foodPairing;
        public List<FoodPair> FoodPairing
        {
            get => _foodPairing;
            set
            {
                _foodPairing = value;
                RaisePropertyChanged(() => FoodPairing);
            }
        }
    }
}
