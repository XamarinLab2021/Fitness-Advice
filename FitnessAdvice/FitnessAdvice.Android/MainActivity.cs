using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Views;

namespace FitnessAdvice.Droid
{
    [Activity(Label = "FitnessAdvice", Icon = "@mipmap/icon", Theme = "@style/splashscreen", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
       protected override void OnCreate(Bundle bundle)
{
    base.Window.RequestFeature(WindowFeatures.ActionBar);
    base.SetTheme(Resource.Style.MainTheme);

    base.OnCreate(bundle);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}