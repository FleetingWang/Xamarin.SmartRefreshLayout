using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshScrollBoundary']"
	[Register ("com/scwang/smartrefresh/layout/api/RefreshScrollBoundary", "", "Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundaryInvoker")]
	public partial interface IRefreshScrollBoundary : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshScrollBoundary']/method[@name='canPullDown' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canPullDown", "(Landroid/view/View;)Z", "GetCanPullDown_Landroid_view_View_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundaryInvoker, Binding_SmartRefreshLayout")]
		bool CanPullDown (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshScrollBoundary']/method[@name='canPullUp' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("canPullUp", "(Landroid/view/View;)Z", "GetCanPullUp_Landroid_view_View_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundaryInvoker, Binding_SmartRefreshLayout")]
		bool CanPullUp (global::Android.Views.View p0);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/api/RefreshScrollBoundary", DoNotGenerateAcw=true)]
	internal class IRefreshScrollBoundaryInvoker : global::Java.Lang.Object, IRefreshScrollBoundary {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/api/RefreshScrollBoundary", typeof (IRefreshScrollBoundaryInvoker));

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

		public static IRefreshScrollBoundary GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefreshScrollBoundary> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.api.RefreshScrollBoundary"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefreshScrollBoundaryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_canPullDown_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCanPullDown_Landroid_view_View_Handler ()
		{
			if (cb_canPullDown_Landroid_view_View_ == null)
				cb_canPullDown_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanPullDown_Landroid_view_View_);
			return cb_canPullDown_Landroid_view_View_;
		}

		static bool n_CanPullDown_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanPullDown (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canPullDown_Landroid_view_View_;
		public unsafe bool CanPullDown (global::Android.Views.View p0)
		{
			if (id_canPullDown_Landroid_view_View_ == IntPtr.Zero)
				id_canPullDown_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "canPullDown", "(Landroid/view/View;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canPullDown_Landroid_view_View_, __args);
			return __ret;
		}

		static Delegate cb_canPullUp_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCanPullUp_Landroid_view_View_Handler ()
		{
			if (cb_canPullUp_Landroid_view_View_ == null)
				cb_canPullUp_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanPullUp_Landroid_view_View_);
			return cb_canPullUp_Landroid_view_View_;
		}

		static bool n_CanPullUp_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanPullUp (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canPullUp_Landroid_view_View_;
		public unsafe bool CanPullUp (global::Android.Views.View p0)
		{
			if (id_canPullUp_Landroid_view_View_ == IntPtr.Zero)
				id_canPullUp_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "canPullUp", "(Landroid/view/View;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canPullUp_Landroid_view_View_, __args);
			return __ret;
		}

	}

}
