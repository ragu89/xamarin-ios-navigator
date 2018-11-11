using System;
using System.Diagnostics;
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

            this.NavigateToPage2Command = new RelayCommand(ExecuteNavigateToPage2Command);
        }

        void ExecuteNavigateToPage2Command()
        {
            Debug.Print("Executing Command to navigate to Page2");
            navigationService.NavigateToView(PageEnum.Page2);
        }

        public ICommand NavigateToPage2Command { get; }

    }
}
