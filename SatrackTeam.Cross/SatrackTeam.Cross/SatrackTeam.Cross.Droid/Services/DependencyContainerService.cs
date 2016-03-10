
using Autofac;
using Autofac.Builder;
using SatrackTeam.Cross.Services;
using SatrackTeam.Infrastructure.Contracts;
using SatrackTeam.Infrastructure.Services;
using SatrackTeam.Logic.ViewModels;
using System;

#if WINDOWS_PHONE
using SatrackTeam.Cross.WinPhone.Services;
#elif __IOS__
using SatrackTeam.Cross.iOS.Services;
#endif

namespace SatrackTeam.Cross.Services
{
    public class DependencyContainerService : IDependencyContainerService
    {
        private static IContainer container;

        public DependencyContainerService()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DialogService>().As<IDialogService>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<ApiService>().As<IApiService>();
            builder.RegisterInstance(this).As<IDependencyContainerService>();
            builder.RegisterType<MainViewModel>().As<MainViewModel>().SingleInstance();
            container = builder.Build(ContainerBuildOptions.None);
        }
        public T Resolve<T>() where T : class
        {
            return container.Resolve<T>();
        }

    }
}