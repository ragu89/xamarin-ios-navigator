using System;
using System.Diagnostics;
using System.Linq;
using Navigator.Utils.Extensions;
using ServiceContracts;
using ServiceContracts.Interfaces;
using UIKit;

namespace Navigator.Services
{
    public class NavigationServiceIOS : INavigationService
    {
        readonly UIViewController rootViewController;

        public NavigationServiceIOS(UIApplicationDelegate applicationDelegate)
        {
            rootViewController = applicationDelegate.Window.RootViewController;
        }

        #region Public methods

        public bool NavigateToView(PageEnum pageEnum, object parameters = null)
        {
            Debug.Print($"The NavigationServiceIOS is asking to navigate to the page '{pageEnum}");

            UIViewController visibleViewController = VisibleViewController;
            bool hasNavigated = false;

            try
            {
                switch (pageEnum)
                {
                    case PageEnum.Page1:
                        break;
                    case PageEnum.Page2:
                        hasNavigated = visibleViewController.PerformSegueIfIs<ViewController>("showPage2Segue");
                        break;
                }

                Debug.Print($"Navigation success : {hasNavigated}");
                return hasNavigated;
            }
            catch(Exception e)
            {
                Debug.Print($"Error when trying to navigate to page {pageEnum} : {e}");
                return false;
            }
        }

        #endregion

        #region Private methods and getters

        UIViewController VisibleViewController => FindChildViewController(rootViewController);

        static UIViewController FindChildViewController(UIViewController parent)
        {
            if (parent.PresentedViewController == null)
            {
                if (parent is UINavigationController)
                {
                    return ((UINavigationController)parent).ViewControllers.LastOrDefault();
                }

                return parent;
            }

            return FindChildViewController(parent.PresentedViewController);
        }

        #endregion
    }
}
