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
using MillennialMedia;
using Android.Util;
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

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var layout = FindViewById<RelativeLayout>(Resource.Id.MMAdLayout);

            var adView = FindViewById<MMAdView>(Resource.Id.adView);
            
            var request = new MMRequest();
            adView.MMRequest = request;

            var width = BANNER_AD_WIDTH;
            var height = BANNER_AD_HEIGHT;

            if(CanFit(IAB_LEADERBOARD_HEIGHT))
            {
                width = IAB_LEADERBOARD_WIDTH;
                height = IAB_LEADERBOARD_HEIGHT;
            }
            else if (CanFit(MED_BANNER_WIDTH))
            {
                width = MED_BANNER_WIDTH;
                height = MED_BANNER_HEIGHT;
            }

            adView.SetWidth(width);
            adView.SetHeight(height);

            var layoutWidth = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, width, Resources.DisplayMetrics);
            var layoutHeight = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, height, Resources.DisplayMetrics);

            var layoutParams = new RelativeLayout.LayoutParams(layoutWidth, layoutHeight);

            layoutParams.AddRule(LayoutRules.AlignParentTop);
            layoutParams.AddRule(LayoutRules.CenterHorizontal);

            adView.LayoutParameters = layoutParams;

            layout.AddView(adView);

            adView.GetAd();

            
        }

        private bool CanFit(int adWidth)
        {
            var metrics = Resources.DisplayMetrics;
            var adWidthPx = TypedValue.ApplyDimension(ComplexUnitType.Dip, adWidth, metrics);
            return metrics.WidthPixels >= adWidthPx;
        }
    }
}