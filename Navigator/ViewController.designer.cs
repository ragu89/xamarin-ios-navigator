// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Navigator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel resultLabel { get; set; }

		[Action ("LoadData:")]
		partial void LoadData (Foundation.NSObject sender);

		[Action ("NextButton_Click:")]
		partial void NextButton_Click (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (resultLabel != null) {
				resultLabel.Dispose ();
				resultLabel = null;
			}
		}
	}
}
