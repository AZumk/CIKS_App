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
using Android.Media;
using Android.Content.Res;
using System.IO;

namespace CIKS.Activities
{
    [Activity(Label = "VideoActivity")]
    public class VideoActivity : Activity
    {
        

         VideoView videoView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Video);
        
        }
    }
}
   
