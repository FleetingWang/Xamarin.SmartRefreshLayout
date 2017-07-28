using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']"
	[Register ("com/scwang/smartrefresh/layout/listener/OnMultiPurposeListener", "", "Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker")]
	public partial interface IOnMultiPurposeListener : global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener, global::Com.Scwang.Smartrefresh.Layout.Listener.IOnStateChangedListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onFooterFinish' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='boolean']]"
		[Register ("onFooterFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;Z)V", "GetOnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ZHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnFooterFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onFooterPulling' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onFooterPulling", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V", "GetOnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnFooterPulling (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, float p1, int p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onFooterReleasing' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onFooterReleasing", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V", "GetOnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnFooterReleasing (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, float p1, int p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onFooterStartAnimator' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onFooterStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)V", "GetOnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnFooterStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onHeaderFinish' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='boolean']]"
		[Register ("onHeaderFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;Z)V", "GetOnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ZHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnHeaderFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onHeaderPulling' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onHeaderPulling", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V", "GetOnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnHeaderPulling (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, float p1, int p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onHeaderReleasing' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onHeaderReleasing", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V", "GetOnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnHeaderReleasing (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, float p1, int p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='OnMultiPurposeListener']/method[@name='onHeaderStartAnimator' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onHeaderStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)V", "GetOnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler:Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListenerInvoker, Binding_SmartRefreshLayout")]
		void OnHeaderStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/listener/OnMultiPurposeListener", DoNotGenerateAcw=true)]
	internal class IOnMultiPurposeListenerInvoker : global::Java.Lang.Object, IOnMultiPurposeListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/listener/OnMultiPurposeListener", typeof (IOnMultiPurposeListenerInvoker));

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

		public static IOnMultiPurposeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnMultiPurposeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.listener.OnMultiPurposeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnMultiPurposeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z;
#pragma warning disable 0169
		static Delegate GetOnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ZHandler ()
		{
			if (cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z == null)
				cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z);
			return cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z;
		}

		static void n_OnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterFinish (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z;
		public unsafe void OnFooterFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, bool p1)
		{
			if (id_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z == IntPtr.Zero)
				id_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z = JNIEnv.GetMethodID (class_ref, "onFooterFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z, __args);
		}

		static Delegate cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
#pragma warning disable 0169
		static Delegate GetOnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler ()
		{
			if (cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII == null)
				cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII);
			return cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
		}

		static void n_OnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, int p2, int p3, int p4)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterPulling (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
		public unsafe void OnFooterPulling (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, float p1, int p2, int p3, int p4)
		{
			if (id_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII == IntPtr.Zero)
				id_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII = JNIEnv.GetMethodID (class_ref, "onFooterPulling", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII, __args);
		}

		static Delegate cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
#pragma warning disable 0169
		static Delegate GetOnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler ()
		{
			if (cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII == null)
				cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII);
			return cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
		}

		static void n_OnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, int p2, int p3, int p4)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterReleasing (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
		public unsafe void OnFooterReleasing (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, float p1, int p2, int p3, int p4)
		{
			if (id_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII == IntPtr.Zero)
				id_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII = JNIEnv.GetMethodID (class_ref, "onFooterReleasing", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII, __args);
		}

		static Delegate cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
#pragma warning disable 0169
		static Delegate GetOnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler ()
		{
			if (cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == null)
				cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II);
			return cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
		}

		static void n_OnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterStartAnimator (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
		public unsafe void OnFooterStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, int p1, int p2)
		{
			if (id_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == IntPtr.Zero)
				id_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNIEnv.GetMethodID (class_ref, "onFooterStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II, __args);
		}

		static Delegate cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z;
#pragma warning disable 0169
		static Delegate GetOnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ZHandler ()
		{
			if (cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z == null)
				cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z);
			return cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z;
		}

		static void n_OnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderFinish (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z;
		public unsafe void OnHeaderFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, bool p1)
		{
			if (id_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z == IntPtr.Zero)
				id_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z = JNIEnv.GetMethodID (class_ref, "onHeaderFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z, __args);
		}

		static Delegate cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
#pragma warning disable 0169
		static Delegate GetOnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler ()
		{
			if (cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII == null)
				cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII);
			return cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
		}

		static void n_OnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, int p2, int p3, int p4)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderPulling (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
		public unsafe void OnHeaderPulling (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, float p1, int p2, int p3, int p4)
		{
			if (id_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII == IntPtr.Zero)
				id_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII = JNIEnv.GetMethodID (class_ref, "onHeaderPulling", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII, __args);
		}

		static Delegate cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
#pragma warning disable 0169
		static Delegate GetOnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler ()
		{
			if (cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII == null)
				cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII);
			return cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
		}

		static void n_OnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, int p2, int p3, int p4)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderReleasing (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
		public unsafe void OnHeaderReleasing (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, float p1, int p2, int p3, int p4)
		{
			if (id_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII == IntPtr.Zero)
				id_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII = JNIEnv.GetMethodID (class_ref, "onHeaderReleasing", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII, __args);
		}

		static Delegate cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
#pragma warning disable 0169
		static Delegate GetOnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler ()
		{
			if (cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == null)
				cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II);
			return cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
		}

		static void n_OnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderStartAnimator (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
		public unsafe void OnHeaderStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, int p1, int p2)
		{
			if (id_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == IntPtr.Zero)
				id_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNIEnv.GetMethodID (class_ref, "onHeaderStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II, __args);
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
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

}
