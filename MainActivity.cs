using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Appcent.Services;
using System;
using System.Collections.Generic;

namespace Appcent
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public ImageView imagen;
        public ImageView imagenejemplo;
        ImageService _imageService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            imagen = FindViewById<ImageView>(Resource.Id.imagenejemplo);
            _imageService.GetImage();
        }
	}
}

