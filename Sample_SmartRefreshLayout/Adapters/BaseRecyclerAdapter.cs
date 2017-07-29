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
using Android.Support.V7.Widget;
using Android.Database;
using Java.Lang;

namespace Sample_SmartRefreshLayout.Adapters
{
    public abstract class BaseRecyclerAdapter<T>: RecyclerView.Adapter where T: class
    {
        private int mLayoutId;
        private List<T> mList;
        private AdapterView.IOnItemClickListener mListener;

        public BaseRecyclerAdapter(int layoutId)
        {
            HasStableIds = false;
            mList = new List<T>();
            mLayoutId = layoutId;
        }

        public BaseRecyclerAdapter(List<T> list, int layoutId)
        {
            HasStableIds = false;
            this.mList = list;
            this.mLayoutId = layoutId;
        }

        public BaseRecyclerAdapter(List<T> list, int layoutId, AdapterView.IOnItemClickListener listener)
        {
            HasStableIds = false;
            setOnItemClickListener(listener);
            this.mList = list;
            this.mLayoutId = layoutId;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return new SmartViewHolder(LayoutInflater.From(parent.Context).Inflate(mLayoutId, parent, false), mListener);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            onBindViewHolder(holder as SmartViewHolder, position < mList.Count ? mList[position] : null, position);
        }

        protected abstract void onBindViewHolder(SmartViewHolder holder, T model, int position);

        public override int ItemCount => mList.Count;

        public BaseRecyclerAdapter<T> setOnItemClickListener(AdapterView.IOnItemClickListener listener)
        {
            mListener = listener;
            return this;
        }

        public BaseRecyclerAdapter<T> Refresh(List<T> list)
        {
            mList.Clear();
            mList.AddRange(list);
            NotifyDataSetChanged();
            return this;
        }

        public BaseRecyclerAdapter<T> Loadmore(List<T> list)
        {
            mList.AddRange(list);
            NotifyDataSetChanged();
            return this;
        }
    }
}