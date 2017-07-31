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
using Sample.Common;

namespace Sample.Activities.Using
{
    [Activity(Label = "@string/title_activity_using_assign_xml")]
    public class AssignXmlUsingActivity : AppCompatActivity
    {
        private static bool isFirstEnter = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_using_assign_xml);

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
    }
}