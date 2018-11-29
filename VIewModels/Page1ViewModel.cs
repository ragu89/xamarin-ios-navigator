using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Mvvmicro;
using ServiceContracts;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class Page1ViewModel :  Observable, IPage1ViewModel
    {
        private readonly INavigationService navigationService;
        private string textResult;

        public Page1ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            NavigateToPage2Command = new RelayCommand(ExecuteNavigateToPage2Command);
            LoadDataCommand = new AsyncRelayCommand(ExecuteLoadDataCommandAsync);
        }

        void ExecuteNavigateToPage2Command()
        {
            Debug.Print("Executing Command to navigate to Page2");
            navigationService.NavigateToView(PageEnum.Page2);
        }

        async Task ExecuteLoadDataCommandAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(2000);
            TextResult = $"Data loaded at {DateTime.Now}";
        }

        public ICommand NavigateToPage2Command { get; }
        public ICommand LoadDataCommand { get; }

        public string TextResult
        {
            get { return textResult ?? "Text not initialized"; }
            set { var foo = this.Set(ref textResult, value); }
        }
    }
}
