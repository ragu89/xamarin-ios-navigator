﻿using System;
using Mvvmicro;
using ServiceContracts.Interfaces;
using VIewModels.Interfaces;

namespace VIewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var navigationService = Container.Default.Get<INavigationService>();

            RegisterViewModels(navigationService);
        }

        void RegisterViewModels(INavigationService navigationService)
        {
            Container.Default.Register<IPage1ViewModel>((vm) => new Page1ViewModel(navigationService), true);
        }

        public IPage1ViewModel Page1ViewModel => Container.Default.Get<IPage1ViewModel>();
    }
}
