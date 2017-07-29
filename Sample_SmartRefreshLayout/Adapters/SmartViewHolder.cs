using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.Widget;
using Android.Widget;
using static Android.Widget.AdapterView;
using Android.Util;
using Android.Support.V4.Content;
using Android.Graphics;

namespace Sample_SmartRefreshLayout.Adapters
{
    public class SmartViewHolder: RecyclerView.ViewHolder
    {
        private IOnItemClickListener mListener;

        public SmartViewHolder(View itemView, IOnItemClickListener mListener)
            :base(itemView)
        {
            this.mListener = mListener;
            itemView.Click += (sender, e) => {
                if (mListener != null)
                {
                    int position = AdapterPosition;
                    if (position >= 0)
                    {
                        mListener.OnItemClick(null, itemView, position, ItemId);
                    }
                }
            };

            // TODO: 设置水波纹背景
            if(itemView.Background == null)
            {
                TypedValue typedValue = new TypedValue();
                if (itemView.Context.Theme.ResolveAttribute(Android.Resource.Attribute.SelectableItemBackground, typedValue, true))
                {
                    itemView.SetBackgroundResource(typedValue.ResourceId);
                }
                itemView.SetPadding(itemView.PaddingLeft, itemView.PaddingTop, itemView.PaddingRight, itemView.PaddingBottom);
            }
        }

        public SmartViewHolder Text(int id, string str)
        {
            TextView view = ItemView.FindViewById<TextView>(id);
            if(view != null)
            {
                view.Text = str;
            }
            return this;
        }

        public SmartViewHolder Text(int id, int stringRes)
        {
            TextView view = ItemView.FindViewById<TextView>(id);
            if (view != null) {
                view.SetText(stringRes);
            }
            return this;
        }

        public SmartViewHolder TextColorId(int id, int colorId)
        {
            TextView view = ItemView.FindViewById<TextView>(id);
            if (view != null) {
                view.SetTextColor(new Color(ContextCompat.GetColor(view.Context, colorId)));
            }
            return this;
        }

        public SmartViewHolder Image(int id, int imageId)
        {
            ImageView view = ItemView.FindViewById<ImageView>(id);
            if (view != null) {
                view.SetImageResource(imageId);
            }
            return this;
        }
    }
}