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
using Android.Content.PM;
using CIKS;
using CIKS.Activities;

namespace App_CIKS.Activities
{
    [Activity(Label = "Narrativa",  Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class NarrativaActivity : Activity
    {
        ImageButton voltarButton;
        ImageButton playButton;
        ImageButton ajudaButton;
        ImageButton LogoutButton;
        ImageButton sessaoButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Narrativa);
      
            voltarButton = FindViewById<ImageButton>(Resource.Id.btn_reg_back);
            playButton = FindViewById<ImageButton>(Resource.Id.playbtn);
            ajudaButton = FindViewById<ImageButton>(Resource.Id.ajudabtn);
            LogoutButton = FindViewById<ImageButton>(Resource.Id.logoutbtn);
            sessaoButton = FindViewById<ImageButton>(Resource.Id.sessaobtn);

            if (voltarButton != null)
            {
                voltarButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(MenuActivity));
                };
            }
            if (playButton != null)
            {
                playButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(VideoActivity));
                };
            }
            if (ajudaButton != null)
            {
                ajudaButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(AjudaActivity));
                };
            }
            if (LogoutButton != null)
            {
                LogoutButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(MainActivity));
                };
            }
            if (sessaoButton != null)
            {
                sessaoButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(UsersActivity));
                };
            }
        }
    }
}