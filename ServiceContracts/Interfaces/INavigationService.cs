using System;

namespace ServiceContracts.Interfaces
{
    public interface INavigationService
    {
        bool NavigateToView(PageEnum pageEnum, object parameters = null);
    }
}