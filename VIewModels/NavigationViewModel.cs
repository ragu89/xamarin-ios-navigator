using System;
using System.Diagnostics;
using ServiceContracts;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class NavigationViewModel : INavigationViewModel
    {
        PageEnum currentPage;

        public NavigationViewModel()
        {
        }

        public INavigationService NavigationService { get; set; }

        public PageEnum CurrentPage
        {
            get => currentPage;
            set { currentPage = value; }
        }

        public void Navigate(PageEnum page, object parameter = null)
        {
            if (NavigationService.NavigateToView(page))
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
