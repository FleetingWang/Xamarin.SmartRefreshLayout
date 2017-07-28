using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Listener {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/listener/SimpleMultiPurposeListener", DoNotGenerateAcw=true)]
	public partial class SimpleMultiPurposeListener : global::Java.Lang.Object, global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/listener/SimpleMultiPurposeListener", typeof (SimpleMultiPurposeListener));
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

		protected SimpleMultiPurposeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/constructor[@name='SimpleMultiPurposeListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleMultiPurposeListener ()
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

		static Delegate cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z;
#pragma warning disable 0169
		static Delegate GetOnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ZHandler ()
		{
			if (cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z == null)
				cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z);
			return cb_onFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z;
		}

		static void n_OnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_footer, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_footer, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterFinish (footer, success);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onFooterFinish' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='boolean']]"
		[Register ("onFooterFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;Z)V", "GetOnFooterFinish_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ZHandler")]
		public virtual unsafe void OnFooterFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer, bool success)
		{
			const string __id = "onFooterFinish.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footer).Handle);
				__args [1] = new JniArgumentValue (success);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
#pragma warning disable 0169
		static Delegate GetOnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler ()
		{
			if (cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII == null)
				cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII);
			return cb_onFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
		}

		static void n_OnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_footer, float percent, int offset, int footerHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_footer, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterPulling (footer, percent, offset, footerHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onFooterPulling' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onFooterPulling", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V", "GetOnFooterPulling_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler")]
		public virtual unsafe void OnFooterPulling (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer, float percent, int offset, int footerHeight, int extendHeight)
		{
			const string __id = "onFooterPulling.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footer).Handle);
				__args [1] = new JniArgumentValue (percent);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (footerHeight);
				__args [4] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
#pragma warning disable 0169
		static Delegate GetOnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler ()
		{
			if (cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII == null)
				cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII);
			return cb_onFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII;
		}

		static void n_OnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_footer, float percent, int offset, int footerHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_footer, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterReleasing (footer, percent, offset, footerHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onFooterReleasing' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onFooterReleasing", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V", "GetOnFooterReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_FIIIHandler")]
		public virtual unsafe void OnFooterReleasing (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer, float percent, int offset, int footerHeight, int extendHeight)
		{
			const string __id = "onFooterReleasing.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footer).Handle);
				__args [1] = new JniArgumentValue (percent);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (footerHeight);
				__args [4] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
#pragma warning disable 0169
		static Delegate GetOnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler ()
		{
			if (cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == null)
				cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II);
			return cb_onFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
		}

		static void n_OnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II (IntPtr jnienv, IntPtr native__this, IntPtr native_footer, int headHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_footer, JniHandleOwnership.DoNotTransfer);
			__this.OnFooterStartAnimator (footer, headHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onFooterStartAnimator' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onFooterStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)V", "GetOnFooterStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler")]
		public virtual unsafe void OnFooterStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter footer, int headHeight, int extendHeight)
		{
			const string __id = "onFooterStartAnimator.(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((footer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) footer).Handle);
				__args [1] = new JniArgumentValue (headHeight);
				__args [2] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z;
#pragma warning disable 0169
		static Delegate GetOnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ZHandler ()
		{
			if (cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z == null)
				cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z);
			return cb_onHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z;
		}

		static void n_OnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_header, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_header, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderFinish (header, success);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onHeaderFinish' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='boolean']]"
		[Register ("onHeaderFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;Z)V", "GetOnHeaderFinish_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ZHandler")]
		public virtual unsafe void OnHeaderFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header, bool success)
		{
			const string __id = "onHeaderFinish.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				__args [1] = new JniArgumentValue (success);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
#pragma warning disable 0169
		static Delegate GetOnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler ()
		{
			if (cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII == null)
				cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII);
			return cb_onHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
		}

		static void n_OnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_header, float percent, int offset, int headerHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_header, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderPulling (header, percent, offset, headerHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onHeaderPulling' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onHeaderPulling", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V", "GetOnHeaderPulling_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler")]
		public virtual unsafe void OnHeaderPulling (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header, float percent, int offset, int headerHeight, int extendHeight)
		{
			const string __id = "onHeaderPulling.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				__args [1] = new JniArgumentValue (percent);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (headerHeight);
				__args [4] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
#pragma warning disable 0169
		static Delegate GetOnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler ()
		{
			if (cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII == null)
				cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, int, int, int>) n_OnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII);
			return cb_onHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII;
		}

		static void n_OnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIII (IntPtr jnienv, IntPtr native__this, IntPtr native_header, float percent, int offset, int footerHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_header, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderReleasing (header, percent, offset, footerHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onHeaderReleasing' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onHeaderReleasing", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V", "GetOnHeaderReleasing_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_FIIIHandler")]
		public virtual unsafe void OnHeaderReleasing (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header, float percent, int offset, int footerHeight, int extendHeight)
		{
			const string __id = "onHeaderReleasing.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				__args [1] = new JniArgumentValue (percent);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (footerHeight);
				__args [4] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
#pragma warning disable 0169
		static Delegate GetOnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler ()
		{
			if (cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == null)
				cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II);
			return cb_onHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
		}

		static void n_OnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II (IntPtr jnienv, IntPtr native__this, IntPtr native_header, int footerHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_header, JniHandleOwnership.DoNotTransfer);
			__this.OnHeaderStartAnimator (header, footerHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onHeaderStartAnimator' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onHeaderStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)V", "GetOnHeaderStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler")]
		public virtual unsafe void OnHeaderStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader header, int footerHeight, int extendHeight)
		{
			const string __id = "onHeaderStartAnimator.(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((header == null) ? IntPtr.Zero : ((global::Java.Lang.Object) header).Handle);
				__args [1] = new JniArgumentValue (footerHeight);
				__args [2] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
#pragma warning disable 0169
		static Delegate GetOnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler ()
		{
			if (cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == null)
				cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_);
			return cb_onLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		}

		static void n_OnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshlayout)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshlayout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_refreshlayout, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadmore (refreshlayout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onLoadmore' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout']]"
		[Register ("onLoadmore", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V", "GetOnLoadmore_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler")]
		public virtual unsafe void OnLoadmore (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshlayout)
		{
			const string __id = "onLoadmore.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((refreshlayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshlayout).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
#pragma warning disable 0169
		static Delegate GetOnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler ()
		{
			if (cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == null)
				cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_);
			return cb_onRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		}

		static void n_OnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshlayout)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshlayout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_refreshlayout, JniHandleOwnership.DoNotTransfer);
			__this.OnRefresh (refreshlayout);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onRefresh' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout']]"
		[Register ("onRefresh", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V", "GetOnRefresh_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler")]
		public virtual unsafe void OnRefresh (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshlayout)
		{
			const string __id = "onRefresh.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((refreshlayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshlayout).Handle);
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
			global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.SimpleMultiPurposeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshLayout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_refreshLayout, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState oldState = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_oldState, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState newState = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_newState, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (refreshLayout, oldState, newState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/class[@name='SimpleMultiPurposeListener']/method[@name='onStateChanged' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='com.scwang.smartrefresh.layout.constant.RefreshState'] and parameter[3][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
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

	}
}
