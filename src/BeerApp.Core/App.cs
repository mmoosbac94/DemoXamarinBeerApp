using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyDemoApp.Core;

namespace BeerApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterCustomAppStart<CustomAppStart>();
        }
    }
}
