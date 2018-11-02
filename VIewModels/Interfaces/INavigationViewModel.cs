using System;
using ServiceContracts;

namespace VIewModels.Interfaces
{
    public interface INavigationViewModel
    {
        PageEnum CurrentPage { get; }
        void Navigate(PageEnum page, object parameter = null);
    }
}
