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
using Com.Scwang.Smartrefresh.Header.Flyrefresh;
using Com.Scwang.Smartrefresh.Header;
using Android.Support.Design.Widget;
using Android.Animation;
using Com.Scwang.Smartrefresh.Layout.Util;
using Android.Support.V4.Content;
using Android.Content.Res;
using Android.Graphics;
using Java.Util;
using Android.Views.Animations;
using Java.Text;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using TextView = Android.Widget.TextView;
using ImageView = Android.Widget.ImageView;
using Com.Scwang.Smartrefresh.Layout.Listener;
using Sample.Utils;

using JP.Wasabeef.Recyclerview.Animators;

namespace Sample.Activities.Style
{
    [Activity(Label = "@string/title_activity_fly_refresh")]
    public class FlyRefreshStyleActivity : AppCompatActivity
    {
        private RecyclerView mListView;
        private IRefreshLayout mRefreshLayout;
        private ItemAdapter mAdapter;
        private FlyView mFlyView;
        private List<ItemData> mDataSet = new List<ItemData>();
        private LinearLayoutManager mLayoutManager;
        private MountanScenceView mScenceView;
        private FlyRefreshHeader mFlyRefreshHeader;
        private CollapsingToolbarLayout mToolbarLayout;
        private FloatingActionButton mActionButton;
        private View.IOnClickListener mThemeListener;
        private static bool isFirstEnter = true;
        private Toolbar toolbar;
        private AppBarLayout appBar;

        // AppBarLayout 的关闭和开启Flag
        private bool misAppbarExpand = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_fly_refresh);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            toolbar.NavigationClick += (sender, e) => { Finish(); };

            /************************************************************
             * 关键代码-开始
             ************************************************************/

            mFlyView = FindViewById<FlyView>(Resource.Id.flyview);
            mScenceView = FindViewById<MountanScenceView>(Resource.Id.mountan);
            mFlyRefreshHeader = FindViewById<FlyRefreshHeader>(Resource.Id.flyrefresh);
            mFlyRefreshHeader.SetUp(mScenceView, mFlyView);//绑定场景和纸飞机
            mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            mRefreshLayout.SetReboundInterpolator(new ElasticOutInterpolator());//设置回弹插值器，会带有弹簧震动效果
            mRefreshLayout.SetReboundDuration(800);//设置回弹动画时长
            mRefreshLayout.SetOnRefreshListener(new CustomOnRefreshListener(this));

            //设置 让 AppBarLayout 和 RefreshLayout 的滚动同步 并不保持 toolbar 位置不变
            appBar = FindViewById<AppBarLayout>(Resource.Id.app_bar);
            mRefreshLayout.SetOnMultiPurposeListener(new CustomOnMultiPurposeListener(this));

            /************************************************************
             * 关键代码-结束
             ************************************************************/

            mRefreshLayout = FindViewById(Resource.Id.refreshLayout) as IRefreshLayout;
            if (isFirstEnter)
            {
                isFirstEnter = false;
                mRefreshLayout.AutoRefresh();//第一次进入触发自动刷新，演示效果
            }

            /**
             * 初始化列表数据
             */
            initDataSet();
            mAdapter = new ItemAdapter(this);
            mLayoutManager = new LinearLayoutManager(this);
            mListView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mListView.SetLayoutManager(mLayoutManager);
            mListView.SetAdapter(mAdapter);
            mListView.SetItemAnimator(new SampleItemAnimator());
            mToolbarLayout = FindViewById<CollapsingToolbarLayout>(Resource.Id.toolbar_layout);
            mActionButton = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //设置点击 ActionButton 时候触发自动刷新 并改变主题颜色
            mActionButton.Click += (sender, e) => {
                updateTheme();
                mRefreshLayout.AutoRefresh();
            };

            // 监听 AppBarLayout 的关闭和开启 给 FlyView（纸飞机） 和 ActionButton 设置关闭隐藏动画
            appBar.OffsetChanged += (sender, e) => {
                var appBarLayout = e.AppBarLayout;
                var verticalOffset = e.VerticalOffset;
                int scrollRange = appBarLayout.TotalScrollRange;
                float fraction = 1f * (scrollRange + verticalOffset) / scrollRange;
                if (fraction < 0.1 && misAppbarExpand) {
                    misAppbarExpand = false;
                    mActionButton.Animate().ScaleX(0).ScaleY(0);
                    mFlyView.Animate().ScaleX(0).ScaleY(0);
                    ValueAnimator animator = ValueAnimator.OfInt(mListView.PaddingTop, 0);
                    animator.SetDuration(300);
                    animator.Update += (senderr, ee) => {
                        mListView.SetPadding(0, (int)ee.Animation.AnimatedValue, 0, 0);
                    };
                    animator.Start();
                }
                if (fraction > 0.8 && !misAppbarExpand) {
                    misAppbarExpand = true;
                    mActionButton.Animate().ScaleX(1).ScaleY(1);
                    mFlyView.Animate().ScaleX(1).ScaleY(1);
                    ValueAnimator animator = ValueAnimator.OfInt(mListView.PaddingTop, DensityUtil.Dp2px(25));
                    animator.SetDuration(300);
                    animator.Update += (senderr, ee) => {
                        mListView.SetPadding(0, (int)ee.Animation.AnimatedValue, 0, 0);
                    };
                    animator.Start();
                }
            };

