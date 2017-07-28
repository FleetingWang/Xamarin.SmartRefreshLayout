using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Header.Bezierradar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundProgressView']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/header/bezierradar/RoundProgressView", DoNotGenerateAcw=true)]
	public partial class RoundProgressView : global::Android.Views.View {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/header/bezierradar/RoundProgressView", typeof (RoundProgressView));
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

		protected RoundProgressView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundProgressView']/constructor[@name='RoundProgressView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RoundProgressView (global::Android.Content.Context context)
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

		static Delegate cb_setBackColor_I;
#pragma warning disable 0169
		static Delegate GetSetBackColor_IHandler ()
		{
			if (cb_setBackColor_I == null)
				cb_setBackColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackColor_I);
			return cb_setBackColor_I;
		}

		static void n_SetBackColor_I (IntPtr jnienv, IntPtr native__this, int backColor)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackColor (backColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundProgressView']/method[@name='setBackColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBackColor", "(I)V", "GetSetBackColor_IHandler")]
		public virtual unsafe void SetBackColor (int backColor)
		{
			const string __id = "setBackColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (backColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFrontColor_I;
#pragma warning disable 0169
		static Delegate GetSetFrontColor_IHandler ()
		{
			if (cb_setFrontColor_I == null)
				cb_setFrontColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFrontColor_I);
			return cb_setFrontColor_I;
		}

		static void n_SetFrontColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFrontColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundProgressView']/method[@name='setFrontColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFrontColor", "(I)V", "GetSetFrontColor_IHandler")]
		public virtual unsafe void SetFrontColor (int color)
		{
			const string __id = "setFrontColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startAnim;
#pragma warning disable 0169
		static Delegate GetStartAnimHandler ()
		{
			if (cb_startAnim == null)
				cb_startAnim = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartAnim);
			return cb_startAnim;
		}

		static void n_StartAnim (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAnim ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundProgressView']/method[@name='startAnim' and count(parameter)=0]"
		[Register ("startAnim", "()V", "GetStartAnimHandler")]
		public virtual unsafe void StartAnim ()
		{
			const string __id = "startAnim.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopAnim;
#pragma warning disable 0169
		static Delegate GetStopAnimHandler ()
		{
			if (cb_stopAnim == null)
				cb_stopAnim = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAnim);
			return cb_stopAnim;
		}

		static void n_StopAnim (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundProgressView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnim ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundProgressView']/method[@name='stopAnim' and count(parameter)=0]"
		[Register ("stopAnim", "()V", "GetStopAnimHandler")]
		public virtual unsafe void StopAnim ()
		{
			const string __id = "stopAnim.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
