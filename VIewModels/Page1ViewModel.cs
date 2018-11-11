using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Mvvmicro;
using ServiceContracts;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class Page1ViewModel : IPage1ViewModel
    {
        private readonly INavigationViewModel navigationViewModel;

        public Page1ViewModel(INavigationViewModel navigationViewModel)
        {
            this.navigationViewModel = navigationViewModel;

            this.NavigateToPage2Command = new AsyncRelayCommand(ExecuteNavigateToPage2CommandAsync);
        }

        Task ExecuteNavigateToPage2CommandAsync(System.Threading.CancellationToken arg)
        {
            Debug.Print("Executing Command to navigate to Page2");
            return navigationViewModel.NavigateAsync(PageEnum.Page2);
        }

        public AsyncRelayCommand NavigateToPage2Command { get; }

    }
}
