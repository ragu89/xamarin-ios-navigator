using System;
using Mvvmicro;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var navigationService = Container.Default.Get<INavigationService>();

            RegisterViewModels(navigationService);
        }

        void RegisterViewModels(INavigationService navigationService)
        {
            Container.Default.Register<INavigationViewModel>((vm) => new NavigationViewModel(navigationService));
        }

        public INavigationViewModel NavigationViewModel => Container.Default.Get<INavigationViewModel>();
    }
}
