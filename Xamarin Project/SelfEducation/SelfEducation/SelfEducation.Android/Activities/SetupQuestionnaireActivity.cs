using Android.App;
using Android.OS;
using Android.Widget;

namespace SelfEducation.Android.Activities
{
    [Activity(Label = "@string/logIn")]
    public class SetupQuestionnaireActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.SetupQuestionnaire);

            var textViewEmail = FindViewById<TextView>(Resource.Id.textViewEnterEmails);

            // Create your application here
            var email = Intent.Extras.GetString("login_email") ?? "";
            var pass = Intent.Extras.GetString("pass_email") ?? "";

            textViewEmail.Text = email + " - " + pass;
        }
    }
}