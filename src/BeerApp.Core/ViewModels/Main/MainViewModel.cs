using System.Reactive.Linq;
using System.Windows.Input;
using BeerApp.Core.ActionCreators;
using MvvmCross.Commands;
using System;
using Android.Util;
using MvvmCross.Navigation;
using System.Threading.Tasks;
using BeerApp.Core.ViewModels.BeerDetails;
using BeerApp.Core.States;
using BeerApp.Core.Models;

namespace BeerApp.Core.ViewModels.Main
{
    public partial class MainViewModel : BaseViewModel
    {

        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

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

        private MvxCommand<Beer> _navigateToBeerDetailsCommand;
        public MvxCommand<Beer> NavigateToBeerDetailsCommand => _navigateToBeerDetailsCommand ??=
            new MvxCommand<Beer>(async (value) => await OnNavigateToBeerDetailsAsync(value));



        public void GetFoodParingBeerDataAsync(string food)
        {
            StoreHolder.Instance.DataStore.Dispatch(FetchFoodParingBeerDataActionCreator.FetchFoodParingBeerData(food));
        }

        protected override void RegisterAtStore()
        {
            _storeSubscription = StoreHolder.Instance.DataStore
                .DistinctUntilChanged(dataState => new
                {
                    dataState.ErrorMessage,
                    dataState.IsLoading,
                    dataState.LoadedBeerList
                })
                .Subscribe(dataState =>
                {
                    IsLoading = dataState.IsLoading;
                    BeerList = dataState.LoadedBeerList;

                    if (dataState.ErrorMessage != null)
                    {
                        //TODO: SHOW ERROR MESSAGE
                        ErrorMessage = dataState.ErrorMessage;
                    }
                }

                );
        }

        public async Task OnNavigateToBeerDetailsAsync(Beer beer)
        {
            await _navigationService.Navigate<BeerDetailsViewModel, object>(beer);
        }

        protected override void DisposeSubscriptions()
        {
            _storeSubscription.Dispose();
        }

        protected override void InitDefaultValues()
        {

        }

        public override void Prepare(object parameter)
        {

        }
    }
}
