using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace BeerApp.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        protected abstract void RegisterAtStore();

        protected abstract void DisposeSubscriptions();

        protected abstract void InitDefaultValues();

        public override void ViewAppearing()
        {
            base.ViewAppearing();
            InitDefaultValues();
            RegisterAtStore();
            

        }

        public override void ViewDisappeared()
        {
            DisposeSubscriptions();
            base.ViewDisappeared();
        }
    }
}
