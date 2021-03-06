using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ViscousFluidInterpolator']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/util/ViscousFluidInterpolator", DoNotGenerateAcw=true)]
	public partial class ViscousFluidInterpolator : global::Java.Lang.Object, global::Android.Views.Animations.IInterpolator {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/util/ViscousFluidInterpolator", typeof (ViscousFluidInterpolator));
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

		protected ViscousFluidInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ViscousFluidInterpolator']/constructor[@name='ViscousFluidInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViscousFluidInterpolator ()
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

		static Delegate cb_getInterpolation_F;
#pragma warning disable 0169
		static Delegate GetGetInterpolation_FHandler ()
		{
			if (cb_getInterpolation_F == null)
				cb_getInterpolation_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetInterpolation_F);
			return cb_getInterpolation_F;
		}

		static float n_GetInterpolation_F (IntPtr jnienv, IntPtr native__this, float input)
		{
			global::Com.Scwang.Smartrefresh.Layout.Util.ViscousFluidInterpolator __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Util.ViscousFluidInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInterpolation (input);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ViscousFluidInterpolator']/method[@name='getInterpolation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getInterpolation", "(F)F", "GetGetInterpolation_FHandler")]
		public virtual unsafe float GetInterpolation (float input)
		{
			const string __id = "getInterpolation.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (input);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
