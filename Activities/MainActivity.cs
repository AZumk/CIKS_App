using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using CIKS;

namespace App_CIKS.Activities
{
    [Activity( MainLauncher = false, Theme = "@android:style/Theme.DeviceDefault.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var showFour = FindViewById<Button>(Resource.Id.bot_inscrever_se);
            showFour.Click += (sender, e) =>
            {

                var four = new Intent(this, typeof(CadastroActivity));
                StartActivity(four);
            };
            var showThird = FindViewById<Button>(Resource.Id.bot_entrar);
            showThird.Click += (sender, e) =>
            {

                var third = new Intent(this, typeof(LoginActivity));
                StartActivity(third);
            };
        }
    }
}

