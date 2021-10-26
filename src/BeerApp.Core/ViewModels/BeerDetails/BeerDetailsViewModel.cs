using System;
using System.Collections.Generic;
using System.Linq;
using Android.Util;
using BeerApp.Core.Models;

namespace BeerApp.Core.ViewModels.BeerDetails
{
    public partial class BeerDetailsViewModel : BaseViewModel
    {
        private Beer _beer;

        public override void Prepare(object parameter) {
            _beer = (Beer)parameter;
        }

        protected override void InitDefaultValues() {
            BeerName = _beer.Name;
            BeerURL = _beer.ImgURL;
            FoodPairing = mapFoodPairingStringsListToFoodPairingList(_beer.FoodPairing);
        }

        private List<FoodPair> mapFoodPairingStringsListToFoodPairingList(List<string> foodPairingStringsList)
        {
            return foodPairingStringsList.Select(foodPairString => new FoodPair(foodPairString)).ToList();
        }

        protected override void DisposeSubscriptions() { }
        protected override void RegisterAtStore() { }
    }
}