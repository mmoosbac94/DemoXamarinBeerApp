using System;
using BeerApp.Core.Actions;
using BeerApp.Core.States;
using Redux;

namespace BeerApp.Core.Reducer
{
    public static class MainReducer
    {

        public static DataState Execute(DataState dataState, IAction action)
        {
            if (action is LoadingFoodParingBeerDataAction)
            {
                return new DataState(isLoading: true);
            }

            if (action is FoodParingBeerDataErrorAction)
            {
                return new DataState(anErrorOccurred: true);
            }

            if (action is FoodParingBeerDataSuccessAction action1)
            {
                return new DataState(loadedBeerList: action1.Beers);
            }


            return dataState;
        }


        //TODO: Welche Actions / States werden benötigt?
        // FoodParingBeerDataSuccessAction vs. FetchFoodParingBeerDataAction

        //TODO: Wird FetchFoodParingBeerDataAction überhaupt benötigt
        //oder kann man sich diese Action + Creator sparen?

        //TODO: Wozu dienen MvxInteractions?

        //TODO: Wozu dient Android View Presenter (MVVM Cross)
    }
}
