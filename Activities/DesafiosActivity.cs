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
    [Activity(Label = "Desafios", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class DesafiosActivity : Activity
    {

        private ImageButton button_logout;
        private ImageButton button_session;
        private ImageButton button_ajuda;
        private ImageButton button_desafio1;
        private ImageButton button_desafio2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Desafios);

            button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
            button_session = FindViewById<ImageButton>(Resource.Id.button_session);
            button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);
            button_desafio1 = FindViewById<ImageButton>(Resource.Id.button_desafio1);
            button_desafio2 = FindViewById<ImageButton>(Resource.Id.button_desafio2);

            button_logout.Click += button_logout_Click;
            button_session.Click += button_session_Click;
            button_ajuda.Click += button_ajuda_Click;
            button_desafio1.Click += button_desafio1_Click;
            button_desafio2.Click += button_desafio2_Click;

        }

        private void button_desafio2_Click(object sender, EventArgs e)
        {
            var des2 = new Intent(this, typeof(Desafio2Activity));
            StartActivity(des2);
        }

        private void button_desafio1_Click(object sender, EventArgs e)
        {
            var des1 = new Intent(this, typeof(Desafio1Activity));
            StartActivity(des1);
        }

        //menu
        private void button_ajuda_Click(object sender, EventArgs e)
        {
            var ajuda = new Intent(this, typeof(AjudaActivity));
            StartActivity(ajuda);
        }

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
    }
}