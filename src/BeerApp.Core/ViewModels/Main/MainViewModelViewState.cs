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

        private bool _showErrorMessage;
        public bool ShowErrorMessage
        {
            get => _showErrorMessage;
            set
            {
                _showErrorMessage = value;
                RaisePropertyChanged(() => ShowErrorMessage);
            }
        }






        private string _test;
        public string Test
        {
            get => _test;
            set
            {
                _test = value;
                RaisePropertyChanged(() => Test);
            }
        }

    }
}
