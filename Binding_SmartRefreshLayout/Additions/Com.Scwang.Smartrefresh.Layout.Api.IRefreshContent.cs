using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']"
	[Register ("com/scwang/smartrefresh/layout/api/RefreshContent", "", "Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker")]
	public partial interface IRefreshContent : IJavaObject {

		global::Android.Views.ViewGroup.LayoutParams LayoutParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='getLayoutParams' and count(parameter)=0]"
			[Register ("getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", "GetGetLayoutParamsHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")] get;
		}

		int MeasuredHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='getMeasuredHeight' and count(parameter)=0]"
			[Register ("getMeasuredHeight", "()I", "GetGetMeasuredHeightHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")] get;
		}

		int MeasuredWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='getMeasuredWidth' and count(parameter)=0]"
			[Register ("getMeasuredWidth", "()I", "GetGetMeasuredWidthHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Android.Views.View ScrollableView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='getScrollableView' and count(parameter)=0]"
			[Register ("getScrollableView", "()Landroid/view/View;", "GetGetScrollableViewHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='canScrollDown' and count(parameter)=0]"
		[Register ("canScrollDown", "()Z", "GetCanScrollDownHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		bool CanScrollDown ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='canScrollUp' and count(parameter)=0]"
		[Register ("canScrollUp", "()Z", "GetCanScrollUpHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		bool CanScrollUp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='isNestedScrollingChild' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("isNestedScrollingChild", "(Landroid/view/MotionEvent;)Z", "GetIsNestedScrollingChild_Landroid_view_MotionEvent_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		bool IsNestedScrollingChild (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='layout' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("layout", "(IIII)V", "GetLayout_IIIIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void Layout (int p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='measure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("measure", "(II)V", "GetMeasure_IIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void Measure (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='moveSpinner' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("moveSpinner", "(I)V", "GetMoveSpinner_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void MoveSpinner (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='onActionDown' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onActionDown", "(Landroid/view/MotionEvent;)V", "GetOnActionDown_Landroid_view_MotionEvent_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void OnActionDown (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='onActionUpOrCancel' and count(parameter)=0]"
		[Register ("onActionUpOrCancel", "()V", "GetOnActionUpOrCancelHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void OnActionUpOrCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='onInitialHeaderAndFooter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onInitialHeaderAndFooter", "(II)V", "GetOnInitialHeaderAndFooter_IIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void OnInitialHeaderAndFooter (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='onLoadingFinish' and count(parameter)=5 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshKernel'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.view.animation.Interpolator'] and parameter[5][@type='int']]"
		[Register ("onLoadingFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;IILandroid/view/animation/Interpolator;I)Landroid/animation/ValueAnimator$AnimatorUpdateListener;", "GetOnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		global::Android.Animation.ValueAnimator.IAnimatorUpdateListener OnLoadingFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0, int p1, int p2, global::Android.Views.Animations.IInterpolator p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='setRefreshScrollBoundary' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshScrollBoundary']]"
		[Register ("setRefreshScrollBoundary", "(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)V", "GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void SetRefreshScrollBoundary (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshContent']/method[@name='setupComponent' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshKernel'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.View']]"
		[Register ("setupComponent", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;Landroid/view/View;Landroid/view/View;)V", "GetSetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshContentInvoker, Binding_SmartRefreshLayout")]
		void SetupComponent (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0, global::Android.Views.View p1, global::Android.Views.View p2);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/api/RefreshContent", DoNotGenerateAcw=true)]
	internal class IRefreshContentInvoker : global::Java.Lang.Object, IRefreshContent {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/api/RefreshContent", typeof (IRefreshContentInvoker));

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

		public static IRefreshContent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefreshContent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.api.RefreshContent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefreshContentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLayoutParams;
#pragma warning disable 0169
		static Delegate GetGetLayoutParamsHandler ()
		{
			if (cb_getLayoutParams == null)
				cb_getLayoutParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayoutParams);
			return cb_getLayoutParams;
		}

		static IntPtr n_GetLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LayoutParams);
		}
#pragma warning restore 0169

		IntPtr id_getLayoutParams;
		public unsafe global::Android.Views.ViewGroup.LayoutParams LayoutParams {
			get {
				if (id_getLayoutParams == IntPtr.Zero)
					id_getLayoutParams = JNIEnv.GetMethodID (class_ref, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayoutParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMeasuredHeight;
#pragma warning disable 0169
		static Delegate GetGetMeasuredHeightHandler ()
		{
			if (cb_getMeasuredHeight == null)
				cb_getMeasuredHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMeasuredHeight);
			return cb_getMeasuredHeight;
		}

		static int n_GetMeasuredHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasuredHeight;
		}
#pragma warning restore 0169

		IntPtr id_getMeasuredHeight;
		public unsafe int MeasuredHeight {
			get {
				if (id_getMeasuredHeight == IntPtr.Zero)
					id_getMeasuredHeight = JNIEnv.GetMethodID (class_ref, "getMeasuredHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMeasuredHeight);
			}
		}

		static Delegate cb_getMeasuredWidth;
#pragma warning disable 0169
		static Delegate GetGetMeasuredWidthHandler ()
		{
			if (cb_getMeasuredWidth == null)
				cb_getMeasuredWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMeasuredWidth);
			return cb_getMeasuredWidth;
		}

		static int n_GetMeasuredWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasuredWidth;
		}
#pragma warning restore 0169

		IntPtr id_getMeasuredWidth;
		public unsafe int MeasuredWidth {
			get {
				if (id_getMeasuredWidth == IntPtr.Zero)
					id_getMeasuredWidth = JNIEnv.GetMethodID (class_ref, "getMeasuredWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMeasuredWidth);
			}
		}

		static Delegate cb_getScrollableView;
#pragma warning disable 0169
		static Delegate GetGetScrollableViewHandler ()
		{
			if (cb_getScrollableView == null)
				cb_getScrollableView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScrollableView);
			return cb_getScrollableView;
		}

		static IntPtr n_GetScrollableView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScrollableView);
		}
#pragma warning restore 0169

		IntPtr id_getScrollableView;
		public unsafe global::Android.Views.View ScrollableView {
			get {
				if (id_getScrollableView == IntPtr.Zero)
					id_getScrollableView = JNIEnv.GetMethodID (class_ref, "getScrollableView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScrollableView), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_canScrollDown;
#pragma warning disable 0169
		static Delegate GetCanScrollDownHandler ()
		{
			if (cb_canScrollDown == null)
				cb_canScrollDown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanScrollDown);
			return cb_canScrollDown;
		}

		static bool n_CanScrollDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanScrollDown ();
		}
#pragma warning restore 0169

		IntPtr id_canScrollDown;
		public unsafe bool CanScrollDown ()
		{
			if (id_canScrollDown == IntPtr.Zero)
				id_canScrollDown = JNIEnv.GetMethodID (class_ref, "canScrollDown", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canScrollDown);
		}

		static Delegate cb_canScrollUp;
#pragma warning disable 0169
		static Delegate GetCanScrollUpHandler ()
		{
			if (cb_canScrollUp == null)
				cb_canScrollUp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanScrollUp);
			return cb_canScrollUp;
		}

		static bool n_CanScrollUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanScrollUp ();
		}
#pragma warning restore 0169

		IntPtr id_canScrollUp;
		public unsafe bool CanScrollUp ()
		{
			if (id_canScrollUp == IntPtr.Zero)
				id_canScrollUp = JNIEnv.GetMethodID (class_ref, "canScrollUp", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canScrollUp);
		}

		static Delegate cb_isNestedScrollingChild_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetIsNestedScrollingChild_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_isNestedScrollingChild_Landroid_view_MotionEvent_ == null)
				cb_isNestedScrollingChild_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsNestedScrollingChild_Landroid_view_MotionEvent_);
			return cb_isNestedScrollingChild_Landroid_view_MotionEvent_;
		}

		static bool n_IsNestedScrollingChild_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsNestedScrollingChild (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isNestedScrollingChild_Landroid_view_MotionEvent_;
		public unsafe bool IsNestedScrollingChild (global::Android.Views.MotionEvent p0)
		{
			if (id_isNestedScrollingChild_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_isNestedScrollingChild_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "isNestedScrollingChild", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNestedScrollingChild_Landroid_view_MotionEvent_, __args);
			return __ret;
		}

		static Delegate cb_layout_IIII;
#pragma warning disable 0169
		static Delegate GetLayout_IIIIHandler ()
		{
			if (cb_layout_IIII == null)
				cb_layout_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_Layout_IIII);
			return cb_layout_IIII;
		}

		static void n_Layout_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Layout (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_layout_IIII;
		public unsafe void Layout (int p0, int p1, int p2, int p3)
		{
			if (id_layout_IIII == IntPtr.Zero)
				id_layout_IIII = JNIEnv.GetMethodID (class_ref, "layout", "(IIII)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_layout_IIII, __args);
		}

		static Delegate cb_measure_II;
#pragma warning disable 0169
		static Delegate GetMeasure_IIHandler ()
		{
			if (cb_measure_II == null)
				cb_measure_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Measure_II);
			return cb_measure_II;
		}

		static void n_Measure_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Measure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_measure_II;
		public unsafe void Measure (int p0, int p1)
		{
			if (id_measure_II == IntPtr.Zero)
				id_measure_II = JNIEnv.GetMethodID (class_ref, "measure", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_measure_II, __args);
		}

		static Delegate cb_moveSpinner_I;
#pragma warning disable 0169
		static Delegate GetMoveSpinner_IHandler ()
		{
			if (cb_moveSpinner_I == null)
				cb_moveSpinner_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_MoveSpinner_I);
			return cb_moveSpinner_I;
		}

		static void n_MoveSpinner_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveSpinner (p0);
		}
#pragma warning restore 0169

		IntPtr id_moveSpinner_I;
		public unsafe void MoveSpinner (int p0)
		{
			if (id_moveSpinner_I == IntPtr.Zero)
				id_moveSpinner_I = JNIEnv.GetMethodID (class_ref, "moveSpinner", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveSpinner_I, __args);
		}

		static Delegate cb_onActionDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnActionDown_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onActionDown_Landroid_view_MotionEvent_ == null)
				cb_onActionDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionDown_Landroid_view_MotionEvent_);
			return cb_onActionDown_Landroid_view_MotionEvent_;
		}

		static void n_OnActionDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionDown (p0);
		}
#pragma warning restore 0169

		IntPtr id_onActionDown_Landroid_view_MotionEvent_;
		public unsafe void OnActionDown (global::Android.Views.MotionEvent p0)
		{
			if (id_onActionDown_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onActionDown_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onActionDown", "(Landroid/view/MotionEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActionDown_Landroid_view_MotionEvent_, __args);
		}

		static Delegate cb_onActionUpOrCancel;
#pragma warning disable 0169
		static Delegate GetOnActionUpOrCancelHandler ()
		{
			if (cb_onActionUpOrCancel == null)
				cb_onActionUpOrCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnActionUpOrCancel);
			return cb_onActionUpOrCancel;
		}

		static void n_OnActionUpOrCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionUpOrCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onActionUpOrCancel;
		public unsafe void OnActionUpOrCancel ()
		{
			if (id_onActionUpOrCancel == IntPtr.Zero)
				id_onActionUpOrCancel = JNIEnv.GetMethodID (class_ref, "onActionUpOrCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActionUpOrCancel);
		}

		static Delegate cb_onInitialHeaderAndFooter_II;
#pragma warning disable 0169
		static Delegate GetOnInitialHeaderAndFooter_IIHandler ()
		{
			if (cb_onInitialHeaderAndFooter_II == null)
				cb_onInitialHeaderAndFooter_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnInitialHeaderAndFooter_II);
			return cb_onInitialHeaderAndFooter_II;
		}

		static void n_OnInitialHeaderAndFooter_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialHeaderAndFooter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInitialHeaderAndFooter_II;
		public unsafe void OnInitialHeaderAndFooter (int p0, int p1)
		{
			if (id_onInitialHeaderAndFooter_II == IntPtr.Zero)
				id_onInitialHeaderAndFooter_II = JNIEnv.GetMethodID (class_ref, "onInitialHeaderAndFooter", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitialHeaderAndFooter_II, __args);
		}

		static Delegate cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I;
#pragma warning disable 0169
		static Delegate GetOnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_IHandler ()
		{
			if (cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I == null)
				cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, IntPtr>) n_OnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I);
			return cb_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I;
		}

		static IntPtr n_OnLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p3 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnLoadingFinish (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I;
		public unsafe global::Android.Animation.ValueAnimator.IAnimatorUpdateListener OnLoadingFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0, int p1, int p2, global::Android.Views.Animations.IInterpolator p3, int p4)
		{
			if (id_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I == IntPtr.Zero)
				id_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I = JNIEnv.GetMethodID (class_ref, "onLoadingFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;IILandroid/view/animation/Interpolator;I)Landroid/animation/ValueAnimator$AnimatorUpdateListener;");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			global::Android.Animation.ValueAnimator.IAnimatorUpdateListener __ret = global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator.IAnimatorUpdateListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onLoadingFinish_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IILandroid_view_animation_Interpolator_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
#pragma warning disable 0169
		static Delegate GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler ()
		{
			if (cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ == null)
				cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_);
			return cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
		}

		static void n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRefreshScrollBoundary (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
		public unsafe void SetRefreshScrollBoundary (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary p0)
		{
			if (id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ == IntPtr.Zero)
				id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ = JNIEnv.GetMethodID (class_ref, "setRefreshScrollBoundary", "(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_, __args);
		}

		static Delegate cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_Handler ()
		{
			if (cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ == null)
				cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_);
			return cb_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_;
		}

		static void n_SetupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p2 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetupComponent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_;
		public unsafe void SetupComponent (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel p0, global::Android.Views.View p1, global::Android.Views.View p2)
		{
			if (id_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
				id_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setupComponent", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;Landroid/view/View;Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setupComponent_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_Landroid_view_View_Landroid_view_View_, __args);
		}

	}

}
