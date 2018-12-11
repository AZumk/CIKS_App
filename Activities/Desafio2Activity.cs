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
    [Activity(Label = " 2° Desafio", Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class Desafio2Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Desafio2);
        }
    }
}