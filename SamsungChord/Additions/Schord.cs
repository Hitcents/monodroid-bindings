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

namespace SamsungChord
{
    public partial class Schord
    {
        //<field deprecated="not deprecated" final="true" name="ERROR_FILE_CANCELED" static="true" transient="false" type="int" type-generic-aware="int" value="2002" visibility="public" volatile="false">
        //</field>
        public const int ErrorFileCanceled = 2002;

        //<field deprecated="not deprecated" final="true" name="ERROR_FILE_CREATE_FAILED" static="true" transient="false" type="int" type-generic-aware="int" value="2003" visibility="public" volatile="false">
        //</field>
        public const int ErrorFileCreateFailed = 2003;

        //<field deprecated="not deprecated" final="true" name="ERROR_FILE_NO_RESOURCE" static="true" transient="false" type="int" type-generic-aware="int" value="2004" visibility="public" volatile="false">
        //</field>
        public const int ErrorFileNoResource = 2004;

        //<field deprecated="not deprecated" final="true" name="ERROR_FILE_REJECTED" static="true" transient="false" type="int" type-generic-aware="int" value="2001" visibility="public" volatile="false">
        //</field>
        public const int ErrorFileRejected = 2001;

        //<field deprecated="not deprecated" final="true" name="ERROR_FILE_SEND_FAILED" static="true" transient="false" type="int" type-generic-aware="int" value="2000" visibility="public" volatile="false">
        //</field>
        public const int ErrorFileSendFailed = 2000;

        //<field deprecated="not deprecated" final="true" name="ERROR_FILE_TIMEOUT" static="true" transient="false" type="int" type-generic-aware="int" value="2005" visibility="public" volatile="false">
        //</field>
        public const int ErrorFileTimeout = 2005;

        //<field deprecated="not deprecated" final="true" name="ERROR_NONE" static="true" transient="false" type="int" type-generic-aware="int" value="2006" visibility="public" volatile="false">
        //</field>
        public const int ErrorNone = 2006;
    }
}