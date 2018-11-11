using System;
using System.Windows.Input;
using Mvvmicro;

namespace VIewModels.Interfaces
{
    public interface IPage1ViewModel
    {
        AsyncRelayCommand NavigateToPage2Command { get; }
    }
}
