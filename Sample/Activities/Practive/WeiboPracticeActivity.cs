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
using Android.Support.V4.Widget;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Util;
using Android.Support.V4.Content;
using Com.Scwang.Smartrefresh.Layout.Listener;

namespace Sample.Activities.Practive
{
    [Activity(Label = "@string/title_activity_practice_profile")]
    public class WeiboPracticeActivity : AppCompatActivity
    {
        private int mOffset = 0;
        private int mScrollY = 0;
        private View parallax;
        private Toolbar mToolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_practice_weibo);

            mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };

            //状态栏透明和间距处理
            StatusBarUtil.immersive(this);
            StatusBarUtil.setPaddingSmart(this, mToolbar);

            parallax = FindViewById(Resource.Id.parallax);
            var buttonBar = FindViewById(Resource.Id.buttonBarLayout);
            var scrollView = FindViewById<NestedScrollView>(Resource.Id.scrollView);
            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;

            refreshLayout.SetOnMultiPurposeListener(new CustomSimpleMultiPurposeListener(this));

            int lastScrollY = 0;
            int h = DensityUtil.Dp2px(170);
            int color = ContextCompat.GetColor(ApplicationContext, Resource.Color.colorPrimary) & 0x00ffffff;
            scrollView.ScrollChange += (sender, e) => {
                var scrollX = e.ScrollX;
                var scrollY = e.ScrollY;
                if (lastScrollY < h)
                {
                    scrollY = Math.Min(h, scrollY);
                    mScrollY = scrollY > h ? h : scrollY;
                    buttonBar.Alpha = 1f * mScrollY / h;
                    mToolbar.SetBackgroundColor(new Android.Graphics.Color(((255 * mScrollY / h) << 24) | color));
                    parallax.TranslationY  = mOffset - mScrollY;
                }
                lastScrollY = scrollY;
            };

            buttonBar.Alpha = 0;
            mToolbar.SetBackgroundColor(new Android.Graphics.Color(0));
        }

        private class CustomSimpleMultiPurposeListener: SimpleMultiPurposeListener
        {
            private WeiboPracticeActivity _activity;
            public CustomSimpleMultiPurposeListener(WeiboPracticeActivity activity)
            {
                _activity = activity;
            }

            public override void OnHeaderPulling(IRefreshHeader header, float percent, int offset, int headerHeight, int extendHeight)
            {
                _activity.mOffset = offset / 2;
                _activity.parallax.TranslationY = _activity.mOffset - _activity.mScrollY;
                _activity.mToolbar.Alpha = 1 - Math.Min(percent, 1);
            }

            public override void OnHeaderReleasing(IRefreshHeader header, float percent, int offset, int footerHeight, int extendHeight)
            {
                _activity.mOffset = offset / 2;
                _activity.parallax.TranslationY = _activity.mOffset - _activity.mScrollY;
                _activity.mToolbar.Alpha = 1 - Math.Min(percent, 1);
            }
        }
    }
}