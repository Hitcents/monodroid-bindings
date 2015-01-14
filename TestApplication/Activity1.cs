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
using Android.Util;
using Com.Chartboost.Sdk;
using Android.Content.PM;
//using MoPub;
//using Com.Facebook.Widget;
//using Com.Facebook.Android;
//using Com.Facebook.Internal;
//using Com.Facebook.Model;

namespace TestApplication
{
    [Activity(Label = "TestApplication", MainLauncher = true, Icon = "@drawable/icon", 
        ConfigurationChanges = ConfigChanges.Keyboard | ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class Activity1 : Activity
    {
        // TODO: Replace this test id with your personal ad unit id
        private const string APP_ID = "54744f6a0d602554822b9c6b";
        private const string APP_SIGNATURE = "2d64505617a06c07579fd8416dbcd3ca08ae13fd";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Chartboost.StartWithAppId(this, APP_ID, APP_SIGNATURE);
            Chartboost.LoggingLevel = Com.Chartboost.Sdk.Libraries.CBLogging.Level.All;
            Chartboost.SetDelegate(new ChartDelegate());

            Chartboost.OnCreate(this);
        }

        protected override void OnStart()
        {
            base.OnStart();
            Chartboost.OnStart(this);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Chartboost.OnResume(this);
            Chartboost.CacheInterstitial(CBLocation.LocationDefault);
        }

        protected override void OnPause()
        {
            base.OnPause();
            Chartboost.OnPause(this);
        }

        protected override void OnStop()
        {
            base.OnStop();
            Chartboost.OnStop(this);
        }

        protected override void OnDestroy()
        {
            Chartboost.OnDestroy(this);
            base.OnDestroy();
        }

        public override void OnBackPressed()
        {
            if (Chartboost.OnBackPressed())
                return;
            base.OnBackPressed();
        }
        
        internal class ChartDelegate : ChartboostDelegate
        {
            public override void DidCloseInterstitial(string p0)
            {
                base.DidCloseInterstitial(p0);
            }

            public override void DidDisplayInterstitial(string p0)
            {
                base.DidDisplayInterstitial(p0);
            }

            public override void DidFailToLoadInterstitial(string p0, Com.Chartboost.Sdk.Model.CBError.CBImpressionError p1)
            {
                base.DidFailToLoadInterstitial(p0, p1);
            }

            public override void DidDismissInterstitial(string p0)
            {
                base.DidDismissInterstitial(p0);
            }

            public override bool ShouldDisplayInterstitial(string p0)
            {
                return base.ShouldDisplayInterstitial(p0);
            }

            public override void DidCacheInterstitial(string p0)
            {
                base.DidCacheInterstitial(p0);

                Chartboost.ShowInterstitial(p0);
            }
        }
    }
}