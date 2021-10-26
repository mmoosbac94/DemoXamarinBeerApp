using System;
using Redux;

namespace BeerApp.Core.Actions
{
    public class FoodParingBeerDataErrorAction : IAction
    {
        public Exception Exception { get; }

        public FoodParingBeerDataErrorAction(Exception exception)
        {
            Exception = exception;
        }
    }
}
