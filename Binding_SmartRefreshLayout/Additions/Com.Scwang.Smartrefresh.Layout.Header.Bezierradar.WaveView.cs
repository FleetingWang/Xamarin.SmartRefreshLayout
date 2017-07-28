using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Header.Bezierradar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/header/bezierradar/WaveView", DoNotGenerateAcw=true)]
	public partial class WaveView : global::Android.Views.View {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/header/bezierradar/WaveView", typeof (WaveView));
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

		protected WaveView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/constructor[@name='WaveView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WaveView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/constructor[@name='WaveView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WaveView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/constructor[@name='WaveView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe WaveView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getHeadHeight;
#pragma warning disable 0169
		static Delegate GetGetHeadHeightHandler ()
		{
			if (cb_getHeadHeight == null)
				cb_getHeadHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeadHeight);
			return cb_getHeadHeight;
		}

		static int n_GetHeadHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeadHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setHeadHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeadHeight_IHandler ()
		{
			if (cb_setHeadHeight_I == null)
				cb_setHeadHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeadHeight_I);
			return cb_setHeadHeight_I;
		}

		static void n_SetHeadHeight_I (IntPtr jnienv, IntPtr native__this, int headHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeadHeight = headHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int HeadHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/method[@name='getHeadHeight' and count(parameter)=0]"
			[Register ("getHeadHeight", "()I", "GetGetHeadHeightHandler")]
			get {
				const string __id = "getHeadHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/method[@name='setHeadHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeadHeight", "(I)V", "GetSetHeadHeight_IHandler")]
			set {
				const string __id = "setHeadHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWaveHeight;
#pragma warning disable 0169
		static Delegate GetGetWaveHeightHandler ()
		{
			if (cb_getWaveHeight == null)
				cb_getWaveHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWaveHeight);
			return cb_getWaveHeight;
		}

		static int n_GetWaveHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WaveHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setWaveHeight_I;
#pragma warning disable 0169
		static Delegate GetSetWaveHeight_IHandler ()
		{
			if (cb_setWaveHeight_I == null)
				cb_setWaveHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWaveHeight_I);
			return cb_setWaveHeight_I;
		}

		static void n_SetWaveHeight_I (IntPtr jnienv, IntPtr native__this, int waveHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveHeight = waveHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int WaveHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/method[@name='getWaveHeight' and count(parameter)=0]"
			[Register ("getWaveHeight", "()I", "GetGetWaveHeightHandler")]
			get {
				const string __id = "getWaveHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/method[@name='setWaveHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWaveHeight", "(I)V", "GetSetWaveHeight_IHandler")]
			set {
				const string __id = "setWaveHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setWaveColor_I;
#pragma warning disable 0169
		static Delegate GetSetWaveColor_IHandler ()
		{
			if (cb_setWaveColor_I == null)
				cb_setWaveColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWaveColor_I);
			return cb_setWaveColor_I;
		}

		static void n_SetWaveColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWaveColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/method[@name='setWaveColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWaveColor", "(I)V", "GetSetWaveColor_IHandler")]
		public virtual unsafe void SetWaveColor (int color)
		{
			const string __id = "setWaveColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setWaveOffsetX_I;
#pragma warning disable 0169
		static Delegate GetSetWaveOffsetX_IHandler ()
		{
			if (cb_setWaveOffsetX_I == null)
				cb_setWaveOffsetX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWaveOffsetX_I);
			return cb_setWaveOffsetX_I;
		}

		static void n_SetWaveOffsetX_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Header.Bezierradar.WaveView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWaveOffsetX (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.header.bezierradar']/class[@name='WaveView']/method[@name='setWaveOffsetX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWaveOffsetX", "(I)V", "GetSetWaveOffsetX_IHandler")]
		public virtual unsafe void SetWaveOffsetX (int offset)
		{
			const string __id = "setWaveOffsetX.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
