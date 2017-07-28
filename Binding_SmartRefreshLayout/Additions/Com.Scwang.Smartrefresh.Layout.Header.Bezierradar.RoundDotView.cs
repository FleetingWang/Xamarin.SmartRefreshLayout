using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Header.Bezierradar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundDotView']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/header/bezierradar/RoundDotView", DoNotGenerateAcw=true)]
	public partial class RoundDotView : global::Android.Views.View {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/header/bezierradar/RoundDotView", typeof (RoundDotView));
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

		protected RoundDotView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundDotView']/constructor[@name='RoundDotView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RoundDotView (global::Android.Content.Context context)
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

		static Delegate cb_setDotColor_I;
#pragma warning disable 0169
		static Delegate GetSetDotColor_IHandler ()
		{
			if (cb_setDotColor_I == null)
				cb_setDotColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDotColor_I);
			return cb_setDotColor_I;
		}

		static void n_SetDotColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundDotView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundDotView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDotColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundDotView']/method[@name='setDotColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDotColor", "(I)V", "GetSetDotColor_IHandler")]
		public virtual unsafe void SetDotColor (int color)
		{
			const string __id = "setDotColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFraction_F;
#pragma warning disable 0169
		static Delegate GetSetFraction_FHandler ()
		{
			if (cb_setFraction_F == null)
				cb_setFraction_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFraction_F);
			return cb_setFraction_F;
		}

		static void n_SetFraction_F (IntPtr jnienv, IntPtr native__this, float fraction)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundDotView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.RoundDotView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFraction (fraction);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='RoundDotView']/method[@name='setFraction' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFraction", "(F)V", "GetSetFraction_FHandler")]
		public virtual unsafe void SetFraction (float fraction)
		{
			const string __id = "setFraction.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fraction);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
