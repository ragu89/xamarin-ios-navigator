using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ServiceContracts;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class NavigationViewModel : INavigationViewModel
    {
        private readonly INavigationService navigationService;
        PageEnum currentPage;

        public NavigationViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public PageEnum CurrentPage
        {
            get => currentPage;
            set { currentPage = value; }
        }

        public Task NavigateAsync(PageEnum page, object parameter = null)
        {
            Debug.Print($"NavigationViewModel is asking to navigate to the page '{page}'");

            if (navigationService.NavigateToView(page))
            {
                CurrentPage = page;
                Debug.Print($"Navigation success. The CurrentPage is now '{page}'");
            }
            else
            {
                Debug.Print($"Error when trying to navigate to the page {page}");
            }

            return Task.Run(() => Task.Delay(0));
        }
    }
}
