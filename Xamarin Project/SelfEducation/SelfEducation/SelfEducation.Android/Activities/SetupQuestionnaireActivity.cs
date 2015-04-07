using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace SelfEducation.Droid.Activities
{
    [Activity(Label = "@string/logIn", NoHistory = true)]
    public class SetupQuestionnaireActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.SetupQuestionnaire);
            
            // Create your application here
            /*var email = Intent.Extras.GetString("login_email") ?? "";
            var pass = Intent.Extras.GetString("pass_email") ?? "";*/

            var nextStep = FindViewById<Button>(Resource.Id.Start);

            nextStep.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ActionScreenActivity));
                StartActivity(intent);
            };
        }
    }
}