            //状态栏透明和间距处理
            StatusBarUtil.immersive(this);
            StatusBarUtil.setPaddingSmart(this, toolbar);
            //        StatusBarUtil.setPaddingSmart(this, findViewById(R.id.profile));
            //        StatusBarUtil.setPaddingSmart(this, findViewById(R.id.blurview));
        }

        private void updateTheme()
        {
            if (mThemeListener == null)
            {
                mThemeListener = new ThemeOnClickListener(this);
            }
            mThemeListener.OnClick(null);
        }

        private void initDataSet()
        {
            mDataSet.Add(new ItemData(Color.ParseColor("#76A9FC"), Resource.Drawable.ic_fly_refresh_poll, "Meeting Minutes", new Date(2014 - 1900, 2, 9)));
            mDataSet.Add(new ItemData(Color.Gray, Resource.Drawable.ic_fly_refresh_folder, "Favorites Photos", new Date(2014 - 1900, 1, 3)));
            mDataSet.Add(new ItemData(Color.Gray, Resource.Drawable.ic_fly_refresh_folder, "Photos", new Date(2014 - 1900, 0, 9)));
        }

        private void addItemData()
        {
            ItemData itemData = new ItemData(Color.ParseColor("#FFC970"), Resource.Drawable.ic_fly_refresh_smartphone, "Magic Cube Show", new Date());
            mDataSet.Insert(0, itemData);
            mAdapter.NotifyItemInserted(0);
            mLayoutManager.ScrollToPosition(0);
        }

        private void bounceAnimateView(View view)
        {
            if (view == null)
            {
                return;
            }
            ValueAnimator swing = ValueAnimator.OfFloat(0, 60, -40, 0);
            swing.SetDuration(400);
            swing.SetInterpolator(new AccelerateInterpolator());
            swing.Update += (sender, e) => {
                view.RotationX = (float)e.Animation.AnimatedValue;
            };
            swing.Start();
        }

        private class CustomOnRefreshListener: Java.Lang.Object, IOnRefreshListener
        {
            private FlyRefreshStyleActivity _activity;
            public CustomOnRefreshListener(FlyRefreshStyleActivity activity)
            {
                _activity = activity;
            }

            public void OnRefresh(IRefreshLayout p0)
            {
                View child = _activity.mListView.GetChildAt(0);
                if (child != null)
                {
                    //开始刷新的时候个第一个item设置动画效果
                    _activity.bounceAnimateView(child.FindViewById(Resource.Id.icon));
                }
                _activity.updateTheme();//改变主题颜色
                _activity.mListView.PostDelayed(() => {
                    //通知刷新完成，这里改为通知Header，让纸飞机飞回来
                    _activity.mFlyRefreshHeader.FinishRefresh(new CustomAnimatorListenerAdapter(_activity));
                }, 2000);
            }
        }

        private class CustomAnimatorListenerAdapter: AnimatorListenerAdapter
        {
            private FlyRefreshStyleActivity _activity;
            public CustomAnimatorListenerAdapter(FlyRefreshStyleActivity activity)
            {
                _activity = activity;
            }

            public override void OnAnimationEnd(Animator animation)
            {
                _activity.addItemData();//在纸飞机回到原位之后添加数据效果更真实
            }
        }

        private class CustomOnMultiPurposeListener: SimpleMultiPurposeListener
        {
            private FlyRefreshStyleActivity _activity;
            public CustomOnMultiPurposeListener(FlyRefreshStyleActivity activity)
            {
                _activity = activity;
            }

            public override void OnHeaderPulling(IRefreshHeader header, float percent, int offset, int headerHeight, int extendHeight)
            {
                _activity.appBar.TranslationY = offset;
                _activity.toolbar.TranslationY = -offset;
            }

            public override void OnHeaderReleasing(IRefreshHeader header, float percent, int offset, int footerHeight, int extendHeight)
            {
                _activity.appBar.TranslationY = offset;
                _activity.toolbar.TranslationY = -offset;
            }
        }

        private class ItemAdapter: RecyclerView.Adapter
        {
            private LayoutInflater mInflater;
            private DateFormat dateFormat;
            private FlyRefreshStyleActivity _activity;

            public ItemAdapter(FlyRefreshStyleActivity activity)
            {
                _activity = activity;
                mInflater = LayoutInflater.From(activity);
                dateFormat = DateFormat.GetDateInstance(DateFormat.Default, Locale.English);
            }

            public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup viewGroup, int viewType)
            {
                View view = mInflater.Inflate(Resource.Layout.activity_fly_refresh_item, viewGroup, false);
                return new ItemViewHolder(view);
            }

            public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                var itemViewHolder = holder as ItemViewHolder;
                ItemData data = _activity.mDataSet[position];
                ShapeDrawable drawable = new ShapeDrawable(new OvalShape());
                drawable.Paint.Color = new Color(data.color);
                itemViewHolder.icon.Background = drawable;
                itemViewHolder.icon.SetImageResource(data.icon);
                itemViewHolder.title.Text = data.title;
                itemViewHolder.subTitle.Text = dateFormat.Format(data.time);
            }

            public override int ItemCount => _activity.mDataSet.Count;
        }

        private class ThemeOnClickListener : Java.Lang.Object, View.IOnClickListener
        {
            int index = 0;
            int[] ids = new int[]{
                        Resource.Color.colorPrimary,
                        Android.Resource.Color.HoloGreenLight,
                        Android.Resource.Color.HoloRedLight,
                        Android.Resource.Color.HoloOrangeLight,
                        Android.Resource.Color.HoloBlueLight,
                };

            private FlyRefreshStyleActivity _activity;
            public ThemeOnClickListener(FlyRefreshStyleActivity activity)
            {
                _activity = activity;
            }

            public void OnClick(View v)
            {
                Color color = new Color(ContextCompat.GetColor(_activity.Application, ids[index % ids.Length]));
                _activity.mRefreshLayout.SetPrimaryColors(color);
                _activity.mActionButton.SetBackgroundColor(color);
                _activity.mActionButton.BackgroundTintList = ColorStateList.ValueOf(color);
                _activity.mToolbarLayout.SetContentScrimColor(color);
                index++;
            }
        }

        private class ItemViewHolder: RecyclerView.ViewHolder
        {
            public ImageView icon;
            public TextView title;
            public TextView subTitle;

            public ItemViewHolder(View itemView)
                :base(itemView)
            {
                icon = itemView.FindViewById<ImageView>(Resource.Id.icon);
                title = itemView.FindViewById<TextView>(Resource.Id.title);
                subTitle = itemView.FindViewById<TextView>(Resource.Id.subtitle);
            }
        }

        private class ItemData
        {
            public int color;
            public int icon;
            public String title;
            public Date time;

            public ItemData(int color, int icon, String title, Date time)
            {
                this.color = color;
                this.icon = icon;
                this.title = title;
                this.time = time;
            }

            public ItemData(int icon, String title)
                :this(Color.DarkGray, icon, title, new Date())
            {
            }
        }

        public class SampleItemAnimator : BaseItemAnimator
        {
            protected override void PreAnimateAddImpl(RecyclerView.ViewHolder holder)
            {
                View icon = holder.ItemView.FindViewById(Resource.Id.icon);
                icon.RotationX = 30;
                View right = holder.ItemView.FindViewById(Resource.Id.right);
                right.PivotX = 0;
                right.PivotY = 0;
                right.RotationY = 90;
            }

            protected override void AnimateAddImpl(RecyclerView.ViewHolder holder)
            {
                View target = holder.ItemView;
                View icon = target.FindViewById(Resource.Id.icon);
                Animator swing = ObjectAnimator.OfFloat(icon, "rotationX", 45, 0);
                swing.SetInterpolator(new OvershootInterpolator(5));

                View right = holder.ItemView.FindViewById(Resource.Id.right);
                Animator rotateIn = ObjectAnimator.OfFloat(right, "rotationY", 90, 0);
                rotateIn.SetInterpolator(new DecelerateInterpolator());

                AnimatorSet animator = new AnimatorSet();
                animator.SetDuration(AddDuration);
                animator.PlayTogether(swing, rotateIn);

                animator.Start();
            }

            protected override void AnimateRemoveImpl(RecyclerView.ViewHolder p0)
            {
            }
        }

        private class ElasticOutInterpolator : Java.Lang.Object, IInterpolator
        {
            public float GetInterpolation(float t)
            {
                if (t == 0) return 0;
                if (t >= 1) return 1;
                float p = .3f;
                float s = p / 4;
                return ((float)Math.Pow(2, -10 * t) * (float)Math.Sin((t - s) * (2 * (float)Math.PI) / p) + 1);
            }
        }
    }
}