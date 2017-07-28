using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnStateChangedListener']"
	[Register ("com/scwang/smartrefresh/layout/listener/OnStateChangedListener", "", "Com.Scwang.Smartrefresh.Layout.Listener.IOnStateChangedListenerInvoker")]
	public partial interface IOnStateChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnStateChangedListener']/method[@name='onStateChanged' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='com.scwang.smartrefresh.layout.constant.RefreshState'] and parameter[3][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
		[Register ("onStateChanged", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V", "GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler:Com.Scwang.Smartrefresh.Layout.Listener.IOnStateChangedListenerInvoker, Binding_SmartRefreshLayout")]
		void OnStateChanged (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/listener/OnStateChangedListener", DoNotGenerateAcw=true)]
	internal class IOnStateChangedListenerInvoker : global::Java.Lang.Object, IOnStateChangedListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/listener/OnStateChangedListener", typeof (IOnStateChangedListenerInvoker));

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

		public static IOnStateChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnStateChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.listener.OnStateChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnStateChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
		static Delegate GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler ()
		{
			if (cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
				cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
			return cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		}

		static void n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnStateChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnStateChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1 = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2 = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		public unsafe void OnStateChanged (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2)
		{
			if (id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == IntPtr.Zero)
				id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNIEnv.GetMethodID (class_ref, "onStateChanged", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_, __args);
		}

	}

	public partial class StateChangedEventArgs : global::System.EventArgs {

		public StateChangedEventArgs (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0;
		public global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout P0 {
			get { return p0; }
		}

		global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1;
		public global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState P1 {
			get { return p1; }
		}

		global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2;
		public global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/scwang/smartrefresh/layout/listener/OnStateChangedListenerImplementor")]
	internal sealed partial class IOnStateChangedListenerImplementor : global::Java.Lang.Object, IOnStateChangedListener {

		object sender;

		public IOnStateChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/scwang/smartrefresh/layout/listener/OnStateChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<StateChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnStateChanged (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StateChangedEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IOnStateChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
