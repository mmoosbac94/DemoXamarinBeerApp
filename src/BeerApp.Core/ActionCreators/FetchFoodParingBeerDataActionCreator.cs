using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Util;
using BeerApp.Core.Actions;
using BeerApp.Core.Models;
using BeerApp.Core.Repositories;
using BeerApp.Core.States;
using MvvmCross;
using Redux;
using Taiste.Redux;

namespace BeerApp.Core.ActionCreators
{
    public static class FetchFoodParingBeerDataActionCreator
    {
        public static IAction FetchFoodParingBeerData(string food)
        {

            IBeerRepository beerRepository = Mvx.IoCProvider.Resolve<IBeerRepository>();

            return new ThunkAction<DataState>((dispatch, getState) =>
            {
                var fetchBeerTask = Task.Run(() => beerRepository.GetFoodParingBeerDataAsync(food));
                dispatch(new LoadingFoodParingBeerDataAction());
                fetchBeerTask.ContinueWith((fetchBeerTask) =>
                {
                    if (fetchBeerTask.Exception != null)
                    {
                        dispatch(new FoodParingBeerDataErrorAction());
                        Log.Error("ERROR", "An error occurred while fetching beer data");
                    }
                    else if (fetchBeerTask.Result != null)
                    {
                        dispatch(new FoodParingBeerDataSuccessAction(fetchBeerTask.Result));
                    }
                });



                //TODO: Repository in IoCProvider registrieren und anschließend
                //  hier drauf zugreifen anstatt im MainViewModel?


            });
        }
    }
}
