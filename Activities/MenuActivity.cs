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
using App_CIKS.Activities;
using App_CIKS.Activities.App_CIKS.Activities;

namespace CIKS.Activities
{
    [Activity(Label = "CIKS", Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class MenuActivity : Activity
    {
        ImageButton voltarButton;
        ImageButton ajudaButton;
        ImageButton LogoutButton;
        ImageButton sessaoButton;
        ImageButton assistirButton;
        ImageButton desafiosButton;
        ImageButton resumoButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);
            
            voltarButton = FindViewById<ImageButton>(Resource.Id.btn_reg_back);
            ajudaButton = FindViewById<ImageButton>(Resource.Id.ajudabtn);
            LogoutButton = FindViewById<ImageButton>(Resource.Id.logoutbtn);
            sessaoButton = FindViewById<ImageButton>(Resource.Id.sessaobtn);
            assistirButton = FindViewById<ImageButton>(Resource.Id.assistirbtn);
            desafiosButton = FindViewById<ImageButton>(Resource.Id.desafiosbtn);
            resumoButton = FindViewById<ImageButton>(Resource.Id.resumobtn);
            // 

            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Ativação Bluetooth");
            alert.SetMessage("Por favor, verifique se o seu Bluetooth está ativado.");
        
            Dialog dialog = alert.Create();
            dialog.Show();

            if (voltarButton != null)
            {
                voltarButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(SelectHistActivity));
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
            if (assistirButton != null)
            {
                assistirButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(NarrativaActivity));
                };
            }
            if (desafiosButton != null)
            {
                desafiosButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(DesafiosActivity));
                };
            }
            if (resumoButton != null)
            {
                resumoButton.Click += (sender, e) =>
                {
                    StartActivity(typeof(ResumoActivity));
                };
            }
        }




    }
}
            