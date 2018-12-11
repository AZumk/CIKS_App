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
using App_CIKS;
using App_CIKS.Activities;

namespace CIKS.Activities
{
    [Activity(Label = "ContRefUniverso", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class ContRefUniverso : Activity
    {
        private ImageButton button_logout;
        private ImageButton button_session;
        private ImageButton button_ajuda;

        private ImageButton button_unlockmod;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ContRefUniverso);
            // Create your application here

            button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
            button_session = FindViewById<ImageButton>(Resource.Id.button_session);
            button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);

            button_unlockmod = FindViewById<ImageButton>(Resource.Id.button_unlockmod);

            // menu principal
            button_logout.Click += button_logout_Click;
            button_session.Click += button_session_Click;
            button_ajuda.Click += button_ajuda_Click;

            button_unlockmod.Click += button_unlockmod_Click;

        }

        // menu principal
        private void button_logout_Click(object sender, EventArgs e)
        {
            var logout = new Intent(this, typeof(EditActivity));
            StartActivity(logout);
        }

        private void button_session_Click(object sender, EventArgs e)
        {
            var users = new Intent(this, typeof(UsersActivity));
            StartActivity(users);
        }

        private void button_ajuda_Click(object sender, EventArgs e)
        {
            var ajuda = new Intent(this, typeof(AjudaActivity));
            StartActivity(ajuda);
        }

        private void button_unlockmod_Click(object sender, EventArgs e)
        {
            var unlockmod = new Intent(this, typeof(CadastroModActivity));
            StartActivity(unlockmod);
        }
    }
}