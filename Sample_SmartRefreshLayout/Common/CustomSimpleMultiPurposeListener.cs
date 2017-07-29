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
using Com.Scwang.Smartrefresh.Layout.Listener;
using Com.Scwang.Smartrefresh.Layout.Api;
using Com.Scwang.Smartrefresh.Layout.Constant;

namespace Sample_SmartRefreshLayout.Common
{
    public class CustomSimpleMultiPurposeListener : SimpleMultiPurposeListener
    {
        public override void OnStateChanged(IRefreshLayout refreshLayout, RefreshState oldState, RefreshState newState)
        {
            if (oldState == RefreshState.LoadFinish && newState == RefreshState.None)
            {
                refreshLayout.AutoRefresh();
                refreshLayout.SetOnMultiPurposeListener(null);
            }
        }
    }
}