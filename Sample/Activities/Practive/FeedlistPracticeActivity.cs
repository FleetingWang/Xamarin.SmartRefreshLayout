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
using Sample.Utils;
using Com.Scwang.Smartrefresh.Layout.Api;

namespace Sample.Activities.Practive
{
    [Activity(Label = "@string/title_activity_practice_feedlist")]
    public class FeedlistPracticeActivity : AppCompatActivity
    {
        private static bool isFirstEnter = true;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_practice_feedlist);

            var mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };

            var mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                mRefreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果
            }
        }
    }
}