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
using Com.Scwang.Smartrefresh.Layout;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Header;
using Com.Scwang.Smartrefresh.Layout.Constant;
using Android.Support.V4.Content;
using Android.Support.V7.Widget;
using Sample.Common;
using Com.Scwang.Smartrefresh.Layout.Footer;

namespace Sample.Activities.Using
{
    [Activity(Label = "@string/title_activity_using_assign_default")]
    public class AssignDefaultUsingActivity : AppCompatActivity
    {
        private static bool isFirstEnter = true;

        /*
        * 关键代码，需要在布局生成之前设置，建议代码放在 Application.onCreate 中
        */
        static AssignDefaultUsingActivity()
        {
            //设置全局的Header构建器
            SmartRefreshLayout.SetDefaultRefreshHeaderCreater(new SimpleDefaultRefreshHeaderCreater());
            //设置全局的Footer构建器
            SmartRefreshLayout.SetDefaultRefreshFooterCreater(new SimpleDefaultRefreshFooterCreater());
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_using_assign_default);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            /**
             * 以下代码仅仅为了演示效果而已，不是必须的
             * 关键代码在构造函数中
             */
            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                //触发上啦加载
                refreshLayout.AutoLoadmore();
                //通过多功能监听接口实现 在第一次加载完成之后 自动刷新
                refreshLayout.SetOnMultiPurposeListener(new CustomSimpleMultiPurposeListener());
            }
        }

        private class SimpleDefaultRefreshHeaderCreater : Java.Lang.Object, IDefaultRefreshHeaderCreater
        {
            public IRefreshHeader CreateRefreshHeader(Context context, IRefreshLayout layout)
            {
                ClassicsHeader header = new ClassicsHeader(context).SetSpinnerStyle(SpinnerStyle.FixedBehind);
                header.SetPrimaryColors(ContextCompat.GetColor(context, Resource.Color.colorPrimary), ContextCompat.GetColor(context, Android.Resource.Color.White));
                return header;//指定为经典Header，默认是 贝塞尔雷达Header
            }
        }

        private class SimpleDefaultRefreshFooterCreater : Java.Lang.Object, IDefaultRefreshFooterCreater
        {
            public IRefreshFooter CreateRefreshFooter(Context context, IRefreshLayout layout)
            {
                ClassicsFooter footer = new ClassicsFooter(context);
                footer.SetBackgroundResource(Android.Resource.Color.White);
                footer.SetSpinnerStyle(SpinnerStyle.Scale);//设置为拉伸模式
                return footer;//指定为经典Footer，默认是 BallPulseFooter
            }
        }
    }
}