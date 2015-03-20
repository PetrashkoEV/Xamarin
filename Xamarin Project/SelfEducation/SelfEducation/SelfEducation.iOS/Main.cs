using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business;
using UIKit;

namespace SelfEducation.iOS
{
    public class Application
    {
        public static Application Instance { get; private set; }

        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            SetLocatorProvider();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }

        static void SetLocatorProvider()
        {
            var locator = new DefaultServiceLocator(new IosInjectModule());
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}