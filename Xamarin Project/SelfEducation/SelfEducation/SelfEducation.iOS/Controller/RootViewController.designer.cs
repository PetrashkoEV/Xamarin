// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SelfEducation.iOS.Controller
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LogInButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField logInText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PasswordText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LogInButton != null) {
				LogInButton.Dispose ();
				LogInButton = null;
			}
			if (logInText != null) {
				logInText.Dispose ();
				logInText = null;
			}
			if (PasswordText != null) {
				PasswordText.Dispose ();
				PasswordText = null;
			}
		}
	}
}
