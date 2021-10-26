using Android.App;
using Android.Views;
using BeerApp.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace BeerApp.Droid.Views.Main
{
    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    [MvxActivityPresentation]
    public class MainContainerActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;
    }
}
