using System;
using Android.App;
using Android.OS;
using Android.Widget;
using System.IO;
using SQLite;
using App_CIKS.Models;
using App_CIKS.Activities;
using static System.Environment;
using Android.Content.PM;
using CIKS;

namespace App_CIKS.Activities
{
    [Activity(Label = "LoginActivity", Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class LoginActivity : Activity
    {
        EditText txtusername;
        EditText txtPassword;

        Button btnsign;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource  
            SetContentView(Resource.Layout.Login);
            // Get our button from the layout resource,  
            // and attach an event to it  
            btnsign = FindViewById<Button>(Resource.Id.btnlogin);

            txtusername = FindViewById<EditText>(Resource.Id.txtusername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtpwd);
            btnsign.Click += Btnsign_Click;

            CreateDB();
        }

        private void Btnsign_Click(object sender, EventArgs e)
        {
            try
            {
                string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "db_login.db"); //Call Database  
                var db = new SQLiteConnection(dpPath);
                var data = db.Table<User>(); //Call Table  
                var data1 = data.Where(x => x.Username == txtusername.Text && x.Password == txtPassword.Text).FirstOrDefault(); //Linq Query  
                db.Insert(data1); if (data1 != null ? true : false)
                {

                    StartActivity(typeof(UsersActivity));
                }
                else
                {
                    Toast.MakeText(this, "Usuário ou senha inválido", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
        public string CreateDB()
        {
            var output = "";
            output += "Creating Databse if it doesnt exists";
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3"); //Create New Database  
            var db = new SQLiteConnection(dpPath);
            output += "\n Database Created....";
            return output;
        }
    }
}