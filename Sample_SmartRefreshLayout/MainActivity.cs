using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Sample_SmartRefreshLayout
{
    [Activity(Label = "@string/title_activity_index_main", 
        MainLauncher = true, 
        Icon = "@mipmap/ic_launcher", 
        RoundIcon = "@mipmap/ic_launcher",
        Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_index_main);

        }
    }
}

