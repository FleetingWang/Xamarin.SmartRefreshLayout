using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnLoadmoreListener']"
	[Register ("com/scwang/smartrefresh/layout/listener/OnLoadmoreListener", "", "Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListenerInvoker")]
	public partial interface IOnLoadmoreListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnLoadmoreListener']/method[@name='onLoadmore' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout']]"
		[Register ("onLoadmore", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V", "GetOnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler:Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListenerInvoker, Binding_SmartRefreshLayout")]
		void OnLoadmore (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/listener/OnLoadmoreListener", DoNotGenerateAcw=true)]
	internal class IOnLoadmoreListenerInvoker : global::Java.Lang.Object, IOnLoadmoreListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/listener/OnLoadmoreListener", typeof (IOnLoadmoreListenerInvoker));

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

		public static IOnLoadmoreListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLoadmoreListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.listener.OnLoadmoreListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLoadmoreListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

	public partial class LoadmoreEventArgs : global::System.EventArgs {

		public LoadmoreEventArgs (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0)
		{
			this.p0 = p0;
		}

		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0;
		public global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/scwang/smartrefresh/layout/listener/OnLoadmoreListenerImplementor")]
	internal sealed partial class IOnLoadmoreListenerImplementor : global::Java.Lang.Object, IOnLoadmoreListener {

		object sender;

		public IOnLoadmoreListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/scwang/smartrefresh/layout/listener/OnLoadmoreListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LoadmoreEventArgs> Handler;
#pragma warning restore 0649

		public void OnLoadmore (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LoadmoreEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnLoadmoreListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
