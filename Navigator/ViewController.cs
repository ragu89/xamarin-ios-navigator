using System;
using System.Diagnostics;
using Foundation;
using ServiceContracts;
using UIKit;
using VIewModels.Interfaces;

namespace Navigator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void NextButton_Click(NSObject sender)
        {
            Debug.Print("Next button clicked");
            AppDelegate.Locator.NavigationViewModel.Navigate(PageEnum.Page2);
        }
    }
}
