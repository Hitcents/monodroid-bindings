using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using SamsungIAP;
//using Com.Testflightapp.Lib;
//using Adhub.Ad;
//using MillennialMedia;
using Com.Facebook.Widget;
using Com.Facebook.Android;
using Com.Facebook.Internal;
using Com.Facebook.Model;

namespace TestApplication
{
    [Activity(Label = "TestApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            
        }
    }
}