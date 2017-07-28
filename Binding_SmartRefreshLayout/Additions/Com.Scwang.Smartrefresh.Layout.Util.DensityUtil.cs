using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='DensityUtil']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/util/DensityUtil", DoNotGenerateAcw=true)]
	public partial class DensityUtil : global::Java.Lang.Object {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/util/DensityUtil", typeof (DensityUtil));
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

		protected DensityUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='DensityUtil']/constructor[@name='DensityUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DensityUtil ()
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

		static Delegate cb_dip2px_F;
#pragma warning disable 0169
		static Delegate GetDip2px_FHandler ()
		{
			if (cb_dip2px_F == null)
				cb_dip2px_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_Dip2px_F);
			return cb_dip2px_F;
		}

		static int n_Dip2px_F (IntPtr jnienv, IntPtr native__this, float dpValue)
		{
			global::Com.Scwang.Smartrefresh.Layout.Util.DensityUtil __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Util.DensityUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dip2px (dpValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='DensityUtil']/method[@name='dip2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dip2px", "(F)I", "GetDip2px_FHandler")]
		public virtual unsafe int Dip2px (float dpValue)
		{
			const string __id = "dip2px.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dpValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='DensityUtil']/method[@name='dp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dp2px", "(F)I", "")]
		public static unsafe int Dp2px (float dpValue)
		{
			const string __id = "dp2px.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dpValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_px2dip_F;
#pragma warning disable 0169
		static Delegate GetPx2dip_FHandler ()
		{
			if (cb_px2dip_F == null)
				cb_px2dip_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_Px2dip_F);
			return cb_px2dip_F;
		}

		static float n_Px2dip_F (IntPtr jnienv, IntPtr native__this, float pxValue)
		{
			global::Com.Scwang.Smartrefresh.Layout.Util.DensityUtil __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Util.DensityUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Px2dip (pxValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='DensityUtil']/method[@name='px2dip' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("px2dip", "(F)F", "GetPx2dip_FHandler")]
		public virtual unsafe float Px2dip (float pxValue)
		{
			const string __id = "px2dip.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pxValue);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='DensityUtil']/method[@name='px2dp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("px2dp", "(F)F", "")]
		public static unsafe float Px2dp (float pxValue)
		{
			const string __id = "px2dp.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pxValue);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
