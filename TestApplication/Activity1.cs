using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using SamsungChord;
using Com.Testflightapp.Lib;

namespace TestApplication
{
    [Activity(Label = "TestApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //var manager = ChordManager.GetInstance(this);
            //var d = manager.AvailableInterfaceTypes;
            // Set our view from the "main" layout resource
            TestFlight.TakeOff(Application, "herp de derp");
            SetContentView(Resource.Layout.Main);
        }

        public Bundle GetItemList(int mode, string packageName, string itemGroupId, int startNum, int endNum, string itemType)
        {
            throw new NotImplementedException();
        }

        public Bundle GetItemsInbox(string packageName, string itemGroupId, int startNum, int endNum, string startDate, string endDate)
        {
            throw new NotImplementedException();
        }

        public Bundle Init(int mode)
        {
            throw new NotImplementedException();
        }
    }
}

