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
using App_CIKS.Activities.App_CIKS.Activities;

namespace App_CIKS.Activities
{
    [Activity(Label = "CIKS", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class PerfilCriancaActivity : Activity
    {
        private ImageButton button_logout;
        private ImageButton button_session;
        private ImageButton button_ajuda;
        private ImageButton button_left;
        private ImageButton button_right;
        private ImageButton button_modulouniverso;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PerfilCrianca);

            button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
            button_session = FindViewById<ImageButton>(Resource.Id.button_session);
            button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);
            button_left = FindViewById<ImageButton>(Resource.Id.button_left);
            button_right = FindViewById<ImageButton>(Resource.Id.button_right);
            button_modulouniverso = FindViewById<ImageButton>(Resource.Id.button_modulouniverso);


            // menu principal
            button_logout.Click += button_logout_Click;
            button_session.Click += button_session_Click;
            button_ajuda.Click += button_ajuda_Click;

            //botoes de movimentacao entre modulos
            button_left.Click += button_left_Click;
            button_right.Click += button_right_Click;
            //seleciona modulo universo
            button_modulouniverso.Click += button_modulouniverso_Click;
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

        // navegacao entre modulos
        private void button_left_Click(object sender, EventArgs e)
        {
            //ver ultimo modulo
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            //ver segundo modulo

        }

        private void button_modulouniverso_Click(object sender, EventArgs e)
        {
            //seleciona modulo universo
            //verifica se codigo de desbloqueio ja foi colocado
            bool moduloStatus = false;
            if (moduloStatus == true) //se o modulo ja esta cadastrado
            {
                var selecthist = new Intent(this, typeof(SelectHistActivity));
                StartActivity(selecthist);
            }
            else //se o modulo nao tiver sido cadastrado
            {
                //set alert for executing the task
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Cadastro não encontrado");
                alert.SetMessage("Cadastre o módulo Universo com o código encontrado na embalagem");

                alert.SetPositiveButton("Cadastrar", (senderAlert, args) => { //direciona para pag cadastro de modulo
                    var cadastroMod = new Intent(this, typeof(CadastroModActivity));
                    StartActivity(cadastroMod);
                });

                alert.SetNegativeButton("Cancelar", (senderAlert, args) => { //cancela e retorna a selecao

                });

                Dialog dialog = alert.Create();
                dialog.Show();
            }
        }


    }
}