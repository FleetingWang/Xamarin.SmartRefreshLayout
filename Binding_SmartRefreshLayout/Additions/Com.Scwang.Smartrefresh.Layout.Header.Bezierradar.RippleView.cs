using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Header.Bezierradar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RippleView']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/header/bezierradar/RippleView", DoNotGenerateAcw=true)]
	public partial class RippleView : global::Android.Views.View {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/header/bezierradar/RippleView", typeof (RippleView));
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

		protected RippleView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RippleView']/constructor[@name='RippleView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RippleView (global::Android.Content.Context context)
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
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RippleView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RippleView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFrontColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RippleView']/method[@name='setFrontColor' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_startReveal;
#pragma warning disable 0169
		static Delegate GetStartRevealHandler ()
		{
			if (cb_startReveal == null)
				cb_startReveal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartReveal);
			return cb_startReveal;
		}

		static void n_StartReveal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RippleView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RippleView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartReveal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RippleView']/method[@name='startReveal' and count(parameter)=0]"
		[Register ("startReveal", "()V", "GetStartRevealHandler")]
		public virtual unsafe void StartReveal ()
		{
			const string __id = "startReveal.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
