using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/impl/RefreshHeaderWrapper", DoNotGenerateAcw=true)]
	public partial class RefreshHeaderWrapper : global::Java.Lang.Object, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/impl/RefreshHeaderWrapper", typeof (RefreshHeaderWrapper));
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

		protected RefreshHeaderWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/constructor[@name='RefreshHeaderWrapper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe RefreshHeaderWrapper (global::Android.Views.View wrapper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((wrapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wrapper).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isSupportHorizontalDrag;
#pragma warning disable 0169
		static Delegate GetIsSupportHorizontalDragHandler ()
		{
			if (cb_isSupportHorizontalDrag == null)
				cb_isSupportHorizontalDrag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportHorizontalDrag);
			return cb_isSupportHorizontalDrag;
		}

		static bool n_IsSupportHorizontalDrag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportHorizontalDrag;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSupportHorizontalDrag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='isSupportHorizontalDrag' and count(parameter)=0]"
			[Register ("isSupportHorizontalDrag", "()Z", "GetIsSupportHorizontalDragHandler")]
			get {
				const string __id = "isSupportHorizontalDrag.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSpinnerStyle;
#pragma warning disable 0169
		static Delegate GetGetSpinnerStyleHandler ()
		{
			if (cb_getSpinnerStyle == null)
				cb_getSpinnerStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpinnerStyle);
			return cb_getSpinnerStyle;
		}

		static IntPtr n_GetSpinnerStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SpinnerStyle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle SpinnerStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='getSpinnerStyle' and count(parameter)=0]"
			[Register ("getSpinnerStyle", "()Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;", "GetGetSpinnerStyleHandler")]
			get {
				const string __id = "getSpinnerStyle.()Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='getView' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='isTagedHeader' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("isTagedHeader", "(Landroid/view/View;)Z", "")]
		public static unsafe bool IsTagedHeader (global::Android.Views.View view)
		{
			const string __id = "isTagedHeader.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
#pragma warning disable 0169
		static Delegate GetOnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ZHandler ()
		{
			if (cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z == null)
				cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int>) n_OnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z);
			return cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
		}

		static int n_OnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnFinish (layout, success);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onFinish' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='boolean']]"
		[Register ("onFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Z)I", "GetOnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ZHandler")]
		public virtual unsafe int OnFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout, bool success)
		{
			const string __id = "onFinish.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JniArgumentValue (success);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onHorizontalDrag_FII;
#pragma warning disable 0169
		static Delegate GetOnHorizontalDrag_FIIHandler ()
		{
			if (cb_onHorizontalDrag_FII == null)
				cb_onHorizontalDrag_FII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int>) n_OnHorizontalDrag_FII);
			return cb_onHorizontalDrag_FII;
		}

		static void n_OnHorizontalDrag_FII (IntPtr jnienv, IntPtr native__this, float percentX, int offsetX, int offsetMax)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHorizontalDrag (percentX, offsetX, offsetMax);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onHorizontalDrag' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onHorizontalDrag", "(FII)V", "GetOnHorizontalDrag_FIIHandler")]
		public virtual unsafe void OnHorizontalDrag (float percentX, int offsetX, int offsetMax)
		{
			const string __id = "onHorizontalDrag.(FII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (percentX);
				__args [1] = new JniArgumentValue (offsetX);
				__args [2] = new JniArgumentValue (offsetMax);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
#pragma warning disable 0169
		static Delegate GetOnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IIHandler ()
		{
			if (cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II == null)
				cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II);
			return cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
		}

		static void n_OnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II (IntPtr jnienv, IntPtr native__this, IntPtr native_kernel, int height, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_kernel, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialized (kernel, height, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onInitialized' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshKernel'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onInitialized", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;II)V", "GetOnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IIHandler")]
		public virtual unsafe void OnInitialized (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel, int height, int extendHeight)
		{
			const string __id = "onInitialized.(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((kernel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) kernel).Handle);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPullingDown_FIII;
#pragma warning disable 0169
		static Delegate GetOnPullingDown_FIIIHandler ()
		{
			if (cb_onPullingDown_FIII == null)
				cb_onPullingDown_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int, int>) n_OnPullingDown_FIII);
			return cb_onPullingDown_FIII;
		}

		static void n_OnPullingDown_FIII (IntPtr jnienv, IntPtr native__this, float percent, int offset, int headHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullingDown (percent, offset, headHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onPullingDown' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onPullingDown", "(FIII)V", "GetOnPullingDown_FIIIHandler")]
		public virtual unsafe void OnPullingDown (float percent, int offset, int headHeight, int extendHeight)
		{
			const string __id = "onPullingDown.(FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (percent);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (headHeight);
				__args [3] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onReleasing_FIII;
#pragma warning disable 0169
		static Delegate GetOnReleasing_FIIIHandler ()
		{
			if (cb_onReleasing_FIII == null)
				cb_onReleasing_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int, int>) n_OnReleasing_FIII);
			return cb_onReleasing_FIII;
		}

		static void n_OnReleasing_FIII (IntPtr jnienv, IntPtr native__this, float percent, int offset, int headHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReleasing (percent, offset, headHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onReleasing' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onReleasing", "(FIII)V", "GetOnReleasing_FIIIHandler")]
		public virtual unsafe void OnReleasing (float percent, int offset, int headHeight, int extendHeight)
		{
			const string __id = "onReleasing.(FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (percent);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (headHeight);
				__args [3] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
#pragma warning disable 0169
		static Delegate GetOnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_IIHandler ()
		{
			if (cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II == null)
				cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II);
			return cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
		}

		static void n_OnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, int headHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnStartAnimator (layout, headHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onStartAnimator' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;II)V", "GetOnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_IIHandler")]
		public virtual unsafe void OnStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout, int headHeight, int extendHeight)
		{
			const string __id = "onStartAnimator.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JniArgumentValue (headHeight);
				__args [2] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
		static Delegate GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler ()
		{
			if (cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
				cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
			return cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		}

		static void n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshLayout, IntPtr native_oldState, IntPtr native_newState)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshLayout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_refreshLayout, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState oldState = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_oldState, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState newState = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_newState, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (refreshLayout, oldState, newState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='onStateChanged' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='com.scwang.smartrefresh.layout.constant.RefreshState'] and parameter[3][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
		[Register ("onStateChanged", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V", "GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler")]
		public virtual unsafe void OnStateChanged (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshLayout, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState oldState, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState newState)
		{
			const string __id = "onStateChanged.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((refreshLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshLayout).Handle);
				__args [1] = new JniArgumentValue ((oldState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldState).Handle);
				__args [2] = new JniArgumentValue ((newState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPrimaryColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColors_arrayIHandler ()
		{
			if (cb_setPrimaryColors_arrayI == null)
				cb_setPrimaryColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrimaryColors_arrayI);
			return cb_setPrimaryColors_arrayI;
		}

		static void n_SetPrimaryColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshHeaderWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetPrimaryColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshHeaderWrapper']/method[@name='setPrimaryColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setPrimaryColors", "([I)V", "GetSetPrimaryColors_arrayIHandler")]
		public virtual unsafe void SetPrimaryColors (params  int[] colors)
		{
			const string __id = "setPrimaryColors.([I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

	}
}
