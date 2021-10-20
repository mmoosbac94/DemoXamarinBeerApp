using Foundation;
using MvvmCross.Platforms.Ios.Core;
using BeerApp.Core;

namespace BeerApp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
