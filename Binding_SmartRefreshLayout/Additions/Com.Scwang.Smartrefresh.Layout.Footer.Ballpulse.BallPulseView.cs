using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/footer/ballpulse/BallPulseView", DoNotGenerateAcw=true)]
	public partial class BallPulseView : global::Android.Views.View {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/field[@name='DEFAULT_SIZE']"
		[Register ("DEFAULT_SIZE")]
		public const int DefaultSize = (int) 50;
		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/footer/ballpulse/BallPulseView", typeof (BallPulseView));
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

		protected BallPulseView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/constructor[@name='BallPulseView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BallPulseView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/constructor[@name='BallPulseView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BallPulseView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/constructor[@name='BallPulseView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BallPulseView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAnimatingColor_I;
#pragma warning disable 0169
		static Delegate GetSetAnimatingColor_IHandler ()
		{
			if (cb_setAnimatingColor_I == null)
				cb_setAnimatingColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimatingColor_I);
			return cb_setAnimatingColor_I;
		}

		static void n_SetAnimatingColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimatingColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/method[@name='setAnimatingColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimatingColor", "(I)V", "GetSetAnimatingColor_IHandler")]
		public virtual unsafe void SetAnimatingColor (int color)
		{
			const string __id = "setAnimatingColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorColor_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorColor_IHandler ()
		{
			if (cb_setIndicatorColor_I == null)
				cb_setIndicatorColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorColor_I);
			return cb_setIndicatorColor_I;
		}

		static void n_SetIndicatorColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler")]
		public virtual unsafe void SetIndicatorColor (int color)
		{
			const string __id = "setIndicatorColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetNormalColor_IHandler ()
		{
			if (cb_setNormalColor_I == null)
				cb_setNormalColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNormalColor_I);
			return cb_setNormalColor_I;
		}

		static void n_SetNormalColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNormalColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/method[@name='setNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNormalColor", "(I)V", "GetSetNormalColor_IHandler")]
		public virtual unsafe void SetNormalColor (int color)
		{
			const string __id = "setNormalColor.(I)V";
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
			global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAnim ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/method[@name='startAnim' and count(parameter)=0]"
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
			global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.Ballpulse.BallPulseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnim ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer.ballpulse']/class[@name='BallPulseView']/method[@name='stopAnim' and count(parameter)=0]"
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
