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
    public abstract class BaseRecyclerAdapter<T>: RecyclerView.Adapter where T: Java.Lang.Object
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
            NotifyListDataSetChanged();
            return this;
        }

        public BaseRecyclerAdapter<T> Loadmore(List<T> list)
        {
            mList.AddRange(list);
            NotifyDataSetChanged();
            NotifyListDataSetChanged();
            return this;
        }
        //</editor-fold>

        //<editor-fold desc="ListAdapter">
        private DataSetObservable mDataSetObservable = new DataSetObservable();

        public void RegisterDataSetObserver(DataSetObserver observer)
        {
            mDataSetObservable.RegisterObserver(observer);
        }

        public void UnregisterDataSetObserver(DataSetObserver observer)
        {
            mDataSetObservable.UnregisterObserver(observer);
        }

        /**
         * Notifies the attached observers that the underlying data has been changed
         * and any View reflecting the data set should refresh itself.
         */
        public void NotifyListDataSetChanged()
        {
            mDataSetObservable.NotifyChanged();
        }

        /**
         * Notifies the attached observers that the underlying data is no longer valid
         * or available. Once invoked this adapter is no longer valid and should
         * not report further data set changes.
         */
        public void notifyDataSetInvalidated()
        {
            mDataSetObservable.NotifyInvalidated();
        }


        public bool AreAllItemsEnabled()
        {
            return true;
        }

        public bool IsEnabled(int position)
        {
            return true;
        }

        public Java.Lang.Object GetItem(int position)
        {
            return mList[position];
        }

        public View GetView(int position, View convertView, ViewGroup parent)
        {
            SmartViewHolder holder;
            if (convertView != null)
            {
                holder = (SmartViewHolder)convertView.Tag;
            }
            else
            {
                holder = OnCreateViewHolder(parent, GetItemViewType(position)) as SmartViewHolder;
                convertView = holder.ItemView;
                convertView.Tag = holder;
            }
            OnBindViewHolder(holder, position);
            return convertView;
        }

        public int Count => mList.Count;

        public bool IsEmpty => Count == 0;

        public int ViewTypeCount => 1;
    }
}