using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/SmartRefreshLayout", DoNotGenerateAcw=true)]
	public partial class SmartRefreshLayout : global::Android.Views.ViewGroup, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDisableContentWhenLoading']"
		[Register ("mDisableContentWhenLoading")]
		protected bool MDisableContentWhenLoading {
			get {
				const string __id = "mDisableContentWhenLoading.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDisableContentWhenLoading.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDisableContentWhenRefresh']"
		[Register ("mDisableContentWhenRefresh")]
		protected bool MDisableContentWhenRefresh {
			get {
				const string __id = "mDisableContentWhenRefresh.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDisableContentWhenRefresh.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mDragRate']"
		[Register ("mDragRate")]
		protected float MDragRate {
			get {
				const string __id = "mDragRate.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDragRate.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableAutoLoadmore']"
		[Register ("mEnableAutoLoadmore")]
		protected bool MEnableAutoLoadmore {
			get {
				const string __id = "mEnableAutoLoadmore.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableAutoLoadmore.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableFooterTranslationContent']"
		[Register ("mEnableFooterTranslationContent")]
		protected bool MEnableFooterTranslationContent {
			get {
				const string __id = "mEnableFooterTranslationContent.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableFooterTranslationContent.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableHeaderTranslationContent']"
		[Register ("mEnableHeaderTranslationContent")]
		protected bool MEnableHeaderTranslationContent {
			get {
				const string __id = "mEnableHeaderTranslationContent.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableHeaderTranslationContent.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableLoadmore']"
		[Register ("mEnableLoadmore")]
		protected bool MEnableLoadmore {
			get {
				const string __id = "mEnableLoadmore.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableLoadmore.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableOverScrollBounce']"
		[Register ("mEnableOverScrollBounce")]
		protected bool MEnableOverScrollBounce {
			get {
				const string __id = "mEnableOverScrollBounce.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableOverScrollBounce.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnablePreviewInEditMode']"
		[Register ("mEnablePreviewInEditMode")]
		protected bool MEnablePreviewInEditMode {
			get {
				const string __id = "mEnablePreviewInEditMode.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnablePreviewInEditMode.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnablePureScrollMode']"
		[Register ("mEnablePureScrollMode")]
		protected bool MEnablePureScrollMode {
			get {
				const string __id = "mEnablePureScrollMode.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnablePureScrollMode.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableRefresh']"
		[Register ("mEnableRefresh")]
		protected bool MEnableRefresh {
			get {
				const string __id = "mEnableRefresh.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableRefresh.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mEnableScrollContentWhenLoaded']"
		[Register ("mEnableScrollContentWhenLoaded")]
		protected bool MEnableScrollContentWhenLoaded {
			get {
				const string __id = "mEnableScrollContentWhenLoaded.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnableScrollContentWhenLoaded.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFixedFooterView']"
		[Register ("mFixedFooterView")]
		protected global::Android.Views.View MFixedFooterView {
			get {
				const string __id = "mFixedFooterView.Landroid/view/View;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFixedFooterView.Landroid/view/View;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFixedFooterViewId']"
		[Register ("mFixedFooterViewId")]
		protected int MFixedFooterViewId {
			get {
				const string __id = "mFixedFooterViewId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFixedFooterViewId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFixedHeaderView']"
		[Register ("mFixedHeaderView")]
		protected global::Android.Views.View MFixedHeaderView {
			get {
				const string __id = "mFixedHeaderView.Landroid/view/View;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFixedHeaderView.Landroid/view/View;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFixedHeaderViewId']"
		[Register ("mFixedHeaderViewId")]
		protected int MFixedHeaderViewId {
			get {
				const string __id = "mFixedHeaderViewId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFixedHeaderViewId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterBackgroundColor']"
		[Register ("mFooterBackgroundColor")]
		protected int MFooterBackgroundColor {
			get {
				const string __id = "mFooterBackgroundColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFooterBackgroundColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterCreater']"
		[Register ("mFooterCreater")]
		protected static global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreater MFooterCreater {
			get {
				const string __id = "mFooterCreater.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreater> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFooterCreater.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterExtendHeight']"
		[Register ("mFooterExtendHeight")]
		protected int MFooterExtendHeight {
			get {
				const string __id = "mFooterExtendHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFooterExtendHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterHeight']"
		[Register ("mFooterHeight")]
		protected int MFooterHeight {
			get {
				const string __id = "mFooterHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFooterHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterHeightStatus']"
		[Register ("mFooterHeightStatus")]
		protected global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus MFooterHeightStatus {
			get {
				const string __id = "mFooterHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFooterHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mFooterMaxDragRate']"
		[Register ("mFooterMaxDragRate")]
		protected float MFooterMaxDragRate {
			get {
				const string __id = "mFooterMaxDragRate.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mFooterMaxDragRate.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderBackgroundColor']"
		[Register ("mHeaderBackgroundColor")]
		protected int MHeaderBackgroundColor {
			get {
				const string __id = "mHeaderBackgroundColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeaderBackgroundColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderCreater']"
		[Register ("mHeaderCreater")]
		protected static global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshHeaderCreater MHeaderCreater {
			get {
				const string __id = "mHeaderCreater.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreater;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshHeaderCreater> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHeaderCreater.Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreater;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderExtendHeight']"
		[Register ("mHeaderExtendHeight")]
		protected int MHeaderExtendHeight {
			get {
				const string __id = "mHeaderExtendHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeaderExtendHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderHeight']"
		[Register ("mHeaderHeight")]
		protected int MHeaderHeight {
			get {
				const string __id = "mHeaderHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeaderHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderHeightStatus']"
		[Register ("mHeaderHeightStatus")]
		protected global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus MHeaderHeightStatus {
			get {
				const string __id = "mHeaderHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.DimensionStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHeaderHeightStatus.Lcom/scwang/smartrefresh/layout/constant/DimensionStatus;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mHeaderMaxDragRate']"
		[Register ("mHeaderMaxDragRate")]
		protected float MHeaderMaxDragRate {
			get {
				const string __id = "mHeaderMaxDragRate.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeaderMaxDragRate.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mInitialMotionY']"
		[Register ("mInitialMotionY")]
		protected float MInitialMotionY {
			get {
				const string __id = "mInitialMotionY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mInitialMotionY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mKernel']"
		[Register ("mKernel")]
		protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MKernel {
			get {
				const string __id = "mKernel.Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mKernel.Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastLoadingTime']"
		[Register ("mLastLoadingTime")]
		protected long MLastLoadingTime {
			get {
				const string __id = "mLastLoadingTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mLastLoadingTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastRefreshingTime']"
		[Register ("mLastRefreshingTime")]
		protected long MLastRefreshingTime {
			get {
				const string __id = "mLastRefreshingTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mLastRefreshingTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLastTouchX']"
		[Register ("mLastTouchX")]
		protected float MLastTouchX {
			get {
				const string __id = "mLastTouchX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLastTouchX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLoadmoreFinished']"
		[Register ("mLoadmoreFinished")]
		protected bool MLoadmoreFinished {
			get {
				const string __id = "mLoadmoreFinished.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLoadmoreFinished.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mLoadmoreListener']"
		[Register ("mLoadmoreListener")]
		protected global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener MLoadmoreListener {
			get {
				const string __id = "mLoadmoreListener.Lcom/scwang/smartrefresh/layout/listener/OnLoadmoreListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLoadmoreListener.Lcom/scwang/smartrefresh/layout/listener/OnLoadmoreListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mNestedScrollInProgress']"
		[Register ("mNestedScrollInProgress")]
		protected bool MNestedScrollInProgress {
			get {
				const string __id = "mNestedScrollInProgress.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mNestedScrollInProgress.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mNestedScrollingChildHelper']"
		[Register ("mNestedScrollingChildHelper")]
		protected global::Android.Support.V4.View.NestedScrollingChildHelper MNestedScrollingChildHelper {
			get {
				const string __id = "mNestedScrollingChildHelper.Landroid/support/v4/view/NestedScrollingChildHelper;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.NestedScrollingChildHelper> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mNestedScrollingChildHelper.Landroid/support/v4/view/NestedScrollingChildHelper;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mNestedScrollingParentHelper']"
		[Register ("mNestedScrollingParentHelper")]
		protected global::Android.Support.V4.View.NestedScrollingParentHelper MNestedScrollingParentHelper {
			get {
				const string __id = "mNestedScrollingParentHelper.Landroid/support/v4/view/NestedScrollingParentHelper;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.NestedScrollingParentHelper> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mNestedScrollingParentHelper.Landroid/support/v4/view/NestedScrollingParentHelper;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mOnMultiPurposeListener']"
		[Register ("mOnMultiPurposeListener")]
		protected global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener MOnMultiPurposeListener {
			get {
				const string __id = "mOnMultiPurposeListener.Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mOnMultiPurposeListener.Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mPaint']"
		[Register ("mPaint")]
		protected global::Android.Graphics.Paint MPaint {
			get {
				const string __id = "mPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mParentOffsetInWindow']"
		[Register ("mParentOffsetInWindow")]
		protected IList<int> MParentOffsetInWindow {
			get {
				const string __id = "mParentOffsetInWindow.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mParentOffsetInWindow.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mParentScrollConsumed']"
		[Register ("mParentScrollConsumed")]
		protected IList<int> MParentScrollConsumed {
			get {
				const string __id = "mParentScrollConsumed.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mParentScrollConsumed.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mPrimaryColors']"
		[Register ("mPrimaryColors")]
		protected IList<int> MPrimaryColors {
			get {
				const string __id = "mPrimaryColors.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPrimaryColors.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mReboundDuration']"
		[Register ("mReboundDuration")]
		protected int MReboundDuration {
			get {
				const string __id = "mReboundDuration.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mReboundDuration.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mReboundInterpolator']"
		[Register ("mReboundInterpolator")]
		protected global::Android.Views.Animations.IInterpolator MReboundInterpolator {
			get {
				const string __id = "mReboundInterpolator.Landroid/view/animation/Interpolator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mReboundInterpolator.Landroid/view/animation/Interpolator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshContent']"
		[Register ("mRefreshContent")]
		protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent MRefreshContent {
			get {
				const string __id = "mRefreshContent.Lcom/scwang/smartrefresh/layout/api/RefreshContent;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRefreshContent.Lcom/scwang/smartrefresh/layout/api/RefreshContent;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshFooter']"
		[Register ("mRefreshFooter")]
		protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter MRefreshFooter {
			get {
				const string __id = "mRefreshFooter.Lcom/scwang/smartrefresh/layout/api/RefreshFooter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRefreshFooter.Lcom/scwang/smartrefresh/layout/api/RefreshFooter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshHeader']"
		[Register ("mRefreshHeader")]
		protected global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader MRefreshHeader {
			get {
				const string __id = "mRefreshHeader.Lcom/scwang/smartrefresh/layout/api/RefreshHeader;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRefreshHeader.Lcom/scwang/smartrefresh/layout/api/RefreshHeader;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mRefreshListener']"
		[Register ("mRefreshListener")]
		protected global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener MRefreshListener {
			get {
				const string __id = "mRefreshListener.Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRefreshListener.Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mScreenHeightPixels']"
		[Register ("mScreenHeightPixels")]
		protected int MScreenHeightPixels {
			get {
				const string __id = "mScreenHeightPixels.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mScreenHeightPixels.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mSpinner']"
		[Register ("mSpinner")]
		protected int MSpinner {
			get {
				const string __id = "mSpinner.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mSpinner.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mState']"
		[Register ("mState")]
		protected global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState MState {
			get {
				const string __id = "mState.Lcom/scwang/smartrefresh/layout/constant/RefreshState;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mState.Lcom/scwang/smartrefresh/layout/constant/RefreshState;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTotalUnconsumed']"
		[Register ("mTotalUnconsumed")]
		protected int MTotalUnconsumed {
			get {
				const string __id = "mTotalUnconsumed.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTotalUnconsumed.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchSlop']"
		[Register ("mTouchSlop")]
		protected int MTouchSlop {
			get {
				const string __id = "mTouchSlop.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTouchSlop.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchX']"
		[Register ("mTouchX")]
		protected float MTouchX {
			get {
				const string __id = "mTouchX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTouchX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='mTouchY']"
		[Register ("mTouchY")]
		protected float MTouchY {
			get {
				const string __id = "mTouchY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTouchY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='reboundAnimator']"
		[Register ("reboundAnimator")]
		protected global::Android.Animation.ValueAnimator ReboundAnimator {
			get {
				const string __id = "reboundAnimator.Landroid/animation/ValueAnimator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "reboundAnimator.Landroid/animation/ValueAnimator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='reboundAnimatorEndListener']"
		[Register ("reboundAnimatorEndListener")]
		protected global::Android.Animation.Animator.IAnimatorListener ReboundAnimatorEndListener {
			get {
				const string __id = "reboundAnimatorEndListener.Landroid/animation/Animator$AnimatorListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator.IAnimatorListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "reboundAnimatorEndListener.Landroid/animation/Animator$AnimatorListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/field[@name='reboundUpdateListener']"
		[Register ("reboundUpdateListener")]
		protected global::Android.Animation.ValueAnimator.IAnimatorUpdateListener ReboundUpdateListener {
			get {
				const string __id = "reboundUpdateListener.Landroid/animation/ValueAnimator$AnimatorUpdateListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator.IAnimatorUpdateListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "reboundUpdateListener.Landroid/animation/ValueAnimator$AnimatorUpdateListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']"
		[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/SmartRefreshLayout$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams {

			internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/SmartRefreshLayout$LayoutParams", typeof (LayoutParams));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/constructor[@name='SmartRefreshLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context c, global::Android.Util.IAttributeSet attrs)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
					__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/constructor[@name='SmartRefreshLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$LayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/constructor[@name='SmartRefreshLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.MarginLayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.MarginLayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$MarginLayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.LayoutParams']/constructor[@name='SmartRefreshLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']"
		[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/SmartRefreshLayout$RefreshKernelImpl", DoNotGenerateAcw=true)]
		protected internal partial class RefreshKernelImpl : global::Java.Lang.Object, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel {

			internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/SmartRefreshLayout$RefreshKernelImpl", typeof (RefreshKernelImpl));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected RefreshKernelImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/constructor[@name='SmartRefreshLayout.RefreshKernelImpl' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.SmartRefreshLayout']]"
			[Register (".ctor", "(Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;)V", "")]
			protected unsafe RefreshKernelImpl (global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getRefreshContent;
#pragma warning disable 0169
			static Delegate GetGetRefreshContentHandler ()
			{
				if (cb_getRefreshContent == null)
					cb_getRefreshContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshContent);
				return cb_getRefreshContent;
			}

			static IntPtr n_GetRefreshContent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RefreshContent);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent RefreshContent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='getRefreshContent' and count(parameter)=0]"
				[Register ("getRefreshContent", "()Lcom/scwang/smartrefresh/layout/api/RefreshContent;", "GetGetRefreshContentHandler")]
				get {
					const string __id = "getRefreshContent.()Lcom/scwang/smartrefresh/layout/api/RefreshContent;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRefreshLayout;
#pragma warning disable 0169
			static Delegate GetGetRefreshLayoutHandler ()
			{
				if (cb_getRefreshLayout == null)
					cb_getRefreshLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshLayout);
				return cb_getRefreshLayout;
			}

			static IntPtr n_GetRefreshLayout (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RefreshLayout);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout RefreshLayout {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='getRefreshLayout' and count(parameter)=0]"
				[Register ("getRefreshLayout", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetGetRefreshLayoutHandler")]
				get {
					const string __id = "getRefreshLayout.()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSpinner;
#pragma warning disable 0169
			static Delegate GetGetSpinnerHandler ()
			{
				if (cb_getSpinner == null)
					cb_getSpinner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpinner);
				return cb_getSpinner;
			}

			static int n_GetSpinner (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Spinner;
			}
#pragma warning restore 0169

			public virtual unsafe int Spinner {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='getSpinner' and count(parameter)=0]"
				[Register ("getSpinner", "()I", "GetGetSpinnerHandler")]
				get {
					const string __id = "getSpinner.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_animSpinner_I;
#pragma warning disable 0169
			static Delegate GetAnimSpinner_IHandler ()
			{
				if (cb_animSpinner_I == null)
					cb_animSpinner_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnimSpinner_I);
				return cb_animSpinner_I;
			}

			static IntPtr n_AnimSpinner_I (IntPtr jnienv, IntPtr native__this, int endSpinner)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnimSpinner (endSpinner));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='animSpinner' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("animSpinner", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetAnimSpinner_IHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel AnimSpinner (int endSpinner)
			{
				const string __id = "animSpinner.(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (endSpinner);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_animSpinnerBounce_I;
#pragma warning disable 0169
			static Delegate GetAnimSpinnerBounce_IHandler ()
			{
				if (cb_animSpinnerBounce_I == null)
					cb_animSpinnerBounce_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnimSpinnerBounce_I);
				return cb_animSpinnerBounce_I;
			}

			static IntPtr n_AnimSpinnerBounce_I (IntPtr jnienv, IntPtr native__this, int bounceSpinner)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnimSpinnerBounce (bounceSpinner));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='animSpinnerBounce' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("animSpinnerBounce", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetAnimSpinnerBounce_IHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel AnimSpinnerBounce (int bounceSpinner)
			{
				const string __id = "animSpinnerBounce.(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bounceSpinner);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_moveSpinner_IZ;
#pragma warning disable 0169
			static Delegate GetMoveSpinner_IZHandler ()
			{
				if (cb_moveSpinner_IZ == null)
					cb_moveSpinner_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_MoveSpinner_IZ);
				return cb_moveSpinner_IZ;
			}

			static IntPtr n_MoveSpinner_IZ (IntPtr jnienv, IntPtr native__this, int spinner, bool isAnimator)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MoveSpinner (spinner, isAnimator));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='moveSpinner' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("moveSpinner", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetMoveSpinner_IZHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinner (int spinner, bool isAnimator)
			{
				const string __id = "moveSpinner.(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (spinner);
					__args [1] = new JniArgumentValue (isAnimator);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_moveSpinnerInfinitely_F;
#pragma warning disable 0169
			static Delegate GetMoveSpinnerInfinitely_FHandler ()
			{
				if (cb_moveSpinnerInfinitely_F == null)
					cb_moveSpinnerInfinitely_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_MoveSpinnerInfinitely_F);
				return cb_moveSpinnerInfinitely_F;
			}

			static IntPtr n_MoveSpinnerInfinitely_F (IntPtr jnienv, IntPtr native__this, float dy)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MoveSpinnerInfinitely (dy));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='moveSpinnerInfinitely' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("moveSpinnerInfinitely", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetMoveSpinnerInfinitely_FHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinnerInfinitely (float dy)
			{
				const string __id = "moveSpinnerInfinitely.(F)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (dy);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_overSpinner;
#pragma warning disable 0169
			static Delegate GetOverSpinnerHandler ()
			{
				if (cb_overSpinner == null)
					cb_overSpinner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OverSpinner);
				return cb_overSpinner;
			}

			static IntPtr n_OverSpinner (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.OverSpinner ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='overSpinner' and count(parameter)=0]"
			[Register ("overSpinner", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetOverSpinnerHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel OverSpinner ()
			{
				const string __id = "overSpinner.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_requestDrawBackgoundForFooter_I;
#pragma warning disable 0169
			static Delegate GetRequestDrawBackgoundForFooter_IHandler ()
			{
				if (cb_requestDrawBackgoundForFooter_I == null)
					cb_requestDrawBackgoundForFooter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RequestDrawBackgoundForFooter_I);
				return cb_requestDrawBackgoundForFooter_I;
			}

			static IntPtr n_RequestDrawBackgoundForFooter_I (IntPtr jnienv, IntPtr native__this, int backgroundColor)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RequestDrawBackgoundForFooter (backgroundColor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestDrawBackgoundForFooter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("requestDrawBackgoundForFooter", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestDrawBackgoundForFooter_IHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgoundForFooter (int backgroundColor)
			{
				const string __id = "requestDrawBackgoundForFooter.(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_requestDrawBackgoundForHeader_I;
#pragma warning disable 0169
			static Delegate GetRequestDrawBackgoundForHeader_IHandler ()
			{
				if (cb_requestDrawBackgoundForHeader_I == null)
					cb_requestDrawBackgoundForHeader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RequestDrawBackgoundForHeader_I);
				return cb_requestDrawBackgoundForHeader_I;
			}

			static IntPtr n_RequestDrawBackgoundForHeader_I (IntPtr jnienv, IntPtr native__this, int backgroundColor)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RequestDrawBackgoundForHeader (backgroundColor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='requestDrawBackgoundForHeader' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("requestDrawBackgoundForHeader", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestDrawBackgoundForHeader_IHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgoundForHeader (int backgroundColor)
			{
				const string __id = "requestDrawBackgoundForHeader.(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (backgroundColor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_resetStatus;
#pragma warning disable 0169
			static Delegate GetResetStatusHandler ()
			{
				if (cb_resetStatus == null)
					cb_resetStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ResetStatus);
				return cb_resetStatus;
			}

			static IntPtr n_ResetStatus (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ResetStatus ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='resetStatus' and count(parameter)=0]"
			[Register ("resetStatus", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetResetStatusHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel ResetStatus ()
			{
				const string __id = "resetStatus.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStateLoding;
#pragma warning disable 0169
			static Delegate GetSetStateLodingHandler ()
			{
				if (cb_setStateLoding == null)
					cb_setStateLoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateLoding);
				return cb_setStateLoding;
			}

			static IntPtr n_SetStateLoding (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStateLoding ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStateLoding' and count(parameter)=0]"
			[Register ("setStateLoding", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateLodingHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateLoding ()
			{
				const string __id = "setStateLoding.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStateLodingFinish;
#pragma warning disable 0169
			static Delegate GetSetStateLodingFinishHandler ()
			{
				if (cb_setStateLodingFinish == null)
					cb_setStateLodingFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateLodingFinish);
				return cb_setStateLodingFinish;
			}

			static IntPtr n_SetStateLodingFinish (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStateLodingFinish ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStateLodingFinish' and count(parameter)=0]"
			[Register ("setStateLodingFinish", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateLodingFinishHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateLodingFinish ()
			{
				const string __id = "setStateLodingFinish.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStatePullDownCanceled;
#pragma warning disable 0169
			static Delegate GetSetStatePullDownCanceledHandler ()
			{
				if (cb_setStatePullDownCanceled == null)
					cb_setStatePullDownCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullDownCanceled);
				return cb_setStatePullDownCanceled;
			}

			static IntPtr n_SetStatePullDownCanceled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStatePullDownCanceled ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStatePullDownCanceled' and count(parameter)=0]"
			[Register ("setStatePullDownCanceled", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullDownCanceledHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullDownCanceled ()
			{
				const string __id = "setStatePullDownCanceled.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStatePullDownToRefresh;
#pragma warning disable 0169
			static Delegate GetSetStatePullDownToRefreshHandler ()
			{
				if (cb_setStatePullDownToRefresh == null)
					cb_setStatePullDownToRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullDownToRefresh);
				return cb_setStatePullDownToRefresh;
			}

			static IntPtr n_SetStatePullDownToRefresh (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStatePullDownToRefresh ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStatePullDownToRefresh' and count(parameter)=0]"
			[Register ("setStatePullDownToRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullDownToRefreshHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullDownToRefresh ()
			{
				const string __id = "setStatePullDownToRefresh.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStatePullUpCanceled;
#pragma warning disable 0169
			static Delegate GetSetStatePullUpCanceledHandler ()
			{
				if (cb_setStatePullUpCanceled == null)
					cb_setStatePullUpCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullUpCanceled);
				return cb_setStatePullUpCanceled;
			}

			static IntPtr n_SetStatePullUpCanceled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStatePullUpCanceled ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStatePullUpCanceled' and count(parameter)=0]"
			[Register ("setStatePullUpCanceled", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullUpCanceledHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullUpCanceled ()
			{
				const string __id = "setStatePullUpCanceled.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStatePullUpToLoad;
#pragma warning disable 0169
			static Delegate GetSetStatePullUpToLoadHandler ()
			{
				if (cb_setStatePullUpToLoad == null)
					cb_setStatePullUpToLoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullUpToLoad);
				return cb_setStatePullUpToLoad;
			}

			static IntPtr n_SetStatePullUpToLoad (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStatePullUpToLoad ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStatePullUpToLoad' and count(parameter)=0]"
			[Register ("setStatePullUpToLoad", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullUpToLoadHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullUpToLoad ()
			{
				const string __id = "setStatePullUpToLoad.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStateRefresing;
#pragma warning disable 0169
			static Delegate GetSetStateRefresingHandler ()
			{
				if (cb_setStateRefresing == null)
					cb_setStateRefresing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateRefresing);
				return cb_setStateRefresing;
			}

			static IntPtr n_SetStateRefresing (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStateRefresing ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStateRefresing' and count(parameter)=0]"
			[Register ("setStateRefresing", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateRefresingHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateRefresing ()
			{
				const string __id = "setStateRefresing.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStateRefresingFinish;
#pragma warning disable 0169
			static Delegate GetSetStateRefresingFinishHandler ()
			{
				if (cb_setStateRefresingFinish == null)
					cb_setStateRefresingFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateRefresingFinish);
				return cb_setStateRefresingFinish;
			}

			static IntPtr n_SetStateRefresingFinish (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStateRefresingFinish ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStateRefresingFinish' and count(parameter)=0]"
			[Register ("setStateRefresingFinish", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateRefresingFinishHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateRefresingFinish ()
			{
				const string __id = "setStateRefresingFinish.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStateReleaseToLoad;
#pragma warning disable 0169
			static Delegate GetSetStateReleaseToLoadHandler ()
			{
				if (cb_setStateReleaseToLoad == null)
					cb_setStateReleaseToLoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateReleaseToLoad);
				return cb_setStateReleaseToLoad;
			}

			static IntPtr n_SetStateReleaseToLoad (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStateReleaseToLoad ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStateReleaseToLoad' and count(parameter)=0]"
			[Register ("setStateReleaseToLoad", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateReleaseToLoadHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateReleaseToLoad ()
			{
				const string __id = "setStateReleaseToLoad.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStateReleaseToRefresh;
#pragma warning disable 0169
			static Delegate GetSetStateReleaseToRefreshHandler ()
			{
				if (cb_setStateReleaseToRefresh == null)
					cb_setStateReleaseToRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateReleaseToRefresh);
				return cb_setStateReleaseToRefresh;
			}

			static IntPtr n_SetStateReleaseToRefresh (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout.RefreshKernelImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStateReleaseToRefresh ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout.RefreshKernelImpl']/method[@name='setStateReleaseToRefresh' and count(parameter)=0]"
			[Register ("setStateReleaseToRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateReleaseToRefreshHandler")]
			public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateReleaseToRefresh ()
			{
				const string __id = "setStateReleaseToRefresh.()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/SmartRefreshLayout", typeof (SmartRefreshLayout));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SmartRefreshLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/constructor[@name='SmartRefreshLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SmartRefreshLayout (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/constructor[@name='SmartRefreshLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SmartRefreshLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/constructor[@name='SmartRefreshLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SmartRefreshLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/constructor[@name='SmartRefreshLayout' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe SmartRefreshLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isEnableAutoLoadmore;
#pragma warning disable 0169
		static Delegate GetIsEnableAutoLoadmoreHandler ()
		{
			if (cb_isEnableAutoLoadmore == null)
				cb_isEnableAutoLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableAutoLoadmore);
			return cb_isEnableAutoLoadmore;
		}

		static bool n_IsEnableAutoLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableAutoLoadmore;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnableAutoLoadmore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableAutoLoadmore' and count(parameter)=0]"
			[Register ("isEnableAutoLoadmore", "()Z", "GetIsEnableAutoLoadmoreHandler")]
			get {
				const string __id = "isEnableAutoLoadmore.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnableLoadmore;
#pragma warning disable 0169
		static Delegate GetIsEnableLoadmoreHandler ()
		{
			if (cb_isEnableLoadmore == null)
				cb_isEnableLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableLoadmore);
			return cb_isEnableLoadmore;
		}

		static bool n_IsEnableLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableLoadmore;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnableLoadmore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableLoadmore' and count(parameter)=0]"
			[Register ("isEnableLoadmore", "()Z", "GetIsEnableLoadmoreHandler")]
			get {
				const string __id = "isEnableLoadmore.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnableOverScrollBounce;
#pragma warning disable 0169
		static Delegate GetIsEnableOverScrollBounceHandler ()
		{
			if (cb_isEnableOverScrollBounce == null)
				cb_isEnableOverScrollBounce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableOverScrollBounce);
			return cb_isEnableOverScrollBounce;
		}

		static bool n_IsEnableOverScrollBounce (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableOverScrollBounce;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnableOverScrollBounce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableOverScrollBounce' and count(parameter)=0]"
			[Register ("isEnableOverScrollBounce", "()Z", "GetIsEnableOverScrollBounceHandler")]
			get {
				const string __id = "isEnableOverScrollBounce.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnablePureScrollMode;
#pragma warning disable 0169
		static Delegate GetIsEnablePureScrollModeHandler ()
		{
			if (cb_isEnablePureScrollMode == null)
				cb_isEnablePureScrollMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnablePureScrollMode);
			return cb_isEnablePureScrollMode;
		}

		static bool n_IsEnablePureScrollMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnablePureScrollMode;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnablePureScrollMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnablePureScrollMode' and count(parameter)=0]"
			[Register ("isEnablePureScrollMode", "()Z", "GetIsEnablePureScrollModeHandler")]
			get {
				const string __id = "isEnablePureScrollMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnableRefresh;
#pragma warning disable 0169
		static Delegate GetIsEnableRefreshHandler ()
		{
			if (cb_isEnableRefresh == null)
				cb_isEnableRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableRefresh);
			return cb_isEnableRefresh;
		}

		static bool n_IsEnableRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableRefresh;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnableRefresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableRefresh' and count(parameter)=0]"
			[Register ("isEnableRefresh", "()Z", "GetIsEnableRefreshHandler")]
			get {
				const string __id = "isEnableRefresh.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnableScrollContentWhenLoaded;
#pragma warning disable 0169
		static Delegate GetIsEnableScrollContentWhenLoadedHandler ()
		{
			if (cb_isEnableScrollContentWhenLoaded == null)
				cb_isEnableScrollContentWhenLoaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableScrollContentWhenLoaded);
			return cb_isEnableScrollContentWhenLoaded;
		}

		static bool n_IsEnableScrollContentWhenLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableScrollContentWhenLoaded;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnableScrollContentWhenLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isEnableScrollContentWhenLoaded' and count(parameter)=0]"
			[Register ("isEnableScrollContentWhenLoaded", "()Z", "GetIsEnableScrollContentWhenLoadedHandler")]
			get {
				const string __id = "isEnableScrollContentWhenLoaded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler")]
			get {
				const string __id = "isLoading.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLoadmoreFinished;
#pragma warning disable 0169
		static Delegate GetIsLoadmoreFinishedHandler ()
		{
			if (cb_isLoadmoreFinished == null)
				cb_isLoadmoreFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoadmoreFinished);
			return cb_isLoadmoreFinished;
		}

		static bool n_IsLoadmoreFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoadmoreFinished;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLoadmoreFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isLoadmoreFinished' and count(parameter)=0]"
			[Register ("isLoadmoreFinished", "()Z", "GetIsLoadmoreFinishedHandler")]
			get {
				const string __id = "isLoadmoreFinished.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRefreshing;
#pragma warning disable 0169
		static Delegate GetIsRefreshingHandler ()
		{
			if (cb_isRefreshing == null)
				cb_isRefreshing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRefreshing);
			return cb_isRefreshing;
		}

		static bool n_IsRefreshing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefreshing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRefreshing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='isRefreshing' and count(parameter)=0]"
			[Register ("isRefreshing", "()Z", "GetIsRefreshingHandler")]
			get {
				const string __id = "isRefreshing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayout);
			return cb_getLayout;
		}

		static IntPtr n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Layout);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.ViewGroup Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetGetLayoutHandler")]
			get {
				const string __id = "getLayout.()Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshFooter;
#pragma warning disable 0169
		static Delegate GetGetRefreshFooterHandler ()
		{
			if (cb_getRefreshFooter == null)
				cb_getRefreshFooter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshFooter);
			return cb_getRefreshFooter;
		}

		static IntPtr n_GetRefreshFooter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshFooter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter RefreshFooter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getRefreshFooter' and count(parameter)=0]"
			[Register ("getRefreshFooter", "()Lcom/scwang/smartrefresh/layout/api/RefreshFooter;", "GetGetRefreshFooterHandler")]
			get {
				const string __id = "getRefreshFooter.()Lcom/scwang/smartrefresh/layout/api/RefreshFooter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshHeader;
#pragma warning disable 0169
		static Delegate GetGetRefreshHeaderHandler ()
		{
			if (cb_getRefreshHeader == null)
				cb_getRefreshHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshHeader);
			return cb_getRefreshHeader;
		}

		static IntPtr n_GetRefreshHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshHeader);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader RefreshHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getRefreshHeader' and count(parameter)=0]"
			[Register ("getRefreshHeader", "()Lcom/scwang/smartrefresh/layout/api/RefreshHeader;", "GetGetRefreshHeaderHandler")]
			get {
				const string __id = "getRefreshHeader.()Lcom/scwang/smartrefresh/layout/api/RefreshHeader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/scwang/smartrefresh/layout/constant/RefreshState;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Lcom/scwang/smartrefresh/layout/constant/RefreshState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_animSpinner_I;
#pragma warning disable 0169
		static Delegate GetAnimSpinner_IHandler ()
		{
			if (cb_animSpinner_I == null)
				cb_animSpinner_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnimSpinner_I);
			return cb_animSpinner_I;
		}

		static IntPtr n_AnimSpinner_I (IntPtr jnienv, IntPtr native__this, int endSpinner)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimSpinner (endSpinner));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='animSpinner' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animSpinner", "(I)Landroid/animation/ValueAnimator;", "GetAnimSpinner_IHandler")]
		protected virtual unsafe global::Android.Animation.ValueAnimator AnimSpinner (int endSpinner)
		{
			const string __id = "animSpinner.(I)Landroid/animation/ValueAnimator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (endSpinner);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_animSpinner_II;
#pragma warning disable 0169
		static Delegate GetAnimSpinner_IIHandler ()
		{
			if (cb_animSpinner_II == null)
				cb_animSpinner_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_AnimSpinner_II);
			return cb_animSpinner_II;
		}

		static IntPtr n_AnimSpinner_II (IntPtr jnienv, IntPtr native__this, int endSpinner, int startDelay)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimSpinner (endSpinner, startDelay));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='animSpinner' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("animSpinner", "(II)Landroid/animation/ValueAnimator;", "GetAnimSpinner_IIHandler")]
		protected virtual unsafe global::Android.Animation.ValueAnimator AnimSpinner (int endSpinner, int startDelay)
		{
			const string __id = "animSpinner.(II)Landroid/animation/ValueAnimator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (endSpinner);
				__args [1] = new JniArgumentValue (startDelay);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_animSpinner_IILandroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetAnimSpinner_IILandroid_view_animation_Interpolator_Handler ()
		{
			if (cb_animSpinner_IILandroid_view_animation_Interpolator_ == null)
				cb_animSpinner_IILandroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_AnimSpinner_IILandroid_view_animation_Interpolator_);
			return cb_animSpinner_IILandroid_view_animation_Interpolator_;
		}

		static IntPtr n_AnimSpinner_IILandroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, int endSpinner, int startDelay, IntPtr native_interpolator)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator interpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_interpolator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AnimSpinner (endSpinner, startDelay, interpolator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='animSpinner' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.view.animation.Interpolator']]"
		[Register ("animSpinner", "(IILandroid/view/animation/Interpolator;)Landroid/animation/ValueAnimator;", "GetAnimSpinner_IILandroid_view_animation_Interpolator_Handler")]
		protected virtual unsafe global::Android.Animation.ValueAnimator AnimSpinner (int endSpinner, int startDelay, global::Android.Views.Animations.IInterpolator interpolator)
		{
			const string __id = "animSpinner.(IILandroid/view/animation/Interpolator;)Landroid/animation/ValueAnimator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (endSpinner);
				__args [1] = new JniArgumentValue (startDelay);
				__args [2] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_animSpinnerBounce_I;
#pragma warning disable 0169
		static Delegate GetAnimSpinnerBounce_IHandler ()
		{
			if (cb_animSpinnerBounce_I == null)
				cb_animSpinnerBounce_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnimSpinnerBounce_I);
			return cb_animSpinnerBounce_I;
		}

		static IntPtr n_AnimSpinnerBounce_I (IntPtr jnienv, IntPtr native__this, int bounceSpinner)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimSpinnerBounce (bounceSpinner));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='animSpinnerBounce' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animSpinnerBounce", "(I)Landroid/animation/ValueAnimator;", "GetAnimSpinnerBounce_IHandler")]
		protected virtual unsafe global::Android.Animation.ValueAnimator AnimSpinnerBounce (int bounceSpinner)
		{
			const string __id = "animSpinnerBounce.(I)Landroid/animation/ValueAnimator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bounceSpinner);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_autoLoadmore;
#pragma warning disable 0169
		static Delegate GetAutoLoadmoreHandler ()
		{
			if (cb_autoLoadmore == null)
				cb_autoLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AutoLoadmore);
			return cb_autoLoadmore;
		}

		static bool n_AutoLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLoadmore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoLoadmore' and count(parameter)=0]"
		[Register ("autoLoadmore", "()Z", "GetAutoLoadmoreHandler")]
		public virtual unsafe bool AutoLoadmore ()
		{
			const string __id = "autoLoadmore.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_autoLoadmore_I;
#pragma warning disable 0169
		static Delegate GetAutoLoadmore_IHandler ()
		{
			if (cb_autoLoadmore_I == null)
				cb_autoLoadmore_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_AutoLoadmore_I);
			return cb_autoLoadmore_I;
		}

		static bool n_AutoLoadmore_I (IntPtr jnienv, IntPtr native__this, int delayed)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLoadmore (delayed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoLoadmore' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("autoLoadmore", "(I)Z", "GetAutoLoadmore_IHandler")]
		public virtual unsafe bool AutoLoadmore (int delayed)
		{
			const string __id = "autoLoadmore.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delayed);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_autoLoadmore_IF;
#pragma warning disable 0169
		static Delegate GetAutoLoadmore_IFHandler ()
		{
			if (cb_autoLoadmore_IF == null)
				cb_autoLoadmore_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, bool>) n_AutoLoadmore_IF);
			return cb_autoLoadmore_IF;
		}

		static bool n_AutoLoadmore_IF (IntPtr jnienv, IntPtr native__this, int delayed, float dragrate)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLoadmore (delayed, dragrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoLoadmore' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("autoLoadmore", "(IF)Z", "GetAutoLoadmore_IFHandler")]
		public virtual unsafe bool AutoLoadmore (int delayed, float dragrate)
		{
			const string __id = "autoLoadmore.(IF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (delayed);
				__args [1] = new JniArgumentValue (dragrate);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_autoRefresh;
#pragma warning disable 0169
		static Delegate GetAutoRefreshHandler ()
		{
			if (cb_autoRefresh == null)
				cb_autoRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AutoRefresh);
			return cb_autoRefresh;
		}

		static bool n_AutoRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefresh' and count(parameter)=0]"
		[Register ("autoRefresh", "()Z", "GetAutoRefreshHandler")]
		public virtual unsafe bool AutoRefresh ()
		{
			const string __id = "autoRefresh.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_autoRefresh_I;
#pragma warning disable 0169
		static Delegate GetAutoRefresh_IHandler ()
		{
			if (cb_autoRefresh_I == null)
				cb_autoRefresh_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_AutoRefresh_I);
			return cb_autoRefresh_I;
		}

		static bool n_AutoRefresh_I (IntPtr jnienv, IntPtr native__this, int delayed)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoRefresh (delayed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("autoRefresh", "(I)Z", "GetAutoRefresh_IHandler")]
		public virtual unsafe bool AutoRefresh (int delayed)
		{
			const string __id = "autoRefresh.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delayed);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_autoRefresh_IF;
#pragma warning disable 0169
		static Delegate GetAutoRefresh_IFHandler ()
		{
			if (cb_autoRefresh_IF == null)
				cb_autoRefresh_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, bool>) n_AutoRefresh_IF);
			return cb_autoRefresh_IF;
		}

		static bool n_AutoRefresh_IF (IntPtr jnienv, IntPtr native__this, int delayed, float dragrate)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoRefresh (delayed, dragrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='autoRefresh' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("autoRefresh", "(IF)Z", "GetAutoRefresh_IFHandler")]
		public virtual unsafe bool AutoRefresh (int delayed, float dragrate)
		{
			const string __id = "autoRefresh.(IF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (delayed);
				__args [1] = new JniArgumentValue (dragrate);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_finishLoadmore;
#pragma warning disable 0169
		static Delegate GetFinishLoadmoreHandler ()
		{
			if (cb_finishLoadmore == null)
				cb_finishLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FinishLoadmore);
			return cb_finishLoadmore;
		}

		static IntPtr n_FinishLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadmore' and count(parameter)=0]"
		[Register ("finishLoadmore", "()Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishLoadmoreHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore ()
		{
			const string __id = "finishLoadmore.()Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishLoadmore_Z;
#pragma warning disable 0169
		static Delegate GetFinishLoadmore_ZHandler ()
		{
			if (cb_finishLoadmore_Z == null)
				cb_finishLoadmore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_FinishLoadmore_Z);
			return cb_finishLoadmore_Z;
		}

		static IntPtr n_FinishLoadmore_Z (IntPtr jnienv, IntPtr native__this, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore (success));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadmore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("finishLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishLoadmore_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (bool success)
		{
			const string __id = "finishLoadmore.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (success);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishLoadmore_I;
#pragma warning disable 0169
		static Delegate GetFinishLoadmore_IHandler ()
		{
			if (cb_finishLoadmore_I == null)
				cb_finishLoadmore_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FinishLoadmore_I);
			return cb_finishLoadmore_I;
		}

		static IntPtr n_FinishLoadmore_I (IntPtr jnienv, IntPtr native__this, int delayed)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore (delayed));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadmore' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("finishLoadmore", "(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishLoadmore_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (int delayed)
		{
			const string __id = "finishLoadmore.(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delayed);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishLoadmore_IZ;
#pragma warning disable 0169
		static Delegate GetFinishLoadmore_IZHandler ()
		{
			if (cb_finishLoadmore_IZ == null)
				cb_finishLoadmore_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_FinishLoadmore_IZ);
			return cb_finishLoadmore_IZ;
		}

		static IntPtr n_FinishLoadmore_IZ (IntPtr jnienv, IntPtr native__this, int delayed, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore (delayed, success));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishLoadmore' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("finishLoadmore", "(IZ)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishLoadmore_IZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (int delayed, bool success)
		{
			const string __id = "finishLoadmore.(IZ)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (delayed);
				__args [1] = new JniArgumentValue (success);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishRefresh;
#pragma warning disable 0169
		static Delegate GetFinishRefreshHandler ()
		{
			if (cb_finishRefresh == null)
				cb_finishRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FinishRefresh);
			return cb_finishRefresh;
		}

		static IntPtr n_FinishRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=0]"
		[Register ("finishRefresh", "()Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishRefreshHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh ()
		{
			const string __id = "finishRefresh.()Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishRefresh_Z;
#pragma warning disable 0169
		static Delegate GetFinishRefresh_ZHandler ()
		{
			if (cb_finishRefresh_Z == null)
				cb_finishRefresh_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_FinishRefresh_Z);
			return cb_finishRefresh_Z;
		}

		static IntPtr n_FinishRefresh_Z (IntPtr jnienv, IntPtr native__this, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh (success));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("finishRefresh", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishRefresh_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (bool success)
		{
			const string __id = "finishRefresh.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (success);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishRefresh_I;
#pragma warning disable 0169
		static Delegate GetFinishRefresh_IHandler ()
		{
			if (cb_finishRefresh_I == null)
				cb_finishRefresh_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FinishRefresh_I);
			return cb_finishRefresh_I;
		}

		static IntPtr n_FinishRefresh_I (IntPtr jnienv, IntPtr native__this, int delayed)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh (delayed));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("finishRefresh", "(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishRefresh_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (int delayed)
		{
			const string __id = "finishRefresh.(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delayed);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishRefresh_IZ;
#pragma warning disable 0169
		static Delegate GetFinishRefresh_IZHandler ()
		{
			if (cb_finishRefresh_IZ == null)
				cb_finishRefresh_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_FinishRefresh_IZ);
			return cb_finishRefresh_IZ;
		}

		static IntPtr n_FinishRefresh_IZ (IntPtr jnienv, IntPtr native__this, int delayed, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh (delayed, success));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='finishRefresh' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("finishRefresh", "(IZ)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetFinishRefresh_IZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (int delayed, bool success)
		{
			const string __id = "finishRefresh.(IZ)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (delayed);
				__args [1] = new JniArgumentValue (success);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moveSpinner_IZ;
#pragma warning disable 0169
		static Delegate GetMoveSpinner_IZHandler ()
		{
			if (cb_moveSpinner_IZ == null)
				cb_moveSpinner_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_MoveSpinner_IZ);
			return cb_moveSpinner_IZ;
		}

		static void n_MoveSpinner_IZ (IntPtr jnienv, IntPtr native__this, int spinner, bool isAnimator)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveSpinner (spinner, isAnimator);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='moveSpinner' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("moveSpinner", "(IZ)V", "GetMoveSpinner_IZHandler")]
		protected virtual unsafe void MoveSpinner (int spinner, bool isAnimator)
		{
			const string __id = "moveSpinner.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (spinner);
				__args [1] = new JniArgumentValue (isAnimator);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_moveSpinnerInfinitely_F;
#pragma warning disable 0169
		static Delegate GetMoveSpinnerInfinitely_FHandler ()
		{
			if (cb_moveSpinnerInfinitely_F == null)
				cb_moveSpinnerInfinitely_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_MoveSpinnerInfinitely_F);
			return cb_moveSpinnerInfinitely_F;
		}

		static void n_MoveSpinnerInfinitely_F (IntPtr jnienv, IntPtr native__this, float dy)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveSpinnerInfinitely (dy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='moveSpinnerInfinitely' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("moveSpinnerInfinitely", "(F)V", "GetMoveSpinnerInfinitely_FHandler")]
		protected virtual unsafe void MoveSpinnerInfinitely (float dy)
		{
			const string __id = "moveSpinnerInfinitely.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dy);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
		static Delegate GetNotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler ()
		{
			if (cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
				cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
			return cb_notifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		}

		static void n_NotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_state, JniHandleOwnership.DoNotTransfer);
			__this.NotifyStateChanged (state);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='notifyStateChanged' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
		[Register ("notifyStateChanged", "(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V", "GetNotifyStateChanged_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler")]
		protected virtual unsafe void NotifyStateChanged (global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState state)
		{
			const string __id = "notifyStateChanged.(Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, l, t, r, b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int l, int t, int r, int b)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (l);
				__args [2] = new JniArgumentValue (t);
				__args [3] = new JniArgumentValue (r);
				__args [4] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_overSpinner;
#pragma warning disable 0169
		static Delegate GetOverSpinnerHandler ()
		{
			if (cb_overSpinner == null)
				cb_overSpinner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OverSpinner);
			return cb_overSpinner;
		}

		static bool n_OverSpinner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OverSpinner ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='overSpinner' and count(parameter)=0]"
		[Register ("overSpinner", "()Z", "GetOverSpinnerHandler")]
		protected virtual unsafe bool OverSpinner ()
		{
			const string __id = "overSpinner.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resetStatus;
#pragma warning disable 0169
		static Delegate GetResetStatusHandler ()
		{
			if (cb_resetStatus == null)
				cb_resetStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetStatus);
			return cb_resetStatus;
		}

		static void n_ResetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='resetStatus' and count(parameter)=0]"
		[Register ("resetStatus", "()V", "GetResetStatusHandler")]
		protected virtual unsafe void ResetStatus ()
		{
			const string __id = "resetStatus.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDefaultRefreshFooterCreater' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.DefaultRefreshFooterCreater']]"
		[Register ("setDefaultRefreshFooterCreater", "(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater;)V", "")]
		public static unsafe void SetDefaultRefreshFooterCreater (global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreater creater)
		{
			const string __id = "setDefaultRefreshFooterCreater.(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((creater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) creater).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDefaultRefreshHeaderCreater' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.DefaultRefreshHeaderCreater']]"
		[Register ("setDefaultRefreshHeaderCreater", "(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreater;)V", "")]
		public static unsafe void SetDefaultRefreshHeaderCreater (global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshHeaderCreater creater)
		{
			const string __id = "setDefaultRefreshHeaderCreater.(Lcom/scwang/smartrefresh/layout/api/DefaultRefreshHeaderCreater;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((creater == null) ? IntPtr.Zero : ((global::Java.Lang.Object) creater).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setDisableContentWhenLoading_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableContentWhenLoading_ZHandler ()
		{
			if (cb_setDisableContentWhenLoading_Z == null)
				cb_setDisableContentWhenLoading_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableContentWhenLoading_Z);
			return cb_setDisableContentWhenLoading_Z;
		}

		static IntPtr n_SetDisableContentWhenLoading_Z (IntPtr jnienv, IntPtr native__this, bool disable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableContentWhenLoading (disable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDisableContentWhenLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableContentWhenLoading", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetDisableContentWhenLoading_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenLoading (bool disable)
		{
			const string __id = "setDisableContentWhenLoading.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDisableContentWhenRefresh_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableContentWhenRefresh_ZHandler ()
		{
			if (cb_setDisableContentWhenRefresh_Z == null)
				cb_setDisableContentWhenRefresh_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableContentWhenRefresh_Z);
			return cb_setDisableContentWhenRefresh_Z;
		}

		static IntPtr n_SetDisableContentWhenRefresh_Z (IntPtr jnienv, IntPtr native__this, bool disable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableContentWhenRefresh (disable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDisableContentWhenRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableContentWhenRefresh", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetDisableContentWhenRefresh_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenRefresh (bool disable)
		{
			const string __id = "setDisableContentWhenRefresh.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetDragRate_FHandler ()
		{
			if (cb_setDragRate_F == null)
				cb_setDragRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetDragRate_F);
			return cb_setDragRate_F;
		}

		static IntPtr n_SetDragRate_F (IntPtr jnienv, IntPtr native__this, float rate)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDragRate (rate));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDragRate", "(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetDragRate_FHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDragRate (float rate)
		{
			const string __id = "setDragRate.(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableAutoLoadmore_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableAutoLoadmore_ZHandler ()
		{
			if (cb_setEnableAutoLoadmore_Z == null)
				cb_setEnableAutoLoadmore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableAutoLoadmore_Z);
			return cb_setEnableAutoLoadmore_Z;
		}

		static IntPtr n_SetEnableAutoLoadmore_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableAutoLoadmore (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableAutoLoadmore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableAutoLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableAutoLoadmore_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableAutoLoadmore (bool enable)
		{
			const string __id = "setEnableAutoLoadmore.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableFooterTranslationContent_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableFooterTranslationContent_ZHandler ()
		{
			if (cb_setEnableFooterTranslationContent_Z == null)
				cb_setEnableFooterTranslationContent_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableFooterTranslationContent_Z);
			return cb_setEnableFooterTranslationContent_Z;
		}

		static IntPtr n_SetEnableFooterTranslationContent_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableFooterTranslationContent (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableFooterTranslationContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableFooterTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableFooterTranslationContent_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableFooterTranslationContent (bool enable)
		{
			const string __id = "setEnableFooterTranslationContent.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableHeaderTranslationContent_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableHeaderTranslationContent_ZHandler ()
		{
			if (cb_setEnableHeaderTranslationContent_Z == null)
				cb_setEnableHeaderTranslationContent_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableHeaderTranslationContent_Z);
			return cb_setEnableHeaderTranslationContent_Z;
		}

		static IntPtr n_SetEnableHeaderTranslationContent_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableHeaderTranslationContent (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableHeaderTranslationContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableHeaderTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableHeaderTranslationContent_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableHeaderTranslationContent (bool enable)
		{
			const string __id = "setEnableHeaderTranslationContent.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableLoadmore_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableLoadmore_ZHandler ()
		{
			if (cb_setEnableLoadmore_Z == null)
				cb_setEnableLoadmore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableLoadmore_Z);
			return cb_setEnableLoadmore_Z;
		}

		static IntPtr n_SetEnableLoadmore_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableLoadmore (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableLoadmore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableLoadmore_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableLoadmore (bool enable)
		{
			const string __id = "setEnableLoadmore.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableOverScrollBounce_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableOverScrollBounce_ZHandler ()
		{
			if (cb_setEnableOverScrollBounce_Z == null)
				cb_setEnableOverScrollBounce_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableOverScrollBounce_Z);
			return cb_setEnableOverScrollBounce_Z;
		}

		static IntPtr n_SetEnableOverScrollBounce_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableOverScrollBounce (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableOverScrollBounce' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableOverScrollBounce", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableOverScrollBounce_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableOverScrollBounce (bool enable)
		{
			const string __id = "setEnableOverScrollBounce.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnablePureScrollMode_Z;
#pragma warning disable 0169
		static Delegate GetSetEnablePureScrollMode_ZHandler ()
		{
			if (cb_setEnablePureScrollMode_Z == null)
				cb_setEnablePureScrollMode_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnablePureScrollMode_Z);
			return cb_setEnablePureScrollMode_Z;
		}

		static IntPtr n_SetEnablePureScrollMode_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnablePureScrollMode (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnablePureScrollMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnablePureScrollMode", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnablePureScrollMode_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnablePureScrollMode (bool enable)
		{
			const string __id = "setEnablePureScrollMode.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableRefresh_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableRefresh_ZHandler ()
		{
			if (cb_setEnableRefresh_Z == null)
				cb_setEnableRefresh_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableRefresh_Z);
			return cb_setEnableRefresh_Z;
		}

		static IntPtr n_SetEnableRefresh_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableRefresh (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableRefresh", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableRefresh_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableRefresh (bool enable)
		{
			const string __id = "setEnableRefresh.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnableScrollContentWhenLoaded_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableScrollContentWhenLoaded_ZHandler ()
		{
			if (cb_setEnableScrollContentWhenLoaded_Z == null)
				cb_setEnableScrollContentWhenLoaded_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableScrollContentWhenLoaded_Z);
			return cb_setEnableScrollContentWhenLoaded_Z;
		}

		static IntPtr n_SetEnableScrollContentWhenLoaded_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableScrollContentWhenLoaded (enable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setEnableScrollContentWhenLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableScrollContentWhenLoaded", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetEnableScrollContentWhenLoaded_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableScrollContentWhenLoaded (bool enable)
		{
			const string __id = "setEnableScrollContentWhenLoaded.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFooterHeight_F;
#pragma warning disable 0169
		static Delegate GetSetFooterHeight_FHandler ()
		{
			if (cb_setFooterHeight_F == null)
				cb_setFooterHeight_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetFooterHeight_F);
			return cb_setFooterHeight_F;
		}

		static IntPtr n_SetFooterHeight_F (IntPtr jnienv, IntPtr native__this, float heightDp)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFooterHeight (heightDp));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFooterHeight", "(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetFooterHeight_FHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeight (float heightDp)
		{
			const string __id = "setFooterHeight.(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heightDp);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFooterHeightPx_I;
#pragma warning disable 0169
		static Delegate GetSetFooterHeightPx_IHandler ()
		{
			if (cb_setFooterHeightPx_I == null)
				cb_setFooterHeightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetFooterHeightPx_I);
			return cb_setFooterHeightPx_I;
		}

		static IntPtr n_SetFooterHeightPx_I (IntPtr jnienv, IntPtr native__this, int heightPx)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFooterHeightPx (heightPx));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFooterHeightPx", "(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetFooterHeightPx_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeightPx (int heightPx)
		{
			const string __id = "setFooterHeightPx.(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heightPx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFooterMaxDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetFooterMaxDragRate_FHandler ()
		{
			if (cb_setFooterMaxDragRate_F == null)
				cb_setFooterMaxDragRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetFooterMaxDragRate_F);
			return cb_setFooterMaxDragRate_F;
		}

		static IntPtr n_SetFooterMaxDragRate_F (IntPtr jnienv, IntPtr native__this, float rate)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFooterMaxDragRate (rate));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setFooterMaxDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFooterMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetFooterMaxDragRate_FHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterMaxDragRate (float rate)
		{
			const string __id = "setFooterMaxDragRate.(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaderHeight_F;
#pragma warning disable 0169
		static Delegate GetSetHeaderHeight_FHandler ()
		{
			if (cb_setHeaderHeight_F == null)
				cb_setHeaderHeight_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetHeaderHeight_F);
			return cb_setHeaderHeight_F;
		}

		static IntPtr n_SetHeaderHeight_F (IntPtr jnienv, IntPtr native__this, float heightDp)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderHeight (heightDp));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHeaderHeight", "(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetHeaderHeight_FHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeight (float heightDp)
		{
			const string __id = "setHeaderHeight.(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heightDp);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaderHeightPx_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderHeightPx_IHandler ()
		{
			if (cb_setHeaderHeightPx_I == null)
				cb_setHeaderHeightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderHeightPx_I);
			return cb_setHeaderHeightPx_I;
		}

		static IntPtr n_SetHeaderHeightPx_I (IntPtr jnienv, IntPtr native__this, int heightPx)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderHeightPx (heightPx));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderHeightPx", "(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetHeaderHeightPx_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeightPx (int heightPx)
		{
			const string __id = "setHeaderHeightPx.(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (heightPx);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaderMaxDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetHeaderMaxDragRate_FHandler ()
		{
			if (cb_setHeaderMaxDragRate_F == null)
				cb_setHeaderMaxDragRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetHeaderMaxDragRate_F);
			return cb_setHeaderMaxDragRate_F;
		}

		static IntPtr n_SetHeaderMaxDragRate_F (IntPtr jnienv, IntPtr native__this, float rate)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderMaxDragRate (rate));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setHeaderMaxDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHeaderMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetHeaderMaxDragRate_FHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderMaxDragRate (float rate)
		{
			const string __id = "setHeaderMaxDragRate.(F)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLoadmoreFinished_Z;
#pragma warning disable 0169
		static Delegate GetSetLoadmoreFinished_ZHandler ()
		{
			if (cb_setLoadmoreFinished_Z == null)
				cb_setLoadmoreFinished_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetLoadmoreFinished_Z);
			return cb_setLoadmoreFinished_Z;
		}

		static IntPtr n_SetLoadmoreFinished_Z (IntPtr jnienv, IntPtr native__this, bool finished)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLoadmoreFinished (finished));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setLoadmoreFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoadmoreFinished", "(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetLoadmoreFinished_ZHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetLoadmoreFinished (bool finished)
		{
			const string __id = "setLoadmoreFinished.(Z)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (finished);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_Handler ()
		{
			if (cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ == null)
				cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_);
			return cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_;
		}

		static IntPtr n_SetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnLoadmoreListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnLoadmoreListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnLoadmoreListener']]"
		[Register ("setOnLoadmoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnLoadmoreListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnLoadmoreListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener listener)
		{
			const string __id = "setOnLoadmoreListener.(Lcom/scwang/smartrefresh/layout/listener/OnLoadmoreListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_Handler ()
		{
			if (cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ == null)
				cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_);
			return cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
		}

		static IntPtr n_SetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnMultiPurposeListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnMultiPurposeListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnMultiPurposeListener']]"
		[Register ("setOnMultiPurposeListener", "(Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnMultiPurposeListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener listener)
		{
			const string __id = "setOnMultiPurposeListener.(Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_Handler ()
		{
			if (cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ == null)
				cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_);
			return cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
		}

		static IntPtr n_SetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnRefreshListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnRefreshListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnRefreshListener']]"
		[Register ("setOnRefreshListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener listener)
		{
			const string __id = "setOnRefreshListener.(Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_Handler ()
		{
			if (cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ == null)
				cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_);
			return cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_;
		}

		static IntPtr n_SetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener listener = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnRefreshLoadmoreListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setOnRefreshLoadmoreListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnRefreshLoadmoreListener']]"
		[Register ("setOnRefreshLoadmoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshLoadmoreListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener listener)
		{
			const string __id = "setOnRefreshLoadmoreListener.(Lcom/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPrimaryColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColors_arrayIHandler ()
		{
			if (cb_setPrimaryColors_arrayI == null)
				cb_setPrimaryColors_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPrimaryColors_arrayI);
			return cb_setPrimaryColors_arrayI;
		}

		static IntPtr n_SetPrimaryColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPrimaryColors (colors));
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setPrimaryColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setPrimaryColors", "([I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetPrimaryColors_arrayIHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColors (params  int[] colors)
		{
			const string __id = "setPrimaryColors.([I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setPrimaryColorsId_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColorsId_arrayIHandler ()
		{
			if (cb_setPrimaryColorsId_arrayI == null)
				cb_setPrimaryColorsId_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPrimaryColorsId_arrayI);
			return cb_setPrimaryColorsId_arrayI;
		}

		static IntPtr n_SetPrimaryColorsId_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_primaryColorId)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] primaryColorId = (int[]) JNIEnv.GetArray (native_primaryColorId, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPrimaryColorsId (primaryColorId));
			if (primaryColorId != null)
				JNIEnv.CopyArray (primaryColorId, native_primaryColorId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setPrimaryColorsId' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setPrimaryColorsId", "([I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetPrimaryColorsId_arrayIHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColorsId (params  int[] primaryColorId)
		{
			const string __id = "setPrimaryColorsId.([I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			IntPtr native_primaryColorId = JNIEnv.NewArray (primaryColorId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_primaryColorId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (primaryColorId != null) {
					JNIEnv.CopyArray (native_primaryColorId, primaryColorId);
					JNIEnv.DeleteLocalRef (native_primaryColorId);
				}
			}
		}

		static Delegate cb_setReboundDuration_I;
#pragma warning disable 0169
		static Delegate GetSetReboundDuration_IHandler ()
		{
			if (cb_setReboundDuration_I == null)
				cb_setReboundDuration_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReboundDuration_I);
			return cb_setReboundDuration_I;
		}

		static IntPtr n_SetReboundDuration_I (IntPtr jnienv, IntPtr native__this, int duration)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReboundDuration (duration));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setReboundDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReboundDuration", "(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetReboundDuration_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundDuration (int duration)
		{
			const string __id = "setReboundDuration.(I)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (duration);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReboundInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetReboundInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setReboundInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setReboundInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReboundInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setReboundInterpolator_Landroid_view_animation_Interpolator_;
		}

		static IntPtr n_SetReboundInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interpolator)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator interpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_interpolator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReboundInterpolator (interpolator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setReboundInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setReboundInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetReboundInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundInterpolator (global::Android.Views.Animations.IInterpolator interpolator)
		{
			const string __id = "setReboundInterpolator.(Landroid/view/animation/Interpolator;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
#pragma warning disable 0169
		static Delegate GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Handler ()
		{
			if (cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ == null)
				cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_);
			return cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
		}

		static IntPtr n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_footer)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_footer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshFooter (footer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshFooter' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter']]"
		[Register ("setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer)
		{
			const string __id = "setRefreshFooter.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
#pragma warning disable 0169
		static Delegate GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler ()
		{
			if (cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == null)
				cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II);
			return cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
		}

		static IntPtr n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II (IntPtr jnienv, IntPtr native__this, IntPtr native_footer, int width, int height)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_footer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshFooter (footer, width, height));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshFooter' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer, int width, int height)
		{
			const string __id = "setRefreshFooter.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footer).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
#pragma warning disable 0169
		static Delegate GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Handler ()
		{
			if (cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ == null)
				cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_);
			return cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
		}

		static IntPtr n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_header)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_header, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshHeader (header));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshHeader' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader']]"
		[Register ("setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header)
		{
			const string __id = "setRefreshHeader.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
#pragma warning disable 0169
		static Delegate GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler ()
		{
			if (cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == null)
				cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II);
			return cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
		}

		static IntPtr n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II (IntPtr jnienv, IntPtr native__this, IntPtr native_header, int width, int height)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_header, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshHeader (header, width, height));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshHeader' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;", "GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header, int width, int height)
		{
			const string __id = "setRefreshHeader.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)Lcom/scwang/smartrefresh/layout/SmartRefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
#pragma warning disable 0169
		static Delegate GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler ()
		{
			if (cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ == null)
				cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_);
			return cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
		}

		static IntPtr n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_boundary)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary boundary = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary> (native_boundary, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshScrollBoundary (boundary));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setRefreshScrollBoundary' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshScrollBoundary']]"
		[Register ("setRefreshScrollBoundary", "(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshScrollBoundary (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary boundary)
		{
			const string __id = "setRefreshScrollBoundary.(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((boundary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boundary).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setStateLoding;
#pragma warning disable 0169
		static Delegate GetSetStateLodingHandler ()
		{
			if (cb_setStateLoding == null)
				cb_setStateLoding = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStateLoding);
			return cb_setStateLoding;
		}

		static void n_SetStateLoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateLoding ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateLoding' and count(parameter)=0]"
		[Register ("setStateLoding", "()V", "GetSetStateLodingHandler")]
		protected virtual unsafe void SetStateLoding ()
		{
			const string __id = "setStateLoding.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStateLodingFinish;
#pragma warning disable 0169
		static Delegate GetSetStateLodingFinishHandler ()
		{
			if (cb_setStateLodingFinish == null)
				cb_setStateLodingFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStateLodingFinish);
			return cb_setStateLodingFinish;
		}

		static void n_SetStateLodingFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateLodingFinish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateLodingFinish' and count(parameter)=0]"
		[Register ("setStateLodingFinish", "()V", "GetSetStateLodingFinishHandler")]
		protected virtual unsafe void SetStateLodingFinish ()
		{
			const string __id = "setStateLodingFinish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStatePullDownCanceled;
#pragma warning disable 0169
		static Delegate GetSetStatePullDownCanceledHandler ()
		{
			if (cb_setStatePullDownCanceled == null)
				cb_setStatePullDownCanceled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStatePullDownCanceled);
			return cb_setStatePullDownCanceled;
		}

		static void n_SetStatePullDownCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatePullDownCanceled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStatePullDownCanceled' and count(parameter)=0]"
		[Register ("setStatePullDownCanceled", "()V", "GetSetStatePullDownCanceledHandler")]
		protected virtual unsafe void SetStatePullDownCanceled ()
		{
			const string __id = "setStatePullDownCanceled.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStatePullDownToRefresh;
#pragma warning disable 0169
		static Delegate GetSetStatePullDownToRefreshHandler ()
		{
			if (cb_setStatePullDownToRefresh == null)
				cb_setStatePullDownToRefresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStatePullDownToRefresh);
			return cb_setStatePullDownToRefresh;
		}

		static void n_SetStatePullDownToRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatePullDownToRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStatePullDownToRefresh' and count(parameter)=0]"
		[Register ("setStatePullDownToRefresh", "()V", "GetSetStatePullDownToRefreshHandler")]
		protected virtual unsafe void SetStatePullDownToRefresh ()
		{
			const string __id = "setStatePullDownToRefresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStatePullUpCanceled;
#pragma warning disable 0169
		static Delegate GetSetStatePullUpCanceledHandler ()
		{
			if (cb_setStatePullUpCanceled == null)
				cb_setStatePullUpCanceled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStatePullUpCanceled);
			return cb_setStatePullUpCanceled;
		}

		static void n_SetStatePullUpCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatePullUpCanceled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStatePullUpCanceled' and count(parameter)=0]"
		[Register ("setStatePullUpCanceled", "()V", "GetSetStatePullUpCanceledHandler")]
		protected virtual unsafe void SetStatePullUpCanceled ()
		{
			const string __id = "setStatePullUpCanceled.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStatePullUpToLoad;
#pragma warning disable 0169
		static Delegate GetSetStatePullUpToLoadHandler ()
		{
			if (cb_setStatePullUpToLoad == null)
				cb_setStatePullUpToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStatePullUpToLoad);
			return cb_setStatePullUpToLoad;
		}

		static void n_SetStatePullUpToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatePullUpToLoad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStatePullUpToLoad' and count(parameter)=0]"
		[Register ("setStatePullUpToLoad", "()V", "GetSetStatePullUpToLoadHandler")]
		protected virtual unsafe void SetStatePullUpToLoad ()
		{
			const string __id = "setStatePullUpToLoad.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStateRefresing;
#pragma warning disable 0169
		static Delegate GetSetStateRefresingHandler ()
		{
			if (cb_setStateRefresing == null)
				cb_setStateRefresing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStateRefresing);
			return cb_setStateRefresing;
		}

		static void n_SetStateRefresing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateRefresing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateRefresing' and count(parameter)=0]"
		[Register ("setStateRefresing", "()V", "GetSetStateRefresingHandler")]
		protected virtual unsafe void SetStateRefresing ()
		{
			const string __id = "setStateRefresing.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStateRefresingFinish;
#pragma warning disable 0169
		static Delegate GetSetStateRefresingFinishHandler ()
		{
			if (cb_setStateRefresingFinish == null)
				cb_setStateRefresingFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStateRefresingFinish);
			return cb_setStateRefresingFinish;
		}

		static void n_SetStateRefresingFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateRefresingFinish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateRefresingFinish' and count(parameter)=0]"
		[Register ("setStateRefresingFinish", "()V", "GetSetStateRefresingFinishHandler")]
		protected virtual unsafe void SetStateRefresingFinish ()
		{
			const string __id = "setStateRefresingFinish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStateReleaseToLoad;
#pragma warning disable 0169
		static Delegate GetSetStateReleaseToLoadHandler ()
		{
			if (cb_setStateReleaseToLoad == null)
				cb_setStateReleaseToLoad = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStateReleaseToLoad);
			return cb_setStateReleaseToLoad;
		}

		static void n_SetStateReleaseToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateReleaseToLoad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateReleaseToLoad' and count(parameter)=0]"
		[Register ("setStateReleaseToLoad", "()V", "GetSetStateReleaseToLoadHandler")]
		protected virtual unsafe void SetStateReleaseToLoad ()
		{
			const string __id = "setStateReleaseToLoad.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setStateReleaseToRefresh;
#pragma warning disable 0169
		static Delegate GetSetStateReleaseToRefreshHandler ()
		{
			if (cb_setStateReleaseToRefresh == null)
				cb_setStateReleaseToRefresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetStateReleaseToRefresh);
			return cb_setStateReleaseToRefresh;
		}

		static void n_SetStateReleaseToRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.SmartRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateReleaseToRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout']/class[@name='SmartRefreshLayout']/method[@name='setStateReleaseToRefresh' and count(parameter)=0]"
		[Register ("setStateReleaseToRefresh", "()V", "GetSetStateReleaseToRefreshHandler")]
		protected virtual unsafe void SetStateReleaseToRefresh ()
		{
			const string __id = "setStateReleaseToRefresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
