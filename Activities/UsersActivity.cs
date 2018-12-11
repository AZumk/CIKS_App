using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using App_CIKS.Service;
using App_CIKS.Repository;
using App_CIKS.ListAdapters;
using App_CIKS.Module;

using CIKS;
using Android.Content.PM;

namespace App_CIKS.Activities
{
    [Activity(Label = "Perfis", Theme = "@android:style/Theme.Holo.Light.NoActionBar", ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class UsersActivity : Activity
    {

       UsersListAdapter _photoList;
        IList<PhotoItem> _photos;
        ImageButton addPhotoButton;
        ImageButton AreadopaiButton;
        ImageButton LogoutButton;
        ListView photoListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Perfis);

            photoListView = FindViewById<ListView>(Resource.Id.photoList);
            addPhotoButton = FindViewById<ImageButton>(Resource.Id.AddButton);
           AreadopaiButton = FindViewById<ImageButton>(Resource.Id.areadopai);
            LogoutButton = FindViewById<ImageButton>(Resource.Id.btn_logout);

            if (addPhotoButton != null)
            {
                addPhotoButton.Click += (sender, e) => {
                    StartActivity(typeof(EditActivity));
                };
            }
            if (LogoutButton != null)
            {
                LogoutButton.Click += (sender, e) => {
                    StartActivity(typeof(MainActivity));
                };
            }
            if (AreadopaiButton != null)
            {
                AreadopaiButton.Click += (sender, e) => {
                    StartActivity(typeof(PerfilPaiActivity));
                };
            }

            // 
            if (photoListView != null)
            {
                photoListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
                    var photoDetails = new Intent(this, typeof(PerfilCriancaActivity));
                    photoDetails.PutExtra("PhotoID", _photos[e.Position].ID);
                    StartActivity(photoDetails);
                };
            }
        }

        protected override void OnResume()
        {
            base.OnResume();

            _photos = FotmiApp.Current.PhotoService.GetPhotos();

            // create our adapter
            _photoList = new UsersListAdapter(this, _photos);

            //Hook up our adapter to our ListView
            photoListView.Adapter = _photoList;
        }
    }
}

