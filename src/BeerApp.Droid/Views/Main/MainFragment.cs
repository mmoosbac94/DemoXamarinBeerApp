using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using BeerApp.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace BeerApp.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, AddToBackStack = true)]
    [Register(nameof(MainFragment))]
    public class MainFragment : BaseFragment<MainViewModel>
    {

        protected override int FragmentLayoutId => Resource.Layout.fragment_main;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            View mainView = base.OnCreateView(inflater, container, savedInstanceState);

            SearchView searchBar = mainView.FindViewById<SearchView>(Resource.Id.search_bar_food);

            searchBar.QueryTextChange += delegate
            {
                ViewModel.GetFoodParingBeerData.Execute(searchBar.Query);
            };

            return mainView;

        }
    }

}
