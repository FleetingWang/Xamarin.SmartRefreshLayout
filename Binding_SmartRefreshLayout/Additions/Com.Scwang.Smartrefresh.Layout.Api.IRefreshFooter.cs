using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshFooter']"
	[Register ("com/scwang/smartrefresh/layout/api/RefreshFooter", "", "Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooterInvoker")]
	public partial interface IRefreshFooter : global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshInternal {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshFooter']/method[@name='onPullReleasing' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onPullReleasing", "(FIII)V", "GetOnPullReleasing_FIIIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooterInvoker, Binding_SmartRefreshLayout")]
		void OnPullReleasing (float p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshFooter']/method[@name='onPullingUp' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onPullingUp", "(FIII)V", "GetOnPullingUp_FIIIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooterInvoker, Binding_SmartRefreshLayout")]
		void OnPullingUp (float p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshFooter']/method[@name='setLoadmoreFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoadmoreFinished", "(Z)Z", "GetSetLoadmoreFinished_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooterInvoker, Binding_SmartRefreshLayout")]
		bool SetLoadmoreFinished (bool p0);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/api/RefreshFooter", DoNotGenerateAcw=true)]
	internal class IRefreshFooterInvoker : global::Java.Lang.Object, IRefreshFooter {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/api/RefreshFooter", typeof (IRefreshFooterInvoker));

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

		public static IRefreshFooter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefreshFooter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.api.RefreshFooter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefreshFooterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPullReleasing_FIII;
#pragma warning disable 0169
		static Delegate GetOnPullReleasing_FIIIHandler ()
		{
			if (cb_onPullReleasing_FIII == null)
				cb_onPullReleasing_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int, int>) n_OnPullReleasing_FIII);
			return cb_onPullReleasing_FIII;
		}

		static void n_OnPullReleasing_FIII (IntPtr jnienv, IntPtr native__this, float p0, int p1, int p2, int p3)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullReleasing (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onPullReleasing_FIII;
		public unsafe void OnPullReleasing (float p0, int p1, int p2, int p3)
		{
			if (id_onPullReleasing_FIII == IntPtr.Zero)
				id_onPullReleasing_FIII = JNIEnv.GetMethodID (class_ref, "onPullReleasing", "(FIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPullReleasing_FIII, __args);
		}

		static Delegate cb_onPullingUp_FIII;
#pragma warning disable 0169
		static Delegate GetOnPullingUp_FIIIHandler ()
		{
			if (cb_onPullingUp_FIII == null)
				cb_onPullingUp_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int, int>) n_OnPullingUp_FIII);
			return cb_onPullingUp_FIII;
		}

		static void n_OnPullingUp_FIII (IntPtr jnienv, IntPtr native__this, float p0, int p1, int p2, int p3)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullingUp (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onPullingUp_FIII;
		public unsafe void OnPullingUp (float p0, int p1, int p2, int p3)
		{
			if (id_onPullingUp_FIII == IntPtr.Zero)
				id_onPullingUp_FIII = JNIEnv.GetMethodID (class_ref, "onPullingUp", "(FIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPullingUp_FIII, __args);
		}

		static Delegate cb_setLoadmoreFinished_Z;
#pragma warning disable 0169
		static Delegate GetSetLoadmoreFinished_ZHandler ()
		{
			if (cb_setLoadmoreFinished_Z == null)
				cb_setLoadmoreFinished_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetLoadmoreFinished_Z);
			return cb_setLoadmoreFinished_Z;
		}

		static bool n_SetLoadmoreFinished_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetLoadmoreFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLoadmoreFinished_Z;
		public unsafe bool SetLoadmoreFinished (bool p0)
		{
			if (id_setLoadmoreFinished_Z == IntPtr.Zero)
				id_setLoadmoreFinished_Z = JNIEnv.GetMethodID (class_ref, "setLoadmoreFinished", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setLoadmoreFinished_Z, __args);
		}

		static Delegate cb_isSupportHorizontalDrag;
#pragma warning disable 0169
		static Delegate GetIsSupportHorizontalDragHandler ()
		{
			if (cb_isSupportHorizontalDrag == null)
				cb_isSupportHorizontalDrag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportHorizontalDrag);
			return cb_isSupportHorizontalDrag;
		}

		static bool n_IsSupportHorizontalDrag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportHorizontalDrag;
		}
#pragma warning restore 0169

		IntPtr id_isSupportHorizontalDrag;
		public unsafe bool IsSupportHorizontalDrag {
			get {
				if (id_isSupportHorizontalDrag == IntPtr.Zero)
					id_isSupportHorizontalDrag = JNIEnv.GetMethodID (class_ref, "isSupportHorizontalDrag", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportHorizontalDrag);
			}
		}

		static Delegate cb_getSpinnerStyle;
#pragma warning disable 0169
		static Delegate GetGetSpinnerStyleHandler ()
		{
			if (cb_getSpinnerStyle == null)
				cb_getSpinnerStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpinnerStyle);
			return cb_getSpinnerStyle;
		}

		static IntPtr n_GetSpinnerStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SpinnerStyle);
		}
