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
using System.IO;
using SQLite;
using App_CIKS.Models;
using Android.Content.PM;
using CIKS;
using System.Text.RegularExpressions;
using System.Globalization;
using Android.Graphics;
using Android.Content.Res;

namespace App_CIKS.Activities
{
    [Activity(Label = "CadastroActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class CadastroActivity : Activity
    {
        EditText txtusername;
        EditText txtPassword;
        EditText txtPasswordConfirm;
        EditText txtEmail;
        TextView txttitulo;
        Button btncreate;
        ImageButton btn_reg_back;
        public AssetManager mngr; 
        public Typeface LinotteRegular;
        public Typeface LinotteBold;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Cadastro);
             Fonts();
            // 
            btncreate = FindViewById<Button>(Resource.Id.btn_reg_create);
            btn_reg_back = FindViewById<ImageButton>(Resource.Id.btn_reg_back);
            btn_reg_back.Click += Btn_reg_back_Click;
            txtusername = FindViewById<EditText>(Resource.Id.txt_reg_username);
            txtPassword = FindViewById<EditText>(Resource.Id.txt_reg_password);
            txtPasswordConfirm = FindViewById<EditText>(Resource.Id.txt_reg_passwordconfirm);
            txtEmail = FindViewById<EditText>(Resource.Id.txt_reg_email);
            txttitulo = FindViewById<TextView>(Resource.Id.textocadastrar);
            btncreate.Click += Btncreate_Click;

            //

            txtusername.SetTypeface(LinotteRegular, TypefaceStyle.Normal);
            txtPassword.SetTypeface(LinotteRegular, TypefaceStyle.Normal);
            txtPasswordConfirm.SetTypeface(LinotteRegular, TypefaceStyle.Normal);
            txtEmail.SetTypeface(LinotteRegular, TypefaceStyle.Normal);
            txttitulo.SetTypeface(LinotteBold, TypefaceStyle.Normal);
            btncreate.SetTypeface(LinotteRegular, TypefaceStyle.Normal);
        }

        public void Fonts()
        {

            
            LinotteRegular = Typeface.CreateFromAsset(Application.Context.Assets, "LinotteRegular.otf");
           LinotteBold = Typeface.CreateFromAsset(Application.Context.Assets, "LinotteBold.otf");

        }

    

    private void Btn_reg_back_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        private void Btncreate_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtusername.Text == string.Empty)
                {
                    Toast.MakeText(this, "Por favor, preencha o campo nome", ToastLength.Short).Show();
                    return;
                }

                if (txtPassword.Text == "" || txtPasswordConfirm.Text == "")
                {
                    Toast.MakeText(this, "Por favor, insira sua senha", ToastLength.Short).Show();
                    return;
                }
                if (txtPassword.Text != txtPasswordConfirm.Text)
                {
                    Toast.MakeText(this, "As senhas não correspodem", ToastLength.Short).Show();
                    return;

                }
                else if (txtPassword.Text == string.Empty)
                {
                    Toast.MakeText(this, "Por favor, insira sua senha", ToastLength.Short).Show();
                    return;
                }
                else if (txtPasswordConfirm.Text == string.Empty)
                {
                    Toast.MakeText(this, "Por favor, confirme sua senha", ToastLength.Short).Show();
                    return;
                }
                 else   if (!Regex.IsMatch(txtEmail.Text, @"^[a-z,A-Z]{1,10}((-|.)\w+)*@\w+.\w{3}$"))
                {
                    Toast.MakeText(this, "Por favor,digite uma email válido.", ToastLength.Short).Show();
                    return;
                }

               
           
                else
                {
                    string dpPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "db_login.db");
                    var db = new SQLiteConnection(dpPath);
                    db.CreateTable<User>();
                    User tbl = new User();
                    tbl.Username = txtusername.Text;
                    tbl.Password = txtPassword.Text;
                    tbl.passwordconfirm = txtPasswordConfirm.Text;
                    tbl.email = txtEmail.Text;
                    db.Insert(tbl);
                    if (tbl != null ? true : false)
                    {

                        Toast.MakeText(this, "Cadastro criado com sucesso!", ToastLength.Short).Show();
                    }
                }


            }



            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }

        }
    }
}
