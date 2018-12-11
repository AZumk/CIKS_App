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
using Android.Webkit;
using Java.Lang;
using App_CIKS.Activities;
using Android.Content.PM;

namespace CIKS.Activities
{
    [Activity(Label = "SplashgifActivity", MainLauncher = false,  NoHistory = true, Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class SplashgifActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Splash);

            // Get our button from the layout resource,
            // and attach an event to it

            var wv = FindViewById<WebView>(Resource.Id.mywebview);

            wv.LoadUrl("file:///android_asset/Splashgif.html");

            wv.SetWebViewClient(new MonkeyWebViewClient());
            // scrollbar stuff
          
        }

        class MonkeyWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;


            }


        }
    }
}