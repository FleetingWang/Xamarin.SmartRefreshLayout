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
using Android.Support.Design.Widget;
using Android.Content.Res;

namespace Sample_SmartRefreshLayout.Activities.Style
{
    [Activity(Label = "@string/title_activity_style_phoenix")]
    public class PhoenixStyleActivity : AppCompatActivity, IOnItemClickListener
    {
        private class Item
        {
            // switch case
            public const string 折叠 = "折叠";
            public const string 展开 = "展开";
            public const string 橙色主题 = "橙色主题";
            public const string 红色主题 = "红色主题";
            public const string 绿色主题 = "绿色主题";
            public const string 蓝色主题 = "蓝色主题";
            public static List<Item> List = new List<Item>{
                new Item(折叠, "折叠AppBarLayout，变成正常的列表页面"),
                new Item(展开, "展开AppBarLayout，变成可伸展头部的页面"),
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

        private IRefreshLayout mRefreshLayout;
        private Toolbar mToolbar;
        private RecyclerView mRecyclerView;
        private AppBarLayout mAppBarLayout;
        private FloatingActionButton mActionButton;
        private CollapsingToolbarLayout mToolbarLayout;
        private static bool isFirstEnter = true;

        // AppBarLayout 的关闭和开启Flag
        private bool misAppbarExpand = true;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_style_phoenix);

            mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };

            mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                mRefreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果
            }

            mAppBarLayout = FindViewById<AppBarLayout>(Resource.Id.app_bar);
            mToolbarLayout = FindViewById<CollapsingToolbarLayout>(Resource.Id.toolbar_layout);

            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetItemAnimator(new DefaultItemAnimator());
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.AddItemDecoration(new DividerItemDecoration(this, DividerItemDecoration.Vertical));
            recyclerView.SetAdapter(new CustomBaseRecyclerAdapter(Item.List, Android.Resource.Layout.SimpleListItem2, this));

            // 监听 AppBarLayout 的关闭和开启 给 FlyView（纸飞机） 和 ActionButton 设置关闭隐藏动画
            mActionButton = FindViewById<FloatingActionButton>(Resource.Id.fab);
            mAppBarLayout.OffsetChanged += (sender, e) => {
                var appBarLayout = e.AppBarLayout;
                var verticalOffset = e.VerticalOffset;
                int scrollRange = appBarLayout.TotalScrollRange;
                float fraction = 1f * (scrollRange + verticalOffset) / scrollRange;
                if (fraction < 0.1 && misAppbarExpand)
                {
                    misAppbarExpand = false;
                    mActionButton.Animate().ScaleX(0).ScaleY(0);
                }
                if (fraction > 0.8 && !misAppbarExpand)
                {
                    misAppbarExpand = true;
                    mActionButton.Animate().ScaleX(1).ScaleY(1);
                }
            };
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            switch (Item.List[position].Title)
            {
                case Item.折叠:
                    mAppBarLayout.SetExpanded(false, true);
                    mAppBarLayout.Enabled = false;
                    mRefreshLayout.SetEnableHeaderTranslationContent(false);
                    break;
                case Item.展开:
                    mAppBarLayout.SetExpanded(true, true);
                    mAppBarLayout.Enabled = true;
                    mRefreshLayout.SetEnableHeaderTranslationContent(true);
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
            mAppBarLayout.SetBackgroundResource(colorPrimary);
            mToolbarLayout.SetContentScrimResource(colorPrimary);
            mRefreshLayout.SetPrimaryColorsId(colorPrimary, Android.Resource.Color.White);
            var color = new Android.Graphics.Color(ContextCompat.GetColor(this, colorPrimaryDark));
            mActionButton.SetBackgroundColor(color);
            mActionButton.BackgroundTintList = ColorStateList.ValueOf(color);
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