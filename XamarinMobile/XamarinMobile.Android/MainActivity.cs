using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Android.Support.V4.Content;
using Android;
using Android.Support.V4.App;

namespace XamarinMobile.Droid
{
    [Activity(Label = "XamarinMobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private static int REQUEST = 200;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            ImageCircleRenderer.Init();
            LoadApplication(new App());

            if ((ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) != (int)Permission.Granted)
            || (ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadExternalStorage) != (int)Permission.Granted))
            {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.ReadExternalStorage, Manifest.Permission.WriteExternalStorage }, REQUEST);
            }


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }




    }
}