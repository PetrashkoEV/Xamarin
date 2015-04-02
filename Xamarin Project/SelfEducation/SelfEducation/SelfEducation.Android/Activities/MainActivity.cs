using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Microsoft.Practices.ServiceLocation;
using SelfEducation.Business.Private;

namespace SelfEducation.Droid.Activities
{
    [Activity(Label = "@string/ApplicationName", NoHistory = true)]
    public class MainActivity : Activity
    {
        private readonly ILogInService _logInService = ServiceLocator.Current.GetInstance<ILogInService>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);


            var logInButton = FindViewById<Button>(Resource.Id.LogIn);

            var emailTextView = FindViewById<TextView>(Resource.Id.editTextEmail);
            var passTextView = FindViewById<TextView>(Resource.Id.editTextPass);

            logInButton.Click += (sender, e) =>
            {
                _logInService.ReturnNum(2);
                var intent = new Intent(this, typeof(SetupQuestionnaireActivity));
                intent.PutExtra("login_email", emailTextView.Text);
                intent.PutExtra("pass_email", passTextView.Text);
                StartActivity(intent);
            };
        }
    }
}

