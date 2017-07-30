using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Support.V4.App;
using Java.Lang;
using Java.Lang.Reflect;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Header;
using Sample_SmartRefreshLayout.Adapters;
using Sample_SmartRefreshLayout.Activities.Style;
using Sample_SmartRefreshLayout.Activities;

namespace Sample_SmartRefreshLayout.Fragments
{
    [Register("sample_smartrefreshlayout.fragments.RefreshStylesFragment")]
    public class RefreshStylesFragment : Fragment, AdapterView.IOnItemClickListener
    {
        private class ActivityInfo
        {
            public static List<ActivityInfo> List = new List<ActivityInfo>
            {
                new ActivityInfo("Delivery", Resource.String.title_activity_style_delivery, typeof(DeliveryStyleActivity)),
                new ActivityInfo("Dropbox", Resource.String.title_activity_style_dropbox, typeof(DropboxStyleActivity)),
                new ActivityInfo("FlyRefresh", Resource.String.title_activity_style_flyrefresh, typeof(FlyRefreshStyleActivity)),
                new ActivityInfo("WaveSwipe", Resource.String.title_activity_style_wave_swip, typeof(WaveSwipStyleActivity)),
                new ActivityInfo("WaterDrop", Resource.String.title_activity_style_water_drop, typeof(WaterDropStyleActivity)),
                new ActivityInfo("Material", Resource.String.title_activity_style_material, typeof(MaterialStyleActivity)),
                new ActivityInfo("Phoenix", Resource.String.title_activity_style_phoenix, typeof(PhoenixStyleActivity)),
                new ActivityInfo("Taurus", Resource.String.title_activity_style_taurus, typeof(TaurusStyleActivity)),
                new ActivityInfo("Bezier", Resource.String.title_activity_style_bezier, typeof(BezierStyleActivity)),
                new ActivityInfo("Circle", Resource.String.title_activity_style_circle, typeof(CircleStyleActivity)),
                new ActivityInfo("FunGameHitBlock", Resource.String.title_activity_style_fungame_hitblock, typeof(FunGameHitBlockStyleActivity)),
                new ActivityInfo("FunGameBattleCity", Resource.String.title_activity_style_fungame_battlecity, typeof(FunGameBattleCityStyleActivity)),
                new ActivityInfo("StoreHouse", Resource.String.title_activity_style_storehouse, typeof(StoreHouseStyleActivity)),
                new ActivityInfo("Classics", Resource.String.title_activity_style_classics, typeof(ClassicsStyleActivity)),
            };
            public string Title;
            public int NameId;
            public Class Clazz;
            public ActivityInfo(string title, int nameId, System.Type type)
            {
                Title = title;
                NameId = nameId;
                Clazz = Class.FromType(type);
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_refresh_styles, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            RecyclerView recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
            if (recyclerView != null)
            {
                recyclerView.SetItemAnimator(new DefaultItemAnimator());
                recyclerView.SetLayoutManager(new LinearLayoutManager(Context));
                recyclerView.AddItemDecoration(new DividerItemDecoration(Context, DividerItemDecoration.Vertical));
                recyclerView.SetAdapter(new SimpleBaseRecyclerAdapter(ActivityInfo.List, Android.Resource.Layout.SimpleListItem2, this));
            }

            view.FindViewById<View>(Resource.Id.toolbar).LongClick += (sender, e) => {
                StartActivity(new Intent(Context, typeof(ExperimentActivity)));
            };
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            ActivityInfo item = ActivityInfo.List[position];
            if (Class.FromType(typeof(Android.App.Activity)).IsAssignableFrom(item.Clazz))
            {
                StartActivity(new Intent(Context, item.Clazz));
            }
            else if (Class.FromType(typeof(IRefreshHeader)).IsAssignableFrom(item.Clazz))
            {
                try
                {
                    Constructor constructor = item.Clazz.GetConstructor(Context.Class);
                    IRefreshHeader header = (IRefreshHeader)constructor.NewInstance(Context);
                    IRefreshLayout layout = (IRefreshLayout)View.FindViewById(Resource.Id.refreshLayout);
                    layout.SetRefreshHeader(header);
                    if (!(header is ClassicsHeader))
                    {
                        layout.SetPrimaryColorsId(Resource.Color.colorPrimary, Android.Resource.Color.White);
                    }
                    layout.AutoRefresh();
                }
                catch (Exception e)
                {
                    e.PrintStackTrace();
                }
            }
        }

        private class SimpleBaseRecyclerAdapter : BaseRecyclerAdapter<ActivityInfo>
        {
            public SimpleBaseRecyclerAdapter(List<ActivityInfo> list, int layoutId, AdapterView.IOnItemClickListener listener)
                : base(list, layoutId, listener) { }
            protected override void onBindViewHolder(SmartViewHolder holder, ActivityInfo model, int position)
            {
                holder.Text(Android.Resource.Id.Text1, model.Title);
                holder.Text(Android.Resource.Id.Text2, model.NameId);
                holder.TextColorId(Android.Resource.Id.Text2, Resource.Color.colorTextAssistant);
            }
        }
    }
}