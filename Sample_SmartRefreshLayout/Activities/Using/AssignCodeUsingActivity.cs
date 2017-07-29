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
using Sample_SmartRefreshLayout.Common;
using Com.Scwang.Smartrefresh.Header;
using Com.Scwang.Smartrefresh.Layout.Footer;
using Com.Scwang.Smartrefresh.Layout.Constant;

namespace Sample_SmartRefreshLayout.Activities.Using
{
    [Activity(Label = "@string/title_activity_using_assign_code")]
    public class AssignCodeUsingActivity : AppCompatActivity
    {
        private static bool isFirstEnter = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_using_assign_code);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            //设置 Header 为 Material风格
            refreshLayout.SetRefreshHeader(new MaterialHeader(this).SetShowBezierWave(true));
            //设置 Footer 为 球脉冲
            refreshLayout.SetRefreshFooter(new BallPulseFooter(this).SetSpinnerStyle(SpinnerStyle.Scale));
            
            /**
            * 以下代码仅仅为了演示效果而已，不是必须的
            */
            //设置主题颜色
            refreshLayout.SetPrimaryColorsId(Resource.Color.colorPrimary, Android.Resource.Color.White);

            if (isFirstEnter)
            {
                isFirstEnter = false;
                //触发上啦加载
                refreshLayout.AutoLoadmore();
                //通过多功能监听接口实现 在第一次加载完成之后 自动刷新
                refreshLayout.SetOnMultiPurposeListener(new CustomSimpleMultiPurposeListener());
            }
        }
    }
}