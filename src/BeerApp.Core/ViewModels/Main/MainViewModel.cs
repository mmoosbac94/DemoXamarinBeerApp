﻿using System.Reactive.Linq;
using System.Windows.Input;
using BeerApp.Core.ActionCreators;
using MvvmCross.Commands;
using System;

namespace BeerApp.Core.ViewModels.Main
{
    public partial class MainViewModel : BaseViewModel
    {

        private IDisposable _storeSubscription;

        private ICommand _getFoodParingBeerData;
        public ICommand GetFoodParingBeerData
        {
            get
            {
                _getFoodParingBeerData ??= new MvxCommand<string>((food) => GetFoodParingBeerDataAsync(food));
                return _getFoodParingBeerData;
            }
        }

        public void GetFoodParingBeerDataAsync(string food)
        {
            StoreHolder.Instance.DataStore.Dispatch(FetchFoodParingBeerDataActionCreator.FetchFoodParingBeerData(food));
        }

        protected override void RegisterAtStore()
        {
            _storeSubscription = StoreHolder.Instance.DataStore
                .DistinctUntilChanged(dataState => new {
                    dataState.AnErrorOccurred,
                    dataState.IsLoading,
                    dataState.LoadedBeerList
                })
                .Subscribe(dataState =>
                {
                    if (dataState.IsLoading)
                    {
                        //TODO: SHOW PROGRESS INDICATOR
                    }

                    if (dataState.LoadedBeerList != null)
                    {
                        //TODO: SHOW LIST OF BEER
                    }

                    if (dataState.AnErrorOccurred)
                    {
                        //TODO: SHOW ERROR MESSAGE
                    }
                }

                );
        }

        protected override void DisposeSubscriptions()
        {
            _storeSubscription.Dispose();
        }

    }
}