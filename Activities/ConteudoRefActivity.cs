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
    [Activity(Label = "Conteúdo Referencial", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class ConteudoRefActivity : Activity
    {
        private ImageButton button_logout;
        private ImageButton button_session;
        private ImageButton button_ajuda;

        private ImageButton imagebutton1;
        private ImageButton imagebutton2;
        private ImageButton imagebutton3;
        private ImageButton imagebutton4;
        private ImageButton imagebutton5;

        private ImageButton button_Cadastrarmodulo;
        private ImageButton button_modulouniverso;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ConteudoRef);

            button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
            button_session = FindViewById<ImageButton>(Resource.Id.button_session);
            button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);

            imagebutton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            imagebutton2 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            imagebutton3 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            imagebutton4 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            imagebutton5 = FindViewById<ImageButton>(Resource.Id.imageButton1);

            button_modulouniverso = FindViewById<ImageButton>(Resource.Id.button_modulouniverso);
            button_Cadastrarmodulo = FindViewById<ImageButton>(Resource.Id.button_cadastromod);

            // menu principal
            button_logout.Click += button_logout_Click;
            button_session.Click += button_session_Click;
            button_ajuda.Click += button_ajuda_Click;

            //botoes de movimentacao entre modulos
            imagebutton1.Click += imagebutton_Click;
            imagebutton2.Click += imagebutton_Click;
            imagebutton3.Click += imagebutton_Click;
            imagebutton4.Click += imagebutton_Click;
            imagebutton5.Click += imagebutton_Click;

            //seleciona modulo universo
            button_modulouniverso.Click += button_modulouniverso_Click;
            button_Cadastrarmodulo.Click += button_Cadastrarmodulo_Click;
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

        //botoes modulo universo e cadastrar

        private void button_Cadastrarmodulo_Click(object sender, EventArgs e)
        {
            var cadmod = new Intent(this, typeof(CadastroModActivity));
            StartActivity(cadmod);
        }

        private void button_modulouniverso_Click(object sender, EventArgs e)
        {
            var refuniverso = new Intent(this, typeof(ContRefUniverso));
            StartActivity(refuniverso);
        }

        private void imagebutton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Módulo indisponivel", ToastLength.Short).Show();
        }

    }
}