using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnRefreshLoadmoreListener']"
	[Register ("com/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener", "", "Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListenerInvoker")]
	public partial interface IOnRefreshLoadmoreListener : global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener, global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener {

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener", DoNotGenerateAcw=true)]
	internal class IOnRefreshLoadmoreListenerInvoker : global::Java.Lang.Object, IOnRefreshLoadmoreListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener", typeof (IOnRefreshLoadmoreListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnRefreshLoadmoreListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnRefreshLoadmoreListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.listener.OnRefreshLoadmoreListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnRefreshLoadmoreListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
#pragma warning disable 0169
		static Delegate GetOnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler ()
		{
			if (cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == null)
				cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_);
			return cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		}

		static void n_OnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadmore (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		public unsafe void OnLoadmore (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0)
		{
			if (id_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == IntPtr.Zero)
				id_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNIEnv.GetMethodID (class_ref, "onLoadmore", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_, __args);
		}

		static Delegate cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
#pragma warning disable 0169
		static Delegate GetOnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler ()
		{
			if (cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == null)
				cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_);
			return cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		}

		static void n_OnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRefresh (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		public unsafe void OnRefresh (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0)
		{
			if (id_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == IntPtr.Zero)
				id_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNIEnv.GetMethodID (class_ref, "onRefresh", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_, __args);
		}

	}

}
