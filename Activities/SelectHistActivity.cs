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
    namespace App_CIKS.Activities
    {
        [Activity(Label = "Seleção de História", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = false, ScreenOrientation = ScreenOrientation.SensorLandscape)]
        public class SelectHistActivity : Activity
        {

            private ImageButton button_logout;
            private ImageButton button_session;
            private ImageButton button_ajuda;

            private ImageButton imagebutton1;
            private ImageButton imagebutton2;
            private ImageButton imagebutton3;
            private ImageButton imagebutton5;
            private ImageButton imagebutton6;
            private ImageButton imagebutton7;
            private ImageButton imagebutton8;
            private ImageButton imagebutton9;
            private ImageButton imagebutton10;
            private ImageButton imagebutton11;
            private ImageButton imagebutton12;

            private ImageButton button_eclipse;

            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);

                SetContentView(Resource.Layout.SelectHist);
                //menu principal
                button_logout = FindViewById<ImageButton>(Resource.Id.button_logout);
                button_session = FindViewById<ImageButton>(Resource.Id.button_session);
                button_ajuda = FindViewById<ImageButton>(Resource.Id.button_ajuda);

                // botoes das historias indisponiveis
                imagebutton1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
                imagebutton2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
                imagebutton3 = FindViewById<ImageButton>(Resource.Id.imageButton3);

                imagebutton5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
                imagebutton6 = FindViewById<ImageButton>(Resource.Id.imageButton6);
                imagebutton7 = FindViewById<ImageButton>(Resource.Id.imageButton7);
                imagebutton8 = FindViewById<ImageButton>(Resource.Id.imageButton8);
                imagebutton9 = FindViewById<ImageButton>(Resource.Id.imageButton9);
                imagebutton10 = FindViewById<ImageButton>(Resource.Id.imageButton10);
                imagebutton11 = FindViewById<ImageButton>(Resource.Id.imageButton11);
                imagebutton12 = FindViewById<ImageButton>(Resource.Id.imageButton12);
                //botao da historia disponivel
                button_eclipse = FindViewById<ImageButton>(Resource.Id.button_eclipse);

                button_logout.Click += button_logout_Click;
                button_session.Click += button_session_Click;
                button_ajuda.Click += button_ajuda_Click;


                imagebutton1.Click += imagebutton1_Click;
                imagebutton2.Click += imagebutton1_Click;
                imagebutton3.Click += imagebutton1_Click;
                imagebutton5.Click += imagebutton1_Click;
                imagebutton6.Click += imagebutton1_Click;
                imagebutton7.Click += imagebutton1_Click;
                imagebutton8.Click += imagebutton1_Click;
                imagebutton9.Click += imagebutton1_Click;
                imagebutton10.Click += imagebutton1_Click;
                imagebutton11.Click += imagebutton1_Click;
                imagebutton12.Click += imagebutton1_Click;

                button_eclipse.Click += button_eclipse_Click; // botao para a historia - verificar se cartao esta inserido

            }



            private void button_eclipse_Click(object sender, EventArgs e)
            {
                // verifica se cartao esta inserido
                if (2 < 1) //cartao nao inserido
                {
                    SemCartao();
                }

                else //cartao inserido
                {
                    //pull up dialog
                    var menuhist = new Intent(this, typeof(MenuActivity));
                    StartActivity(menuhist);
                }
            }

            private void imagebutton1_Click(object sender, EventArgs e)
            {
                //avisa que cartao da historia nao esta inserido
                SemCartao();
            }



            private void SemCartao() //alerta que o cartao nao esta inserido
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Cartão não encontrado");
                alert.SetMessage("Insira na CIKS o cartão da história");
                alert.SetPositiveButton("OK", (senderAlert, args) =>
                {

                });


                Dialog dialog = alert.Create();
                dialog.Show();
            }

            //menu
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
            //return
            private void button_voltar_Click(object sender, EventArgs e)
            {
                var perfilcrianca = new Intent(this, typeof(PerfilCriancaActivity));
                StartActivity(perfilcrianca);
            }
        }
    }
}