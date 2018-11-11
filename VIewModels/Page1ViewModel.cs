using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Mvvmicro;
using ServiceContracts;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class Page1ViewModel : IPage1ViewModel
    {
        private readonly INavigationService navigationService;

        public Page1ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            this.NavigateToPage2Command = new AsyncRelayCommand(ExecuteNavigateToPage2CommandAsync);
        }

        Task ExecuteNavigateToPage2CommandAsync(System.Threading.CancellationToken arg)
        {
            Debug.Print("Executing Command to navigate to Page2");
            navigationService.NavigateToView(PageEnum.Page2);

            return Task.Run(() => Task.Delay(0));
        }

        public AsyncRelayCommand NavigateToPage2Command { get; }

    }
}
