using System;
using System.Collections.Generic;
using BeerApp.Core.Models;
using Redux;

namespace BeerApp.Core.Actions
{
    public class FoodParingBeerDataSuccessAction : IAction
    {
        public List<Beer> Beers { get; }

        public FoodParingBeerDataSuccessAction(List<Beer> beers)
        {
            Beers = beers;
        }
    }
}
