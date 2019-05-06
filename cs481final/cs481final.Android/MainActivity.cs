using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace cs481final.Droid
{
    [Activity(Label = "cs481final", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            AppCenter.Start("6f7cf46a-978f-4ff3-9072-e99617c94908",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("6f7cf46a-978f-4ff3-9072-e99617c94908", typeof(Analytics), typeof(Crashes));
            LoadApplication(new App());

        }
    }
}