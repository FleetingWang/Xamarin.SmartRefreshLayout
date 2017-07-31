using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.Support.V7.Widget.RecyclerView;

namespace Sample.Adapters
{
    public abstract class BaseListAdapter<T>: ArrayAdapter<T> where T: class
    {
        private int mLayoutId;
        public BaseListAdapter(Context context, int layoutId)
            : base(context, layoutId)
        {
            mLayoutId = layoutId;
        }
        public BaseListAdapter(Context context, int layoutId, List<T> objects)
            :base(context, layoutId, objects)
        {
            mLayoutId = layoutId;
        }


        public BaseListAdapter<T> Refresh(List<T> list)
        {
            Clear();
            AddAll(list);
            NotifyDataSetChanged();
            return this;
        }

        public BaseListAdapter<T> Loadmore(List<T> list)
        {
            AddAll(list);
            NotifyDataSetChanged();
            return this;
        }

        protected abstract void onBindViewHolder(SmartViewHolder holder, T model, int position);

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            SmartViewHolder holder;
            if (convertView != null)
            {
                holder = (SmartViewHolder)convertView.Tag;
            }
            else
            {
                holder = new SmartViewHolder(LayoutInflater.From(parent.Context).Inflate(mLayoutId, parent, false), null);
                convertView = holder.ItemView;
                convertView.Tag = holder;
            }
            var model = position < Count ? GetItem(position) as T : null;
            onBindViewHolder(holder, model, position);
            return convertView;
        }
    }
}