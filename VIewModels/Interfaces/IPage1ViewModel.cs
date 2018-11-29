using System;
using System.ComponentModel;
using System.Windows.Input;

namespace VIewModels.Interfaces
{
    public interface IPage1ViewModel : INotifyPropertyChanged
    {
        ICommand NavigateToPage2Command { get; }
        ICommand LoadDataCommand { get; }
        string TextResult { get; }
    }
}
