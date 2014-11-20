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
using MoPub;
//using Com.Facebook.Widget;
//using Com.Facebook.Android;
//using Com.Facebook.Internal;
//using Com.Facebook.Model;

namespace TestApplication
{
    [Activity(Label = "TestApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private const int IAB_LEADERBOARD_WIDTH = 728,
            IAB_LEADERBOARD_HEIGHT = 90,
            MED_BANNER_WIDTH = 480,
            MED_BANNER_HEIGHT = 60,
            BANNER_AD_WIDTH = 320, 
            BANNER_AD_HEIGHT = 50;
        // TODO: Replace this test id with your personal ad unit id
	    private const string MOPUB_BANNER_AD_UNIT_ID = "d4a0aba637d64a9f9a05a575fa757ac2";
	    private MoPubView _moPubView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var layout = FindViewById<RelativeLayout>(Resource.Id.MMAdLayout);

            _moPubView = (MoPubView)FindViewById<MoPubView>(Resource.Id.adView);
            _moPubView.AdUnitId = MOPUB_BANNER_AD_UNIT_ID;
            _moPubView.LoadAd();
        }

        protected override void OnDestroy()
        {
            _moPubView.Destroy();
            base.OnDestroy();
        }

        private bool CanFit(int adWidth)
        {
            var metrics = Resources.DisplayMetrics;
            var adWidthPx = TypedValue.ApplyDimension(ComplexUnitType.Dip, adWidth, metrics);
            return metrics.WidthPixels >= adWidthPx;
        }
    }
}