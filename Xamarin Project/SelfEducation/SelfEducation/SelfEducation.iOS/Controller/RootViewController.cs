﻿using System;
using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business.Private;
using UIKit;

namespace SelfEducation.iOS.Controller
{
    public partial class RootViewController : UIViewController
    {
        private readonly ILogInService _logInService = ServiceLocator.Current.GetInstance<ILogInService>();

        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            LogInButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                var login = logInText.Text;
                var pass = PasswordText.Text;
            };
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}