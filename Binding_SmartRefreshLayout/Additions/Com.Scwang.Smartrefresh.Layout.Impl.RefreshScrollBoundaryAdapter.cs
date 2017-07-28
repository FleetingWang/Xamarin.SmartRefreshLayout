using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshScrollBoundaryAdapter']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/impl/RefreshScrollBoundaryAdapter", DoNotGenerateAcw=true)]
	public partial class RefreshScrollBoundaryAdapter : global::Java.Lang.Object, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/impl/RefreshScrollBoundaryAdapter", typeof (RefreshScrollBoundaryAdapter));
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

		protected RefreshScrollBoundaryAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshScrollBoundaryAdapter']/constructor[@name='RefreshScrollBoundaryAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RefreshScrollBoundaryAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_canPullDown_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCanPullDown_Landroid_view_View_Handler ()
		{
			if (cb_canPullDown_Landroid_view_View_ == null)
				cb_canPullDown_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanPullDown_Landroid_view_View_);
			return cb_canPullDown_Landroid_view_View_;
		}

		static bool n_CanPullDown_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_content)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshScrollBoundaryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshScrollBoundaryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View content = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_content, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanPullDown (content);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshScrollBoundaryAdapter']/method[@name='canPullDown' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canPullDown", "(Landroid/view/View;)Z", "GetCanPullDown_Landroid_view_View_Handler")]
		public virtual unsafe bool CanPullDown (global::Android.Views.View content)
		{
			const string __id = "canPullDown.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((content == null) ? IntPtr.Zero : ((global::Java.Lang.Object) content).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canPullUp_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCanPullUp_Landroid_view_View_Handler ()
		{
			if (cb_canPullUp_Landroid_view_View_ == null)
				cb_canPullUp_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanPullUp_Landroid_view_View_);
			return cb_canPullUp_Landroid_view_View_;
		}

		static bool n_CanPullUp_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_content)
		{
			global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshScrollBoundaryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Impl.RefreshScrollBoundaryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View content = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_content, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanPullUp (content);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.impl']/class[@name='RefreshScrollBoundaryAdapter']/method[@name='canPullUp' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canPullUp", "(Landroid/view/View;)Z", "GetCanPullUp_Landroid_view_View_Handler")]
		public virtual unsafe bool CanPullUp (global::Android.Views.View content)
		{
			const string __id = "canPullUp.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((content == null) ? IntPtr.Zero : ((global::Java.Lang.Object) content).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
