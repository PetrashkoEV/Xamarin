using System;
using Android.App;
using Android.Runtime;
using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business;

namespace SelfEducation.Android
{

    public class App : Application
    {
        public static Application Instance { get; private set; }

        public App(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Instance = this;
            var locator = new DefaultServiceLocator(new AndroidInjectModule());
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}