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
using Sample_SmartRefreshLayout.Adapters;
using static Android.Widget.AdapterView;
using TextView = Android.Widget.TextView;

namespace Sample_SmartRefreshLayout.Activities.Using
{
    [Activity(Label = "NestLayoutUsingActivity")]
    public class NestLayoutUsingActivity : AppCompatActivity, IOnItemClickListener
    {
        private static List<string> provinces = new List<string>{
            "北京","天津","上海","重庆",
            "黑龙江","吉林","辽宁","河北","河南","山东","江苏","山西","陕西","甘肃","四川","青海","湖南","湖北","江西","安徽","浙江","福建","广东","广西","贵州","云南","海南",
            "内蒙古","新疆维吾尔族自治区","宁夏回族自治区","西藏","宁夏回族自治区",
            "香港","澳门"
        };
        private static bool isFirstEnter = true;

        public void OnItemClick(Android.Widget.AdapterView parent, View view, int position, long id)
        {
            var textView = FindViewById<TextView>(Resource.Id.region);
            textView.Text = provinces[position];
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_using_region);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetItemAnimator(new DefaultItemAnimator());
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.AddItemDecoration(new DividerItemDecoration(this, DividerItemDecoration.Vertical));
            recyclerView.SetAdapter(new CustomBaseRecyclerAdapter(provinces, Android.Resource.Layout.SimpleListItem1)
                .setOnItemClickListener(this));
            
            /**
             * 以下代码仅仅为了演示效果而已，不是必须的
             * 关键代码在 activity_using_assign_xml 中
             */
            var refreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter && refreshLayout != null)
            {
                isFirstEnter = false;
                //触发上啦加载
                refreshLayout.AutoRefresh();
            }
        }

        private class CustomBaseRecyclerAdapter: BaseRecyclerAdapter<string>
        {
            public CustomBaseRecyclerAdapter(List<string> list, int layoutId)
                :base(list, layoutId)
            {

            }

            protected override void onBindViewHolder(SmartViewHolder holder, string model, int position)
            {
                holder.Text(Android.Resource.Id.Text1, model);
            }
        }
    }
}