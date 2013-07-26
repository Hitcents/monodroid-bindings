using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using SamsungIAP;
//using Com.Testflightapp.Lib;
using Adhub.Ad;
using MillennialMedia;

namespace TestApplication
{
    [Activity(Label = "TestApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            MMSDK.Initialize(this);
            //var manager = ChordManager.GetInstance(this);
            //var d = manager.AvailableInterfaceTypes;
            // Set our view from the "main" layout resource
            //TestFlight.TakeOff(Application, "herp de derp");
            SetContentView(Resource.Layout.Main);

            /*var ad = FindViewById<AdHubView>(Resource.Id.AdLayout);
            ad.SetListener(this);
            ad.Init(this, "", Com.Sec.Android.AD.Info.AdSize.Banner);*/


            #region MillennialMedia Advert Code
            var mmad = FindViewById<RelativeLayout>(Resource.Id.MMAdLayout);
            var adView = new MMAdView(this);
            adView.Apid = "129242";

            MMRequest request = new MMRequest();
            //Metadata
            adView.MMRequest = request;
            adView.Id = MMSDK.DefaultAdId;
            var layoutParams =new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            layoutParams.AddRule(LayoutRules.CenterHorizontal);
            mmad.AddView(adView, layoutParams);
            adView.Invalidate();
            adView.GetAd();
            #endregion

            #region Samsung Adhub Code
            /*
            var samsungAd = FindViewById<AdHubView>(Resource.Id.AdLayout);
            samsungAd.Init(this, "xv0d0000000230", Com.Sec.Android.AD.Info.AdSize.Banner);
            samsungAd.StartAd();
             * */
            #endregion
        }
    }
}