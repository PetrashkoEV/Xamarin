using Android.App;
using Android.Support.V4.App;
using Android.Support.V4.Widget;

namespace SelfEducation.Droid
{
    public class MyActionBarDrawerToggle : ActionBarDrawerToggle
    {
        private readonly Activity _mActivity;

        public MyActionBarDrawerToggle(Activity activity, DrawerLayout drawerLayout, int imageResource, int openDrawerDesc, int closeDrawerDesc)
            : base(activity, drawerLayout, imageResource, openDrawerDesc, closeDrawerDesc)
        {
            _mActivity = activity;
        }

        public override void OnDrawerOpened(Android.Views.View drawerView)
        {
            //Left Drawer
            base.OnDrawerOpened(drawerView);
            _mActivity.ActionBar.Title = "Please Select From List";
        }

        public override void OnDrawerClosed(Android.Views.View drawerView)
        {
            //Left Drawer
            base.OnDrawerClosed(drawerView);
            _mActivity.ActionBar.Title = "Drawer Layout App";
        }
    }
}