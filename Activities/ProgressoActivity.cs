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

namespace App_CIKS.Activities
{
    [Activity(Label = "CIKS",  Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class ProgressoActivity : Activity
    { 
         ImageButton voltarButton;
        ImageButton ajudaButton;
        ImageButton LogoutButton;
        ImageButton sessaoButton;
   
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Progresso);
            voltarButton = FindViewById<ImageButton>(Resource.Id.btn_reg_back);
            ajudaButton = FindViewById<ImageButton>(Resource.Id.ajudabtn);
            LogoutButton = FindViewById<ImageButton>(Resource.Id.logoutbtn);
            sessaoButton = FindViewById<ImageButton>(Resource.Id.sessaobtn);
            if (voltarButton != null)
            {
                voltarButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(PerfilPaiActivity));
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