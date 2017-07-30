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
using static Android.Widget.AdapterView;
using AdapterView = Android.Widget.AdapterView;
using Android.Support.V4.Content;
using Sample_SmartRefreshLayout.Adapters;

namespace Sample_SmartRefreshLayout.Activities.Style
{
    [Activity(Label = "@string/title_activity_style_dropbox")]
    public class DropboxStyleActivity : AppCompatActivity, IOnItemClickListener
    {
        private class Item
        {
            // switch case
            public const string 默认主题 = "默认主题";
            public const string 橙色主题 = "橙色主题";
            public const string 红色主题 = "红色主题";
            public const string 绿色主题 = "绿色主题";
            public const string 蓝色主题 = "蓝色主题";
            public static List<Item> List = new List<Item>{
                new Item(默认主题, "更改为默认主题颜色"),
                new Item(橙色主题, "更改为橙色主题颜色"),
                new Item(红色主题, "更改为红色主题颜色"),
                new Item(绿色主题, "更改为绿色主题颜色"),
                new Item(蓝色主题, "更改为蓝色主题颜色"),
            };
            public Item(string title, string name)
            {
                Title = title;
                Name = name;
            }
            public string Title;
            public string Name;
        }

        private Toolbar mToolbar;
        private IRefreshLayout mRefreshLayout;
        private static bool isFirstEnter = true;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_style_dropbox);

            mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };

            mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                mRefreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果
            }

            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetItemAnimator(new DefaultItemAnimator());
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.AddItemDecoration(new DividerItemDecoration(this, DividerItemDecoration.Vertical));
            recyclerView.SetAdapter(new CustomBaseRecyclerAdapter(Item.List, Android.Resource.Layout.SimpleListItem2, this));
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            switch (Item.List[position].Title)
            {
                case Item.默认主题:
                    setThemeColor(Resource.Color.colorPrimary, Resource.Color.colorPrimaryDark);
                    mRefreshLayout.SetPrimaryColors(0x283645, 0x6ea9ff);
                    break;
                case Item.蓝色主题:
                    setThemeColor(Resource.Color.colorPrimary, Resource.Color.colorPrimaryDark);
                    break;
                case Item.绿色主题:
                    setThemeColor(Android.Resource.Color.HoloGreenLight, Android.Resource.Color.HoloGreenDark);
                    break;
                case Item.红色主题:
                    setThemeColor(Android.Resource.Color.HoloRedLight, Android.Resource.Color.HoloRedDark);
                    break;
                case Item.橙色主题:
                    setThemeColor(Android.Resource.Color.HoloOrangeLight, Android.Resource.Color.HoloOrangeDark);
                    break;
            }
            mRefreshLayout.AutoRefresh();
        }

        private void setThemeColor(int colorPrimary, int colorPrimaryDark)
        {
            mToolbar.SetBackgroundResource(colorPrimary);
            mRefreshLayout.SetPrimaryColorsId(colorPrimary, Android.Resource.Color.White);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) //21
            {
                Window.SetStatusBarColor(new Android.Graphics.Color(ContextCompat.GetColor(this, colorPrimaryDark)));
            }
        }

        private class CustomBaseRecyclerAdapter : BaseRecyclerAdapter<Item>
        {
            public CustomBaseRecyclerAdapter(List<Item> list, int layoutId, IOnItemClickListener listener)
                : base(list, layoutId, listener)
            {

            }

            protected override void onBindViewHolder(SmartViewHolder holder, Item model, int position)
            {
                holder.Text(Android.Resource.Id.Text1, model.Title);
                holder.Text(Android.Resource.Id.Text2, model.Name);
                holder.TextColorId(Android.Resource.Id.Text2, Resource.Color.colorTextAssistant);
            }
        }
    }
}