#pragma warning restore 0169

		IntPtr id_getSpinnerStyle;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle SpinnerStyle {
			get {
				if (id_getSpinnerStyle == IntPtr.Zero)
					id_getSpinnerStyle = JNIEnv.GetMethodID (class_ref, "getSpinnerStyle", "()Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;");
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpinnerStyle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		IntPtr id_getView;
		public unsafe global::Android.Views.View View {
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
#pragma warning disable 0169
		static Delegate GetOnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ZHandler ()
		{
			if (cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z == null)
				cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int>) n_OnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z);
			return cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
		}

		static int n_OnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnFinish (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
		public unsafe int OnFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, bool p1)
		{
			if (id_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z == IntPtr.Zero)
				id_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z = JNIEnv.GetMethodID (class_ref, "onFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Z)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z, __args);
			return __ret;
		}

		static Delegate cb_onHorizontalDrag_FII;
#pragma warning disable 0169
		static Delegate GetOnHorizontalDrag_FIIHandler ()
		{
			if (cb_onHorizontalDrag_FII == null)
				cb_onHorizontalDrag_FII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int>) n_OnHorizontalDrag_FII);
			return cb_onHorizontalDrag_FII;
		}

		static void n_OnHorizontalDrag_FII (IntPtr jnienv, IntPtr native__this, float p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHorizontalDrag (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onHorizontalDrag_FII;
		public unsafe void OnHorizontalDrag (float p0, int p1, int p2)
		{
			if (id_onHorizontalDrag_FII == IntPtr.Zero)
				id_onHorizontalDrag_FII = JNIEnv.GetMethodID (class_ref, "onHorizontalDrag", "(FII)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHorizontalDrag_FII, __args);
		}

		static Delegate cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
#pragma warning disable 0169
		static Delegate GetOnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IIHandler ()
		{
			if (cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II == null)
				cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II);
			return cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
		}

		static void n_OnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialized (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
		public unsafe void OnInitialized (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0, int p1, int p2)
		{
			if (id_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II == IntPtr.Zero)
				id_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II = JNIEnv.GetMethodID (class_ref, "onInitialized", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II, __args);
		}

		static Delegate cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
#pragma warning disable 0169
		static Delegate GetOnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_IIHandler ()
		{
			if (cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II == null)
				cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II);
			return cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
		}

		static void n_OnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStartAnimator (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
		public unsafe void OnStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, int p1, int p2)
		{
			if (id_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II == IntPtr.Zero)
				id_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II = JNIEnv.GetMethodID (class_ref, "onStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II, __args);
		}

		static Delegate cb_setPrimaryColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColors_arrayIHandler ()
		{
			if (cb_setPrimaryColors_arrayI == null)
				cb_setPrimaryColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrimaryColors_arrayI);
			return cb_setPrimaryColors_arrayI;
		}

		static void n_SetPrimaryColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetPrimaryColors (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setPrimaryColors_arrayI;
		public unsafe void SetPrimaryColors (params  int[] p0)
		{
			if (id_setPrimaryColors_arrayI == IntPtr.Zero)
				id_setPrimaryColors_arrayI = JNIEnv.GetMethodID (class_ref, "setPrimaryColors", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrimaryColors_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
		static Delegate GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler ()
		{
			if (cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
				cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
			return cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		}

		static void n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1 = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2 = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		public unsafe void OnStateChanged (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout p0, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p1, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState p2)
		{
			if (id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == IntPtr.Zero)
				id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNIEnv.GetMethodID (class_ref, "onStateChanged", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_, __args);
		}

	}

}
