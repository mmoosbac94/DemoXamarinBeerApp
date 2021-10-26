using System;
using System.Collections.Generic;
using BeerApp.Core.Models;

namespace BeerApp.Core.ViewModels.Main
{
    public partial class MainViewModel
    {
        private List<Beer> _beerList;
        public List<Beer> BeerList
        {
            get => _beerList;
            set
            {
                _beerList = value;
                RaisePropertyChanged(() => BeerList);
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                RaisePropertyChanged(() => IsLoading);
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                RaisePropertyChanged(() => ErrorMessage);
            }
        }

    }
}
