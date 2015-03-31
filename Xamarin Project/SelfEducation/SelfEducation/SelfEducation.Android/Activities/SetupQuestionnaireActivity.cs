using Android.App;
using Android.Content;
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

            // Create your application here
            /*var email = Intent.Extras.GetString("login_email") ?? "";
            var pass = Intent.Extras.GetString("pass_email") ?? "";*/

            var nextStep = FindViewById<Button>(Resource.Id.NextStep);

            RadioGroup radioGroup = FindViewById<RadioGroup>(Resource.Id.SelectDept);

            nextStep.Click += (sender, e) =>
            {
                var radioButton = FindViewById<RadioButton>(radioGroup.CheckedRadioButtonId);
                var intent = new Intent(this, typeof(ActionScreenActivity));
                //intent.PutExtra("login_email", q);
                StartActivity(intent);
            };
        }
    }
}