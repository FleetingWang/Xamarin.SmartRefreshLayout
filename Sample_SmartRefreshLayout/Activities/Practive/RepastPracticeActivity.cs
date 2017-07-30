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
using Android.Support.V7.Widget;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Listener;
using Toast = Android.Widget.Toast;
using ToastLength = Android.Widget.ToastLength;
using Sample_SmartRefreshLayout.Utils;

namespace Sample_SmartRefreshLayout.Activities.Practive
{
    [Activity(Label = "@string/title_activity_practice_repast")]
    public class RepastPracticeActivity : AppCompatActivity
    {
        private class Model
        {
            public int imageId;
            public int avatarId;
            public string name;
            public string nickname;
        }

        private static bool isFirstEnter = true;
        private BaseRecyclerAdapter<Model> mAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_practice_repast);

            var mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };

            var mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                mRefreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果
            }

            var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetItemAnimator(new DefaultItemAnimator());
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            //recyclerView.AddItemDecoration(new DividerItemDecoration(this, DividerItemDecoration.Vertical));
            mAdapter = new CustomBaseRecyclerAdapter(loadModels(), Resource.Layout.listitem_practive_repast);
            recyclerView.SetAdapter(mAdapter);

            mRefreshLayout.SetOnRefreshLoadmoreListener(new CustomOnRefreshLoadmoreListener(this));

            //状态栏透明和间距处理
            StatusBarUtil.darkMode(this);
            StatusBarUtil.setPaddingSmart(this, recyclerView);
            StatusBarUtil.setPaddingSmart(this, mToolbar);
            StatusBarUtil.setPaddingSmart(this, FindViewById(Resource.Id.blurview));
            StatusBarUtil.setMargin(this, FindViewById(Resource.Id.gifview));
        }

        /**
         * 模拟数据
         */
        private List<Model> loadModels() {
                return new List<Model> {
                    new Model() {
                        name = "但家香酥鸭",
                        nickname = "爱过那张脸",
                        imageId = Resource.Mipmap.image_practice_repast_1,
                        avatarId = Resource.Mipmap.image_avatar_1,
                    },
                    new Model() {
                        name = "香菇蒸鸟蛋",
                        nickname = "淑女算个鸟",
                        imageId = Resource.Mipmap.image_practice_repast_2,
                        avatarId = Resource.Mipmap.image_avatar_2,
                    },
                    new Model() {
                        name = "花溪牛肉粉",
                        nickname = "性感妩媚",
                        imageId = Resource.Mipmap.image_practice_repast_3,
                        avatarId = Resource.Mipmap.image_avatar_3,
                    },
                    new Model() {
                        name = "破酥包",
                        nickname = "一丝丝纯真",
                        imageId = Resource.Mipmap.image_practice_repast_4,
                        avatarId = Resource.Mipmap.image_avatar_4,
                    },
                    new Model() {
                        name = "盐菜饭",
                        nickname = "等着你回来",
                        imageId = Resource.Mipmap.image_practice_repast_5,
                        avatarId = Resource.Mipmap.image_avatar_5,
                    },
                    new Model() {
                        name = "米豆腐",
                        nickname = "宝宝树人",
                        imageId = Resource.Mipmap.image_practice_repast_6,
                        avatarId = Resource.Mipmap.image_avatar_6,
                    },
                };
            }

        private class CustomOnRefreshLoadmoreListener : Java.Lang.Object, IOnRefreshLoadmoreListener
        {
            private RepastPracticeActivity _activity;
            public CustomOnRefreshLoadmoreListener(RepastPracticeActivity activity)
            {
                _activity = activity;
            }

            public void OnRefresh(IRefreshLayout refreshlayout)
            {
                refreshlayout.Layout.PostDelayed(() => {
                    refreshlayout.FinishRefresh();
                }, 2000);
            }

            public void OnLoadmore(IRefreshLayout refreshlayout)
            {
                refreshlayout.Layout.PostDelayed(() => {
                    _activity.mAdapter.Loadmore(_activity.loadModels());
                    refreshlayout.FinishLoadmore();
                    if (_activity.mAdapter.ItemCount > 12)
                    {
                        Toast.MakeText(_activity.Application, "数据全部加载完毕", ToastLength.Short).Show();
                        refreshlayout.SetLoadmoreFinished(true);//将不会再次触发加载更多事件
                    }
                }, 2000);
            }
        }

        private class CustomBaseRecyclerAdapter : BaseRecyclerAdapter<Model>
        {
            public CustomBaseRecyclerAdapter(List<Model> list, int layoutId)
                : base(list, layoutId)
            {

            }

            protected override void onBindViewHolder(SmartViewHolder holder, Model model, int position)
            {
                holder.Text(Resource.Id.name, model.name);
                holder.Text(Resource.Id.nickname, model.nickname);
                holder.Image(Resource.Id.image, model.imageId);
                holder.Image(Resource.Id.avatar, model.avatarId);
            }
        }
    }
}