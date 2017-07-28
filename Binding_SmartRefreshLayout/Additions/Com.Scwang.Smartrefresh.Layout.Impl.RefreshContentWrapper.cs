using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/impl/RefreshContentWrapper", DoNotGenerateAcw=true)]
	public partial class RefreshContentWrapper : global::Java.Lang.Object, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/impl/RefreshContentWrapper", typeof (RefreshContentWrapper));
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

		protected RefreshContentWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/constructor[@name='RefreshContentWrapper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RefreshContentWrapper (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/constructor[@name='RefreshContentWrapper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe RefreshContentWrapper (global::Android.Views.View view)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getLayoutParams;
#pragma warning disable 0169
		static Delegate GetGetLayoutParamsHandler ()
		{
			if (cb_getLayoutParams == null)
				cb_getLayoutParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayoutParams);
			return cb_getLayoutParams;
		}

		static IntPtr n_GetLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LayoutParams);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.ViewGroup.LayoutParams LayoutParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='getLayoutParams' and count(parameter)=0]"
			[Register ("getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", "GetGetLayoutParamsHandler")]
			get {
				const string __id = "getLayoutParams.()Landroid/view/ViewGroup$LayoutParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMeasuredHeight;
#pragma warning disable 0169
		static Delegate GetGetMeasuredHeightHandler ()
		{
			if (cb_getMeasuredHeight == null)
				cb_getMeasuredHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMeasuredHeight);
			return cb_getMeasuredHeight;
		}

		static int n_GetMeasuredHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasuredHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int MeasuredHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='getMeasuredHeight' and count(parameter)=0]"
			[Register ("getMeasuredHeight", "()I", "GetGetMeasuredHeightHandler")]
			get {
				const string __id = "getMeasuredHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMeasuredWidth;
#pragma warning disable 0169
		static Delegate GetGetMeasuredWidthHandler ()
		{
			if (cb_getMeasuredWidth == null)
				cb_getMeasuredWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMeasuredWidth);
			return cb_getMeasuredWidth;
		}

		static int n_GetMeasuredWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasuredWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int MeasuredWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='getMeasuredWidth' and count(parameter)=0]"
			[Register ("getMeasuredWidth", "()I", "GetGetMeasuredWidthHandler")]
			get {
				const string __id = "getMeasuredWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScrollableView;
#pragma warning disable 0169
		static Delegate GetGetScrollableViewHandler ()
		{
			if (cb_getScrollableView == null)
				cb_getScrollableView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScrollableView);
			return cb_getScrollableView;
		}

		static IntPtr n_GetScrollableView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScrollableView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View ScrollableView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='getScrollableView' and count(parameter)=0]"
			[Register ("getScrollableView", "()Landroid/view/View;", "GetGetScrollableViewHandler")]
			get {
				const string __id = "getScrollableView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canScrollDown;
#pragma warning disable 0169
		static Delegate GetCanScrollDownHandler ()
		{
			if (cb_canScrollDown == null)
				cb_canScrollDown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanScrollDown);
			return cb_canScrollDown;
		}

		static bool n_CanScrollDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanScrollDown ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='canScrollDown' and count(parameter)=0]"
		[Register ("canScrollDown", "()Z", "GetCanScrollDownHandler")]
		public virtual unsafe bool CanScrollDown ()
		{
			const string __id = "canScrollDown.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canScrollUp;
#pragma warning disable 0169
		static Delegate GetCanScrollUpHandler ()
		{
			if (cb_canScrollUp == null)
				cb_canScrollUp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanScrollUp);
			return cb_canScrollUp;
		}

		static bool n_CanScrollUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanScrollUp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='canScrollUp' and count(parameter)=0]"
		[Register ("canScrollUp", "()Z", "GetCanScrollUpHandler")]
		public virtual unsafe bool CanScrollUp ()
		{
			const string __id = "canScrollUp.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isNestedScrollingChild_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetIsNestedScrollingChild_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_isNestedScrollingChild_Landroid_view_MotionEvent_ == null)
				cb_isNestedScrollingChild_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsNestedScrollingChild_Landroid_view_MotionEvent_);
			return cb_isNestedScrollingChild_Landroid_view_MotionEvent_;
		}

		static bool n_IsNestedScrollingChild_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNestedScrollingChild (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='isNestedScrollingChild' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("isNestedScrollingChild", "(Landroid/view/MotionEvent;)Z", "GetIsNestedScrollingChild_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool IsNestedScrollingChild (global::Android.Views.MotionEvent e)
		{
			const string __id = "isNestedScrollingChild.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='isTagedContent' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("isTagedContent", "(Landroid/view/View;)Z", "")]
		public static unsafe bool IsTagedContent (global::Android.Views.View view)
		{
			const string __id = "isTagedContent.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_layout_IIII;
#pragma warning disable 0169
		static Delegate GetLayout_IIIIHandler ()
		{
			if (cb_layout_IIII == null)
				cb_layout_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_Layout_IIII);
			return cb_layout_IIII;
		}

		static void n_Layout_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Layout (left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='layout' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("layout", "(IIII)V", "GetLayout_IIIIHandler")]
		public virtual unsafe void Layout (int left, int top, int right, int bottom)
		{
			const string __id = "layout.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_measure_II;
#pragma warning disable 0169
		static Delegate GetMeasure_IIHandler ()
		{
			if (cb_measure_II == null)
				cb_measure_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Measure_II);
			return cb_measure_II;
		}

		static void n_Measure_II (IntPtr jnienv, IntPtr native__this, int widthSpec, int heightSpec)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Measure (widthSpec, heightSpec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='measure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("measure", "(II)V", "GetMeasure_IIHandler")]
		public virtual unsafe void Measure (int widthSpec, int heightSpec)
		{
			const string __id = "measure.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (widthSpec);
				__args [1] = new JniArgumentValue (heightSpec);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_moveSpinner_I;
#pragma warning disable 0169
		static Delegate GetMoveSpinner_IHandler ()
		{
			if (cb_moveSpinner_I == null)
				cb_moveSpinner_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_MoveSpinner_I);
			return cb_moveSpinner_I;
		}

		static void n_MoveSpinner_I (IntPtr jnienv, IntPtr native__this, int spinner)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveSpinner (spinner);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='moveSpinner' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("moveSpinner", "(I)V", "GetMoveSpinner_IHandler")]
		public virtual unsafe void MoveSpinner (int spinner)
		{
			const string __id = "moveSpinner.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (spinner);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActionDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnActionDown_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onActionDown_Landroid_view_MotionEvent_ == null)
				cb_onActionDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionDown_Landroid_view_MotionEvent_);
			return cb_onActionDown_Landroid_view_MotionEvent_;
		}

		static void n_OnActionDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnActionDown (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='onActionDown' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onActionDown", "(Landroid/view/MotionEvent;)V", "GetOnActionDown_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnActionDown (global::Android.Views.MotionEvent e)
		{
			const string __id = "onActionDown.(Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActionUpOrCancel;
#pragma warning disable 0169
		static Delegate GetOnActionUpOrCancelHandler ()
		{
			if (cb_onActionUpOrCancel == null)
				cb_onActionUpOrCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnActionUpOrCancel);
			return cb_onActionUpOrCancel;
		}

		static void n_OnActionUpOrCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionUpOrCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='onActionUpOrCancel' and count(parameter)=0]"
		[Register ("onActionUpOrCancel", "()V", "GetOnActionUpOrCancelHandler")]
		public virtual unsafe void OnActionUpOrCancel ()
		{
			const string __id = "onActionUpOrCancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onInitialHeaderAndFooter_II;
#pragma warning disable 0169
		static Delegate GetOnInitialHeaderAndFooter_IIHandler ()
		{
			if (cb_onInitialHeaderAndFooter_II == null)
				cb_onInitialHeaderAndFooter_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnInitialHeaderAndFooter_II);
			return cb_onInitialHeaderAndFooter_II;
		}

		static void n_OnInitialHeaderAndFooter_II (IntPtr jnienv, IntPtr native__this, int headerHeight, int footerHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialHeaderAndFooter (headerHeight, footerHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='onInitialHeaderAndFooter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onInitialHeaderAndFooter", "(II)V", "GetOnInitialHeaderAndFooter_IIHandler")]
		public virtual unsafe void OnInitialHeaderAndFooter (int headerHeight, int footerHeight)
		{
			const string __id = "onInitialHeaderAndFooter.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (headerHeight);
				__args [1] = new JniArgumentValue (footerHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I;
#pragma warning disable 0169
		static Delegate GetOnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_IHandler ()
		{
			if (cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I == null)
				cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, IntPtr>) n_OnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I);
			return cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I;
		}

		static IntPtr n_OnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I (IntPtr jnienv, IntPtr native__this, IntPtr native_kernel, int footerHeight, int startDelay, IntPtr native_interpolator, int duration)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_kernel, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator interpolator = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_interpolator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnLoadingFinish (kernel, footerHeight, startDelay, interpolator, duration));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='onLoadingFinish' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshKernel'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.view.animation.Interpolator'] and parameter[5][@type='int']]"
		[Register ("onLoadingFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;IILandroid/view/animation/Interpolator;I)Landroid/animation/ValueAnimator$AnimatorUpdateListener;", "GetOnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_IHandler")]
		public virtual unsafe global::Android.Animation.ValueAnimator.IAnimatorUpdateListener OnLoadingFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel, int footerHeight, int startDelay, global::Android.Views.Animations.IInterpolator interpolator, int duration)
		{
			const string __id = "onLoadingFinish.(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;IILandroid/view/animation/Interpolator;I)Landroid/animation/ValueAnimator$AnimatorUpdateListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((kernel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) kernel).Handle);
				__args [1] = new JniArgumentValue (footerHeight);
				__args [2] = new JniArgumentValue (startDelay);
				__args [3] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				__args [4] = new JniArgumentValue (duration);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator.IAnimatorUpdateListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
#pragma warning disable 0169
		static Delegate GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler ()
		{
			if (cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ == null)
				cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_);
			return cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
		}

		static void n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_boundary)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary boundary = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary> (native_boundary, JniHandleOwnership.DoNotTransfer);
			__this.SetRefreshScrollBoundary (boundary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='setRefreshScrollBoundary' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshScrollBoundary']]"
		[Register ("setRefreshScrollBoundary", "(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)V", "GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler")]
		public virtual unsafe void SetRefreshScrollBoundary (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary boundary)
		{
			const string __id = "setRefreshScrollBoundary.(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((boundary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boundary).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_Handler ()
		{
			if (cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ == null)
				cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_);
			return cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_;
		}

		static void n_SetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_kernel, IntPtr native_fixedHeader, IntPtr native_fixedFooter)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshContentWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_kernel, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View fixedHeader = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_fixedHeader, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View fixedFooter = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_fixedFooter, JniHandleOwnership.DoNotTransfer);
			__this.SetupComponent (kernel, fixedHeader, fixedFooter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshContentWrapper']/method[@name='setupComponent' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshKernel'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.View']]"
		[Register ("setupComponent", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;Landroid/view/View;Landroid/view/View;)V", "GetSetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_Handler")]
		public virtual unsafe void SetupComponent (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel, global::Android.Views.View fixedHeader, global::Android.Views.View fixedFooter)
		{
			const string __id = "setupComponent.(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;Landroid/view/View;Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((kernel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) kernel).Handle);
				__args [1] = new JniArgumentValue ((fixedHeader == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fixedHeader).Handle);
				__args [2] = new JniArgumentValue ((fixedFooter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fixedFooter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
