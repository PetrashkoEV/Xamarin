using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace SelfEducation.Android.Activities
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);


            var logInButton = FindViewById<Button>(Resource.Id.LogIn);

            var emailTextView = FindViewById<TextView>(Resource.Id.editTextEmail);
            var passTextView = FindViewById<TextView>(Resource.Id.editTextPass);

            logInButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(SetupQuestionnaireActivity));
                intent.PutExtra("login_email", emailTextView.Text);
                intent.PutExtra("pass_email", passTextView.Text);
                StartActivity(intent);
            };
        }
    }
}

