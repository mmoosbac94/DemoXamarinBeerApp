using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using BeerApp.Core;
using Serilog;
using Serilog.Extensions.Logging;
using MvvmCross.IoC;
using BeerApp.Core.Services;
using MvvmCross;
using BeerApp.Core.Repositories;

namespace BeerApp.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override void InitializeFirstChance(IMvxIoCProvider iocProvider)
        {
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IApiService, ApiService>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IBeerRepository, BeerRepository>();
            base.InitializeFirstChance(iocProvider);
        }

    }
}
