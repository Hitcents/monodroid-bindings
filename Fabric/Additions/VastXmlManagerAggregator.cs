using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MoPub
{
    public partial class VastXmlManagerAggregator
    {
        protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
        }
    }
}