﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MspRoadShowMobileApp.Droid
{
    [Activity(Label = "MspRoadShowMobileApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            // load theme for Android
            //var x = typeof(Xamarin.Forms.Themes.DarkThemeResources);
           var  x = typeof(Xamarin.Forms.Themes.LightThemeResources);
           // x = typeof(Xamarin.Forms.Themes.Android.UnderlineEffect);
        }
    }
}

