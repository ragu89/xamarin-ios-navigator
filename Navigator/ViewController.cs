using System;
using System.ComponentModel;
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

            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        public override void ViewDidUnload()
        {
            ViewModel.PropertyChanged -= ViewModel_PropertyChanged;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            resultLabel.Text = ViewModel.TextResult; // Initialize the UILabel by consulting the VM directly
        }

        IPage1ViewModel ViewModel => AppDelegate.Locator.Page1ViewModel;

        void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals(nameof(ViewModel.TextResult)))
            {
                resultLabel.Text = ViewModel.TextResult; // Each time the VM change the value of its property, we update the UILabel
            }
        }

        partial void NextButton_Click(NSObject sender)
        {
            Debug.Print("Next button clicked");
            ViewModel.NavigateToPage2Command.Execute(null);
        }

        partial void LoadData(NSObject sender)
        {
            Debug.Print("LoadData button clicked");
            ViewModel.LoadDataCommand.Execute(null);
        }
    }
}
