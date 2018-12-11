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
    [Activity(Label = "Área do Pai ", MainLauncher = false, Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class PerfilPaiActivity : Activity
    {
        private ImageButton button_logout;
        private ImageButton button_session;
        private ImageButton button_ajuda;
        private ImageButton button_progresso;
        private ImageButton button_edit;
        private ImageButton button_modulos;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PerfilPai);

            button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
            button_session = FindViewById<ImageButton>(Resource.Id.button_session);
            button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);
            button_progresso = FindViewById<ImageButton>(Resource.Id.button_progresso);
            button_edit = FindViewById<ImageButton>(Resource.Id.button_edit);
            button_modulos = FindViewById<ImageButton>(Resource.Id.button_modulos);

            //menu principal
            button_logout.Click += button_logout_Click;
            button_session.Click += button_session_Click;
            button_ajuda.Click += button_ajuda_Click;
            //menu pai
            button_progresso.Click += button_progresso_Click;
            button_edit.Click += button_edit_Click;
            button_modulos.Click += button_modulos_Click;

        }

        //menu pai
        private void button_modulos_Click(object sender, EventArgs e)
        {
            //conteudo referencial + outros modulos
            var modulos = new Intent(this, typeof(ConteudoRefActivity));
            StartActivity(modulos);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            var edit = new Intent(this, typeof(EditActivity));
            StartActivity(edit);
        }

        private void button_progresso_Click(object sender, EventArgs e)
        {
            var progresso = new Intent(this, typeof(ProgressoActivity));
            StartActivity(progresso);
        }


        //menu principal
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

    }
}