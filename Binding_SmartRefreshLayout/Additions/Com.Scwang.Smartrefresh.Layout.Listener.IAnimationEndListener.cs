using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='AnimationEndListener']"
	[Register ("com/scwang/smartrefresh/layout/listener/AnimationEndListener", "", "Com.Scwang.Smartrefresh.Layout.Listener.IAnimationEndListenerInvoker")]
	public partial interface IAnimationEndListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.listener']/interface[@name='AnimationEndListener']/method[@name='onAnimationEnd' and count(parameter)=0]"
		[Register ("onAnimationEnd", "()V", "GetOnAnimationEndHandler:Com.Scwang.Smartrefresh.Layout.Listener.IAnimationEndListenerInvoker, Binding_SmartRefreshLayout")]
		void OnAnimationEnd ();

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/listener/AnimationEndListener", DoNotGenerateAcw=true)]
	internal class IAnimationEndListenerInvoker : global::Java.Lang.Object, IAnimationEndListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/listener/AnimationEndListener", typeof (IAnimationEndListenerInvoker));

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

		public static IAnimationEndListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAnimationEndListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.listener.AnimationEndListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAnimationEndListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAnimationEnd;
#pragma warning disable 0169
		static Delegate GetOnAnimationEndHandler ()
		{
			if (cb_onAnimationEnd == null)
				cb_onAnimationEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationEnd);
			return cb_onAnimationEnd;
		}

		static void n_OnAnimationEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Listener.IAnimationEndListener __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IAnimationEndListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd ();
		}
#pragma warning restore 0169

		IntPtr id_onAnimationEnd;
		public unsafe void OnAnimationEnd ()
		{
			if (id_onAnimationEnd == IntPtr.Zero)
				id_onAnimationEnd = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnimationEnd);
		}

	}

	[global::Android.Runtime.Register ("mono/com/scwang/smartrefresh/layout/listener/AnimationEndListenerImplementor")]
	internal sealed partial class IAnimationEndListenerImplementor : global::Java.Lang.Object, IAnimationEndListener {

		object sender;

		public IAnimationEndListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/scwang/smartrefresh/layout/listener/AnimationEndListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnAnimationEnd ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IAnimationEndListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
