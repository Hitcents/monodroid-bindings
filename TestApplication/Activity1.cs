using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using SamsungChord;
using SamsungIAP;
using Com.Sec.Android.AD;
using Com.Sec.Android.Tracking;
using Com.Ormma.Controller.Util;

namespace TestApplication
{
    [Activity(Label = "TestApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity, IAPServiceCallback, IAPConnector
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //var manager = ChordManager.GetInstance(this);
            //var d = manager.AvailableInterfaceTypes;
            // Set our view from the "main" layout resource
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

        public bool RequestCmd(IAPServiceCallback callback, Bundle bundle)
        {
            throw new NotImplementedException();
        }

        public bool UnregisterCallback(IAPServiceCallback callback)
        {
            throw new NotImplementedException();
        }

        public IBinder AsBinder()
        {
            throw new NotImplementedException();
        }

        public void ResponseCallback(Bundle bundle)
        {
            throw new NotImplementedException();
        }
    }
}

