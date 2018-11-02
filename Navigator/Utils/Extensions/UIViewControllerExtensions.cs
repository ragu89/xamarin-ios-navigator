using System;
using UIKit;

namespace Navigator.Utils.Extensions
{
    public static class UIViewControllerExtensions
    {
        public static void PerformSegue(this UIViewController viewController, string segue, UIViewController sender = null)
        {
            viewController?.PerformSegue(segue, sender ?? viewController);
        }

        public static bool PerformSegueIfIs<T>(this UIViewController viewController, string segue, UIViewController sender = null)
        {
            if (viewController is T)
            {
                viewController?.PerformSegue(segue, sender ?? viewController);
                return true;
            }

            return false;
        }

        public static bool PerformSegueIfIsOneOf<T1, T2>(this UIViewController viewController, string segue, UIViewController sender = null)
        {
            if (viewController is T1 ||
                viewController is T2)
            {
                viewController?.PerformSegue(segue, sender ?? viewController);
                return true;
            }

            return false;

        }
    }
}