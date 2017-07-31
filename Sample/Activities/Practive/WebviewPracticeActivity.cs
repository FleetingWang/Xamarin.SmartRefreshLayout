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
using Android.Webkit;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Listener;
using Java.Util;
using Com.Scwang.Smartrefresh.Layout.Util;
//using WebView = Android.Widget.WebView;

namespace Sample.Activities.Practive
{
    [Activity(Label = "@string/title_activity_practice_profile")]
    public class WebviewPracticeActivity : AppCompatActivity
    {
        private WebView webView;
        private IRefreshLayout mRefreshLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_practice_webview);

            var mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };


            mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            mRefreshLayout.SetOnRefreshListener(new CustomOnRefreshListener(this));
            mRefreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果

            webView = FindViewById<WebView>(Resource.Id.webView);
            webView.Settings.JavaScriptEnabled = true;
            
            webView.SetWebViewClient(new CustomWebViewClient(this));

            //状态栏透明和间距处理
            StatusBarUtil.immersive(this);
            StatusBarUtil.setPaddingSmart(this, webView);
            StatusBarUtil.setPaddingSmart(this, mToolbar);
            StatusBarUtil.setMargin(this, FindViewById(Resource.Id.header));
            StatusBarUtil.setPaddingSmart(this, FindViewById(Resource.Id.blurview));
        }

        private class CustomWebViewClient: WebViewClient
        {
            private WebviewPracticeActivity _activity;
            public CustomWebViewClient(WebviewPracticeActivity activity)
            {
                _activity = activity;
            }

            public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
            {
                view.LoadUrl(request.Url.ToString());
                return true;
            }

            public override void OnPageCommitVisible(WebView view, string url)
            {
                _activity.mRefreshLayout.FinishRefresh();
                view.LoadUrl(Java.Lang.String.Format(Locale.China, "javascript:document.body.style.paddingTop='%fpx'; void 0", DensityUtil.Px2dp(_activity.webView.PaddingTop)));
            }
        }

        private class CustomOnRefreshListener : Java.Lang.Object, IOnRefreshListener
        {
            private WebviewPracticeActivity _activity;
            public CustomOnRefreshListener(WebviewPracticeActivity activity)
            {
                _activity = activity;
            }

            public void OnRefresh(IRefreshLayout p0)
            {
                _activity.webView.LoadUrl("https://github.com/scwang90/SmartRefreshLayout");
            }
        }
    }
}