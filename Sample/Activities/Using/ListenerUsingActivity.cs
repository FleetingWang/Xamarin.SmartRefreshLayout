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
using Java.Text;
using TextView = Android.Widget.TextView;
using Java.Util;
using Android.Text.Method;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Listener;
using String = Java.Lang.String;
using Com.Scwang.Smartrefresh.Layout.Constant;

namespace Sample.Activities.Using
{
    [Activity(Label = "@string/title_activity_using_listener")]
    public class ListenerUsingActivity : AppCompatActivity
    {
        private static DateFormat FORMAT = new SimpleDateFormat("HH:mm sss", Locale.China);

        private static bool isFirstEnter = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_using_listener);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            var mTvContent = FindViewById<TextView>(Resource.Id.content);
            mTvContent.MovementMethod = ScrollingMovementMethod.Instance;

            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            refreshLayout.SetOnMultiPurposeListener(new CustomSimpleMultiPurposeListener(mTvContent));

            if (isFirstEnter)
            {
                isFirstEnter = false;
                //触发自动刷新
                refreshLayout.AutoRefresh();
            }
        }

        private class CustomSimpleMultiPurposeListener: SimpleMultiPurposeListener
        {
            private TextView mTvContent;

            private string mHeaderPulling;
            private string mHeaderReleasing;
            private string mFooterPulling;
            private string mFooterReleasing;
            private string mFooterStartAnimator;
            private string mHeaderStartAnimator;
            private string mFooterFinish;
            private string mHeaderFinish;
            private string mRefresh;
            private string mLoadmore;
            private string mStateChanged;

            public CustomSimpleMultiPurposeListener(TextView mTvContent)
            {
                this.mTvContent = mTvContent;
            }

            public override void OnHeaderPulling(IRefreshHeader header, float percent, int offset, int headerHeight, int extendHeight)
            {
                mHeaderPulling = String.Format(Locale.China, "%s\npercent=%.02f offset=%03d\nheight=%03d extend=%03d",
                        FORMAT.Format(new Date()),
                        percent, offset, headerHeight, extendHeight);
                updateContent();
            }

            public override void OnHeaderReleasing(IRefreshHeader header, float percent, int offset, int headerHeight, int extendHeight)
            {
                mHeaderReleasing = String.Format(Locale.China, "%s\npercent=%.02f offset=%03d\nheight=%03d extend=%03d",
                        FORMAT.Format(new Date()),
                        percent, offset, headerHeight, extendHeight);
                updateContent();
            }

            public override void OnHeaderStartAnimator(IRefreshHeader header, int headerHeight, int extendHeight)
            {
                mHeaderStartAnimator = String.Format(Locale.China, "%s\nheight=%03d extend=%03d",
                        FORMAT.Format(new Date()),
                        headerHeight, extendHeight);
                updateContent();
            }

            public override void OnHeaderFinish(IRefreshHeader header, bool success)
            {
                mHeaderFinish = String.Format(Locale.China, "%s - " + success, FORMAT.Format(new Date()));
                updateContent();
            }

            public override void OnFooterPulling(IRefreshFooter footer, float percent, int offset, int footerHeight, int extendHeight)
            {
                mFooterPulling = String.Format(Locale.China, "%s\npercent=%.02f\noffset=%03d height=%03d\nextend=%03d",
                        FORMAT.Format(new Date()),
                        percent, offset, footerHeight, extendHeight);
                updateContent();
            }

            public override void OnFooterReleasing(IRefreshFooter footer, float percent, int offset, int footerHeight, int extendHeight)
            {
                mFooterReleasing = String.Format(Locale.China, "%s\npercent=%.02f\noffset=%03d height=%03d\nextend=%03d",
                        FORMAT.Format(new Date()),
                        percent, offset, footerHeight, extendHeight);
                updateContent();
            }

            public override void OnFooterStartAnimator(IRefreshFooter footer, int footerHeight, int extendHeight)
            {
                mFooterStartAnimator = String.Format(Locale.China, "%s\nheight=%03d extend=%03d",
                        FORMAT.Format(new Date()),
                        footerHeight, extendHeight);
                updateContent();
            }

            public override void OnFooterFinish(IRefreshFooter footer, bool success)
            {
                mFooterFinish = String.Format(Locale.China, "%s - " + success, FORMAT.Format(new Date()));
                updateContent();
            }

            public override void OnRefresh(IRefreshLayout refreshlayout)
            {
                mRefresh = String.Format(Locale.China, "%s", FORMAT.Format(new Date()));
                updateContent();
            }

            public override void OnLoadmore(IRefreshLayout refreshlayout)
            {
                mLoadmore = String.Format(Locale.China, "%s", FORMAT.Format(new Date()));
                updateContent();
            }

            public override void OnStateChanged(IRefreshLayout refreshLayout, RefreshState oldState, RefreshState newState)
            {
                mStateChanged = String.Format(Locale.China, "%s\nnew=%s\nold=%s",
                        FORMAT.Format(new Date()),
                        newState.Name(),
                        oldState.Name());
                updateContent();
            }

            private void updateContent()
            {
                mTvContent.Text = String.Format(Locale.China,
                        "onStateChanged:%s\n\n" +
                                "onHeaderPulling:%s\n\n" +
                                "onHeaderReleasing:%s\n\n" +
                                "onHeaderStartAnimator:%s\n\n" +
                                "onHeaderFinish:%s\n\n" +
                                "onFooterPulling:%s\n\n" +
                                "onFooterReleasing:%s\n\n" +
                                "onFooterStartAnimator:%s\n\n" +
                                "onFooterFinish:%s\n\n" +
                                "onRefresh:%s\n\n" +
                                "onLoadmore:%s\n\n",
                        mStateChanged,
                        mHeaderPulling,
                        mHeaderReleasing,
                        mHeaderStartAnimator,
                        mHeaderFinish,
                        mFooterPulling,
                        mFooterReleasing,
                        mFooterStartAnimator,
                        mFooterFinish,
                        mRefresh,
                        mLoadmore);
            }
        }

        
    }
}