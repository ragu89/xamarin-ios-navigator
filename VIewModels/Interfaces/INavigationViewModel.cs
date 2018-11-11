using System;
using System.Threading.Tasks;
using ServiceContracts;

namespace VIewModels.Interfaces
{
    public interface INavigationViewModel
    {
        PageEnum CurrentPage { get; }
        Task NavigateAsync(PageEnum page, object parameter = null);
    }
}
