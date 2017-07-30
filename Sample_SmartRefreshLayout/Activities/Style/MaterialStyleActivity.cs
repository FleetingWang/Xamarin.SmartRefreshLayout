using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Com.Scwang.Smartrefresh.Layout.Api;

namespace Sample_SmartRefreshLayout.Activities.Style
{
    [Activity(Label = "@string/title_activity_style_material")]
    public class MaterialStyleActivity : AppCompatActivity
    {
        private static bool isFirstEnter = true;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_style_material);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                refreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果
            }
        }
    }
}