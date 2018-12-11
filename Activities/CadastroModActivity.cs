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
    [Activity(Label = "CadastroModActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class CadastroModActivity : Activity
    {
        private ImageButton button_logout;
        private ImageButton button_session;
        private ImageButton button_ajuda;
        private ImageButton button_enviarchave;

        public bool moduloCadastrado = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CadastroMod);

            button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
            button_session = FindViewById<ImageButton>(Resource.Id.button_session);
            button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);
            button_enviarchave = FindViewById<ImageButton>(Resource.Id.button_enviarchave);

            button_logout.Click += button_logout_Click;
            button_session.Click += button_session_Click;
            button_ajuda.Click += button_ajuda_Click;
            button_enviarchave.Click += button_enviarchave_Click;

        }

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

        private void button_enviarchave_Click(object sender, EventArgs e)
        {
            var chave = FindViewById<EditText>(Resource.Id.chaveAcesso).Text;

            if (chave == "1234567890")
            {
                moduloCadastrado = true;
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Sucesso!");
                alert.SetMessage("Módulo cadastrado com sucesso!");
                alert.SetPositiveButton("OK", (senderAlert, args) => {
                });

                Dialog dialog = alert.Create();
                dialog.Show();

            }
            else
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Código incorreto");
                alert.SetMessage("Módulo não foi cadastrado.");
                alert.SetPositiveButton("OK", (senderAlert, args) => {
                    Toast.MakeText(this, "Tente de novo!", ToastLength.Short).Show();
                });
                Dialog dialog = alert.Create();
                dialog.Show();

            }

        }

    }
}