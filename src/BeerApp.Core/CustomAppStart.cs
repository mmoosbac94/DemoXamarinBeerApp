using System.Threading.Tasks;
using BeerApp.Core.ViewModels.Main;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MyDemoApp.Core
{
    public class CustomAppStart : MvxAppStart
    {
        public CustomAppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<MainViewModel>();
        }
    }
}
