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
using Sample_SmartRefreshLayout.Adapters;
using Java.Util;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Listener;
using Android.Support.V7.Widget;

using Toast = Android.Widget.Toast;
using ToastLength = Android.Widget.ToastLength;
using ListView = Android.Widget.ListView;

namespace Sample_SmartRefreshLayout.Activities.Using
{
    [Activity(Label = "@string/title_activity_using_basic")]
    public class BasicUsingActivity : AppCompatActivity
    {
        private SimpleArrayAdapter mAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_using_basic);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            var listView = FindViewById<ListView>(Resource.Id.listview);
            listView.Adapter = mAdapter = new SimpleArrayAdapter(this);

            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            refreshLayout.SetEnableAutoLoadmore(true);//开启自动加载功能（非必须）
            refreshLayout.SetOnRefreshListener(new SimpleOnRefreshListener(this));
            refreshLayout.SetOnLoadmoreListener(new SimpleOnLoadmoreListener(this));

            //触发自动刷新
            refreshLayout.AutoRefresh();
        }

        private class SimpleArrayAdapter : BaseListAdapter<System.Object>
        {
            public SimpleArrayAdapter(Context context)
                : base(context, Android.Resource.Layout.SimpleListItem2)
            {
            }

            protected override void onBindViewHolder(SmartViewHolder holder, object model, int position)
            {
                holder.Text(Android.Resource.Id.Text1, Java.Lang.String.Format(Locale.China, "第%02d条数据", position));
                holder.Text(Android.Resource.Id.Text2, Java.Lang.String.Format(Locale.China, "这是测试的第%02d条数据", position));
                holder.TextColorId(Android.Resource.Id.Text2, Resource.Color.colorTextAssistant);
            }
        }

        private class SimpleOnRefreshListener : Java.Lang.Object, IOnRefreshListener
        {
            private BasicUsingActivity activity;
            public SimpleOnRefreshListener(BasicUsingActivity activity)
            {
                this.activity = activity;
            }

            public void OnRefresh(IRefreshLayout refreshLayout)
            {
                ((View)refreshLayout).PostDelayed(() => {
                    activity.mAdapter.Refresh(activity.initData);
                    refreshLayout.FinishRefresh();
                }, 2000);
            }
        }

        private class SimpleOnLoadmoreListener: Java.Lang.Object, IOnLoadmoreListener
        {
            private BasicUsingActivity activity;
            public SimpleOnLoadmoreListener(BasicUsingActivity activity)
            {
                this.activity = activity;
            }

            public void OnLoadmore(IRefreshLayout refreshLayout)
            {
                ((View)refreshLayout).PostDelayed(() => {
                    activity.mAdapter.Loadmore(activity.initData);
                    refreshLayout.FinishLoadmore();
                    if (activity.mAdapter.Count > 60)
                    {
                        Toast.MakeText(activity.Application, "数据全部加载完毕", ToastLength.Short).Show();
                        refreshLayout.SetLoadmoreFinished(true);//将不会再次触发加载更多事件
                    }
                }, 2000);
            }
        }

        private List<System.Object> initData => new List<object> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
    }
}