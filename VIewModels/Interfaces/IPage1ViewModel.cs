using System;
using System.Windows.Input;

namespace VIewModels.Interfaces
{
    public interface IPage1ViewModel
    {
        ICommand NavigateToPage2Command { get; }
    }
}
