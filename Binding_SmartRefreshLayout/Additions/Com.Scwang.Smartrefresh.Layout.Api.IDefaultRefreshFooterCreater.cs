using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='DefaultRefreshFooterCreater']"
	[Register ("com/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater", "", "Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreaterInvoker")]
	public partial interface IDefaultRefreshFooterCreater : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='DefaultRefreshFooterCreater']/method[@name='createRefreshFooter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.scwang.smartrefresh.layout.api.RefreshLayout']]"
		[Register ("createRefreshFooter", "(Landroid/content/Context;Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)Lcom/scwang/smartrefresh/layout/api/RefreshFooter;", "GetCreateRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler:Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreaterInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter CreateRefreshFooter (global::Android.Content.Context p0, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p1);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater", DoNotGenerateAcw=true)]
	internal class IDefaultRefreshFooterCreaterInvoker : global::Java.Lang.Object, IDefaultRefreshFooterCreater {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/api/DefaultRefreshFooterCreater", typeof (IDefaultRefreshFooterCreaterInvoker));

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

		public static IDefaultRefreshFooterCreater GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDefaultRefreshFooterCreater> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.api.DefaultRefreshFooterCreater"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDefaultRefreshFooterCreaterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
#pragma warning disable 0169
		static Delegate GetCreateRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Handler ()
		{
			if (cb_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == null)
				cb_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_);
			return cb_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		}

		static IntPtr n_CreateRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreater __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IDefaultRefreshFooterCreater> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p1 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRefreshFooter (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter CreateRefreshFooter (global::Android.Content.Context p0, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p1)
		{
			if (id_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ == IntPtr.Zero)
				id_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ = JNIEnv.GetMethodID (class_ref, "createRefreshFooter", "(Landroid/content/Context;Lcom/scwang/smartrefresh/layout/api/RefreshLayout;)Lcom/scwang/smartrefresh/layout/api/RefreshFooter;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createRefreshFooter_Landroid_content_Context_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
