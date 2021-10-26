using System;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using BeerApp.Core.ViewModels.BeerDetails;
using BeerApp.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace BeerApp.Droid.Views.BeerDetails
{

    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame,  AddToBackStack = true)]
    [Register(nameof(BeerDetailsFragment))]
    public class BeerDetailsFragment : BaseFragment<BeerDetailsViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_beer_details;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            View mainView = base.OnCreateView(inflater, container, savedInstanceState);

            return mainView;

        }
    }
}
