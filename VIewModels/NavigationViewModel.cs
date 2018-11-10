using System;
using System.Diagnostics;
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

        public void Navigate(PageEnum page, object parameter = null)
        {
            if (navigationService.NavigateToView(page))
            {
                CurrentPage = page;
            }
            else
            {
                Debug.Print($"Error when trying to navigate to the page {page}");
            }

        }
    }
}
