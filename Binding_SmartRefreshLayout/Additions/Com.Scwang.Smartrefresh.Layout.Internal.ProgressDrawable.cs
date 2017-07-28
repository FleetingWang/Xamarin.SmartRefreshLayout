using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/internal/ProgressDrawable", DoNotGenerateAcw=true)]
	public partial class ProgressDrawable : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.IAnimatable {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/internal/ProgressDrawable", typeof (ProgressDrawable));
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

		protected ProgressDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/constructor[@name='ProgressDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProgressDrawable ()
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

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				const string __id = "getOpacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_height;
#pragma warning disable 0169
		static Delegate GetHeightHandler ()
		{
			if (cb_height == null)
				cb_height = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Height);
			return cb_height;
		}

		static int n_Height (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='height' and count(parameter)=0]"
		[Register ("height", "()I", "GetHeightHandler")]
		public virtual unsafe int Height ()
		{
			const string __id = "height.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int alpha)
		{
			const string __id = "setAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public virtual unsafe void SetColor (int color)
		{
			const string __id = "setColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cf)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter cf = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_cf, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (cf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter cf)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_width;
#pragma warning disable 0169
		static Delegate GetWidthHandler ()
		{
			if (cb_width == null)
				cb_width = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Width);
			return cb_width;
		}

		static int n_Width (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.ProgressDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal']/class[@name='ProgressDrawable']/method[@name='width' and count(parameter)=0]"
		[Register ("width", "()I", "GetWidthHandler")]
		public virtual unsafe int Width ()
		{
			const string __id = "width.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
