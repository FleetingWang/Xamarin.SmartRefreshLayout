using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/util/ScrollBoundaryUtil", DoNotGenerateAcw=true)]
	public partial class ScrollBoundaryUtil : global::Java.Lang.Object {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/util/ScrollBoundaryUtil", typeof (ScrollBoundaryUtil));
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

		protected ScrollBoundaryUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/constructor[@name='ScrollBoundaryUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScrollBoundaryUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='canScrollDown' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canScrollDown", "(Landroid/view/View;)Z", "")]
		public static unsafe bool CanScrollDown (global::Android.Views.View targetView)
		{
			const string __id = "canScrollDown.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetView).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='canScrollDown' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("canScrollDown", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "")]
		public static unsafe bool CanScrollDown (global::Android.Views.View targetView, global::Android.Views.MotionEvent e)
		{
			const string __id = "canScrollDown.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((targetView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetView).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='canScrollUp' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canScrollUp", "(Landroid/view/View;)Z", "")]
		public static unsafe bool CanScrollUp (global::Android.Views.View targetView)
		{
			const string __id = "canScrollUp.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((targetView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetView).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='canScrollUp' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("canScrollUp", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "")]
		public static unsafe bool CanScrollUp (global::Android.Views.View targetView, global::Android.Views.MotionEvent e)
		{
			const string __id = "canScrollUp.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((targetView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) targetView).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='isTransformedTouchPointInView' and count(parameter)=5 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.PointF']]"
		[Register ("isTransformedTouchPointInView", "(Landroid/view/ViewGroup;Landroid/view/View;FFLandroid/graphics/PointF;)Z", "")]
		public static unsafe bool IsTransformedTouchPointInView (global::Android.Views.ViewGroup group, global::Android.Views.View child, float x, float y, global::Android.Graphics.PointF outLocalPoint)
		{
			const string __id = "isTransformedTouchPointInView.(Landroid/view/ViewGroup;Landroid/view/View;FFLandroid/graphics/PointF;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue ((outLocalPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outLocalPoint).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='pointInView' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("pointInView", "(Landroid/view/View;FFF)Z", "")]
		public static unsafe bool PointInView (global::Android.Views.View view, float localX, float localY, float slop)
		{
			const string __id = "pointInView.(Landroid/view/View;FFF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (localX);
				__args [2] = new JniArgumentValue (localY);
				__args [3] = new JniArgumentValue (slop);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ScrollBoundaryUtil']/method[@name='transformPointToViewLocal' and count(parameter)=3 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='android.view.View'] and parameter[3][@type='float[]']]"
		[Register ("transformPointToViewLocal", "(Landroid/view/ViewGroup;Landroid/view/View;[F)V", "")]
		public static unsafe void TransformPointToViewLocal (global::Android.Views.ViewGroup group, global::Android.Views.View child, float[] point)
		{
			const string __id = "transformPointToViewLocal.(Landroid/view/ViewGroup;Landroid/view/View;[F)V";
			IntPtr native_point = JNIEnv.NewArray (point);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((group == null) ? IntPtr.Zero : ((global::Java.Lang.Object) group).Handle);
				__args [1] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [2] = new JniArgumentValue (native_point);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (point != null) {
					JNIEnv.CopyArray (native_point, point);
					JNIEnv.DeleteLocalRef (native_point);
				}
			}
		}

	}
}
