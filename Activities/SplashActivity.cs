using Android.App;
using Android.OS;
using System.Threading;
using Android.Content.PM;

namespace App_CIKS.Activities
{
    //Set MainLauncher = true makes this Activity Shown First on Running this Application  
    //Theme property set the Custom Theme for this Activity  
    //No History= true removes the Activity from BackStack when user navigates away from the Activity  
    [Activity(Label = " CIKS", MainLauncher = false, Theme = "@style/Theme.Splash", NoHistory = true, Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Display Splash Screen for 4 Sec  
            Thread.Sleep(10000);
            //Start Activity1 Activity  
            StartActivity(typeof(MainActivity));
        }
    }
}