using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SelfEducation.Droid.Activities
{
    [Activity(Label = "@string/ApplicationName", NoHistory = true)]
    public class CreateAccountActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.CreateAccount);

            var logInButton = FindViewById<TextView>(Resource.Id.textLogIn);

            logInButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            var registeButton = FindViewById<Button>(Resource.Id.RegisterButton);
            registeButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SetupQuestionnaireActivity));
                StartActivity(intent);
            };
        }
    }
}