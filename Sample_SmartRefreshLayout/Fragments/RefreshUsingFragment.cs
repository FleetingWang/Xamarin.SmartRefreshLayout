using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Android.Support.V7.Widget;
using Java.Lang;
using Java.Lang.Reflect;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Header;
using Sample_SmartRefreshLayout.Adapters;
using Sample_SmartRefreshLayout.Activities.Using;

namespace Sample_SmartRefreshLayout.Fragments
{
    [Register("sample_smartrefreshlayout.fragments.RefreshUsingFragment")]
    public class RefreshUsingFragment : Fragment, AdapterView.IOnItemClickListener
    {
        private class ActivityInfo
        {
            public static List<ActivityInfo> List = new List<ActivityInfo>
            {
                new ActivityInfo("Basic", "基本的使用", typeof(BasicUsingActivity)),
                new ActivityInfo("DefaultCreater", "设置全局默认的Header和Footer", typeof(AssignDefaultUsingActivity)),
                new ActivityInfo("XmlDefine", "在XML中定义Header和Footer", typeof(AssignXmlUsingActivity)),
                new ActivityInfo("CodeDefine", "在代码中指定Header和Footer", typeof(AssignCodeUsingActivity)),
                new ActivityInfo("Listener", "多功能监听器", typeof(ListenerUsingActivity)),
                //// new ActivityInfo("OverScroll", "越界回弹", typeof(OverScrollUsingActivity)),
                //new ActivityInfo("NestLayout", "嵌套Layout作为内容", typeof(NestLayoutUsingActivity)),
            };
            public string Title;
            public string Name;
            public Class Clazz;
            public ActivityInfo(string title, string name, System.Type type)
            {
                Title = title;
                Name = name;
                Clazz = Class.FromType(type);
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_refresh_using, container, false);
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
                holder.Text(Android.Resource.Id.Text2, model.Name);
                holder.TextColorId(Android.Resource.Id.Text2, Resource.Color.colorTextAssistant);
            }
        }
    }
}