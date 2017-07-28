using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']"
	[Register ("com/scwang/smartrefresh/layout/api/RefreshKernel", "", "Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker")]
	public partial interface IRefreshKernel : IJavaObject {

		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent RefreshContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='getRefreshContent' and count(parameter)=0]"
			[Register ("getRefreshContent", "()Lcom/scwang/smartrefresh/layout/api/RefreshContent;", "GetGetRefreshContentHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout RefreshLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='getRefreshLayout' and count(parameter)=0]"
			[Register ("getRefreshLayout", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetGetRefreshLayoutHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")] get;
		}

		int Spinner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='getSpinner' and count(parameter)=0]"
			[Register ("getSpinner", "()I", "GetGetSpinnerHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='animSpinner' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animSpinner", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetAnimSpinner_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel AnimSpinner (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='animSpinnerBounce' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animSpinnerBounce", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetAnimSpinnerBounce_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel AnimSpinnerBounce (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='moveSpinner' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("moveSpinner", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetMoveSpinner_IZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinner (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='moveSpinnerInfinitely' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("moveSpinnerInfinitely", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetMoveSpinnerInfinitely_FHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinnerInfinitely (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='overSpinner' and count(parameter)=0]"
		[Register ("overSpinner", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetOverSpinnerHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel OverSpinner ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='requestDrawBackgoundForFooter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestDrawBackgoundForFooter", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestDrawBackgoundForFooter_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgoundForFooter (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='requestDrawBackgoundForHeader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestDrawBackgoundForHeader", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetRequestDrawBackgoundForHeader_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgoundForHeader (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='resetStatus' and count(parameter)=0]"
		[Register ("resetStatus", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetResetStatusHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel ResetStatus ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStateLoding' and count(parameter)=0]"
		[Register ("setStateLoding", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateLodingHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateLoding ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStateLodingFinish' and count(parameter)=0]"
		[Register ("setStateLodingFinish", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateLodingFinishHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateLodingFinish ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStatePullDownCanceled' and count(parameter)=0]"
		[Register ("setStatePullDownCanceled", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullDownCanceledHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullDownCanceled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStatePullDownToRefresh' and count(parameter)=0]"
		[Register ("setStatePullDownToRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullDownToRefreshHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullDownToRefresh ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStatePullUpCanceled' and count(parameter)=0]"
		[Register ("setStatePullUpCanceled", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullUpCanceledHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullUpCanceled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStatePullUpToLoad' and count(parameter)=0]"
		[Register ("setStatePullUpToLoad", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStatePullUpToLoadHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullUpToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStateRefresing' and count(parameter)=0]"
		[Register ("setStateRefresing", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateRefresingHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateRefresing ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStateRefresingFinish' and count(parameter)=0]"
		[Register ("setStateRefresingFinish", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateRefresingFinishHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateRefresingFinish ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStateReleaseToLoad' and count(parameter)=0]"
		[Register ("setStateReleaseToLoad", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateReleaseToLoadHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateReleaseToLoad ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshKernel']/method[@name='setStateReleaseToRefresh' and count(parameter)=0]"
		[Register ("setStateReleaseToRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;", "GetSetStateReleaseToRefreshHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernelInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateReleaseToRefresh ();

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/api/RefreshKernel", DoNotGenerateAcw=true)]
	internal class IRefreshKernelInvoker : global::Java.Lang.Object, IRefreshKernel {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/api/RefreshKernel", typeof (IRefreshKernelInvoker));

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

		public static IRefreshKernel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefreshKernel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.api.RefreshKernel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefreshKernelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getRefreshContent;
#pragma warning disable 0169
		static Delegate GetGetRefreshContentHandler ()
		{
			if (cb_getRefreshContent == null)
				cb_getRefreshContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshContent);
			return cb_getRefreshContent;
		}

		static IntPtr n_GetRefreshContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshContent);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshContent;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent RefreshContent {
			get {
				if (id_getRefreshContent == IntPtr.Zero)
					id_getRefreshContent = JNIEnv.GetMethodID (class_ref, "getRefreshContent", "()Lcom/scwang/smartrefresh/layout/api/RefreshContent;");
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshContent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefreshLayout;
#pragma warning disable 0169
		static Delegate GetGetRefreshLayoutHandler ()
		{
			if (cb_getRefreshLayout == null)
				cb_getRefreshLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshLayout);
			return cb_getRefreshLayout;
		}

		static IntPtr n_GetRefreshLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshLayout);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshLayout;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout RefreshLayout {
			get {
				if (id_getRefreshLayout == IntPtr.Zero)
					id_getRefreshLayout = JNIEnv.GetMethodID (class_ref, "getRefreshLayout", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshLayout), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSpinner;
#pragma warning disable 0169
		static Delegate GetGetSpinnerHandler ()
		{
			if (cb_getSpinner == null)
				cb_getSpinner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpinner);
			return cb_getSpinner;
		}

		static int n_GetSpinner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Spinner;
		}
#pragma warning restore 0169

		IntPtr id_getSpinner;
		public unsafe int Spinner {
			get {
				if (id_getSpinner == IntPtr.Zero)
					id_getSpinner = JNIEnv.GetMethodID (class_ref, "getSpinner", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSpinner);
			}
		}

		static Delegate cb_animSpinner_I;
#pragma warning disable 0169
		static Delegate GetAnimSpinner_IHandler ()
		{
			if (cb_animSpinner_I == null)
				cb_animSpinner_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnimSpinner_I);
			return cb_animSpinner_I;
		}

		static IntPtr n_AnimSpinner_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimSpinner (p0));
		}
#pragma warning restore 0169

		IntPtr id_animSpinner_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel AnimSpinner (int p0)
		{
			if (id_animSpinner_I == IntPtr.Zero)
				id_animSpinner_I = JNIEnv.GetMethodID (class_ref, "animSpinner", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_animSpinner_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_animSpinnerBounce_I;
#pragma warning disable 0169
		static Delegate GetAnimSpinnerBounce_IHandler ()
		{
			if (cb_animSpinnerBounce_I == null)
				cb_animSpinnerBounce_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnimSpinnerBounce_I);
			return cb_animSpinnerBounce_I;
		}

		static IntPtr n_AnimSpinnerBounce_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimSpinnerBounce (p0));
		}
#pragma warning restore 0169

		IntPtr id_animSpinnerBounce_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel AnimSpinnerBounce (int p0)
		{
			if (id_animSpinnerBounce_I == IntPtr.Zero)
				id_animSpinnerBounce_I = JNIEnv.GetMethodID (class_ref, "animSpinnerBounce", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_animSpinnerBounce_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_moveSpinner_IZ;
#pragma warning disable 0169
		static Delegate GetMoveSpinner_IZHandler ()
		{
			if (cb_moveSpinner_IZ == null)
				cb_moveSpinner_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_MoveSpinner_IZ);
			return cb_moveSpinner_IZ;
		}

		static IntPtr n_MoveSpinner_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoveSpinner (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_moveSpinner_IZ;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinner (int p0, bool p1)
		{
			if (id_moveSpinner_IZ == IntPtr.Zero)
				id_moveSpinner_IZ = JNIEnv.GetMethodID (class_ref, "moveSpinner", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_moveSpinner_IZ, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_moveSpinnerInfinitely_F;
#pragma warning disable 0169
		static Delegate GetMoveSpinnerInfinitely_FHandler ()
		{
			if (cb_moveSpinnerInfinitely_F == null)
				cb_moveSpinnerInfinitely_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_MoveSpinnerInfinitely_F);
			return cb_moveSpinnerInfinitely_F;
		}

		static IntPtr n_MoveSpinnerInfinitely_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoveSpinnerInfinitely (p0));
		}
#pragma warning restore 0169

		IntPtr id_moveSpinnerInfinitely_F;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel MoveSpinnerInfinitely (float p0)
		{
			if (id_moveSpinnerInfinitely_F == IntPtr.Zero)
				id_moveSpinnerInfinitely_F = JNIEnv.GetMethodID (class_ref, "moveSpinnerInfinitely", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_moveSpinnerInfinitely_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_overSpinner;
#pragma warning disable 0169
		static Delegate GetOverSpinnerHandler ()
		{
			if (cb_overSpinner == null)
				cb_overSpinner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OverSpinner);
			return cb_overSpinner;
		}

		static IntPtr n_OverSpinner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OverSpinner ());
		}
#pragma warning restore 0169

		IntPtr id_overSpinner;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel OverSpinner ()
		{
			if (id_overSpinner == IntPtr.Zero)
				id_overSpinner = JNIEnv.GetMethodID (class_ref, "overSpinner", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_overSpinner), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestDrawBackgoundForFooter_I;
#pragma warning disable 0169
		static Delegate GetRequestDrawBackgoundForFooter_IHandler ()
		{
			if (cb_requestDrawBackgoundForFooter_I == null)
				cb_requestDrawBackgoundForFooter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RequestDrawBackgoundForFooter_I);
			return cb_requestDrawBackgoundForFooter_I;
		}

		static IntPtr n_RequestDrawBackgoundForFooter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestDrawBackgoundForFooter (p0));
		}
#pragma warning restore 0169

		IntPtr id_requestDrawBackgoundForFooter_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgoundForFooter (int p0)
		{
			if (id_requestDrawBackgoundForFooter_I == IntPtr.Zero)
				id_requestDrawBackgoundForFooter_I = JNIEnv.GetMethodID (class_ref, "requestDrawBackgoundForFooter", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestDrawBackgoundForFooter_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_requestDrawBackgoundForHeader_I;
#pragma warning disable 0169
		static Delegate GetRequestDrawBackgoundForHeader_IHandler ()
		{
			if (cb_requestDrawBackgoundForHeader_I == null)
				cb_requestDrawBackgoundForHeader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RequestDrawBackgoundForHeader_I);
			return cb_requestDrawBackgoundForHeader_I;
		}

		static IntPtr n_RequestDrawBackgoundForHeader_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestDrawBackgoundForHeader (p0));
		}
#pragma warning restore 0169

		IntPtr id_requestDrawBackgoundForHeader_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel RequestDrawBackgoundForHeader (int p0)
		{
			if (id_requestDrawBackgoundForHeader_I == IntPtr.Zero)
				id_requestDrawBackgoundForHeader_I = JNIEnv.GetMethodID (class_ref, "requestDrawBackgoundForHeader", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestDrawBackgoundForHeader_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_resetStatus;
#pragma warning disable 0169
		static Delegate GetResetStatusHandler ()
		{
			if (cb_resetStatus == null)
				cb_resetStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ResetStatus);
			return cb_resetStatus;
		}

		static IntPtr n_ResetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResetStatus ());
		}
#pragma warning restore 0169

		IntPtr id_resetStatus;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel ResetStatus ()
		{
			if (id_resetStatus == IntPtr.Zero)
				id_resetStatus = JNIEnv.GetMethodID (class_ref, "resetStatus", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resetStatus), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStateLoding;
#pragma warning disable 0169
		static Delegate GetSetStateLodingHandler ()
		{
			if (cb_setStateLoding == null)
				cb_setStateLoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateLoding);
			return cb_setStateLoding;
		}

		static IntPtr n_SetStateLoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStateLoding ());
		}
#pragma warning restore 0169

		IntPtr id_setStateLoding;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateLoding ()
		{
			if (id_setStateLoding == IntPtr.Zero)
				id_setStateLoding = JNIEnv.GetMethodID (class_ref, "setStateLoding", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStateLoding), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStateLodingFinish;
#pragma warning disable 0169
		static Delegate GetSetStateLodingFinishHandler ()
		{
			if (cb_setStateLodingFinish == null)
				cb_setStateLodingFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateLodingFinish);
			return cb_setStateLodingFinish;
		}

		static IntPtr n_SetStateLodingFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStateLodingFinish ());
		}
#pragma warning restore 0169

		IntPtr id_setStateLodingFinish;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateLodingFinish ()
		{
			if (id_setStateLodingFinish == IntPtr.Zero)
				id_setStateLodingFinish = JNIEnv.GetMethodID (class_ref, "setStateLodingFinish", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStateLodingFinish), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStatePullDownCanceled;
#pragma warning disable 0169
		static Delegate GetSetStatePullDownCanceledHandler ()
		{
			if (cb_setStatePullDownCanceled == null)
				cb_setStatePullDownCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullDownCanceled);
			return cb_setStatePullDownCanceled;
		}

		static IntPtr n_SetStatePullDownCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStatePullDownCanceled ());
		}
#pragma warning restore 0169

		IntPtr id_setStatePullDownCanceled;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullDownCanceled ()
		{
			if (id_setStatePullDownCanceled == IntPtr.Zero)
				id_setStatePullDownCanceled = JNIEnv.GetMethodID (class_ref, "setStatePullDownCanceled", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStatePullDownCanceled), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStatePullDownToRefresh;
#pragma warning disable 0169
		static Delegate GetSetStatePullDownToRefreshHandler ()
		{
			if (cb_setStatePullDownToRefresh == null)
				cb_setStatePullDownToRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullDownToRefresh);
			return cb_setStatePullDownToRefresh;
		}

		static IntPtr n_SetStatePullDownToRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStatePullDownToRefresh ());
		}
#pragma warning restore 0169

		IntPtr id_setStatePullDownToRefresh;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullDownToRefresh ()
		{
			if (id_setStatePullDownToRefresh == IntPtr.Zero)
				id_setStatePullDownToRefresh = JNIEnv.GetMethodID (class_ref, "setStatePullDownToRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStatePullDownToRefresh), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStatePullUpCanceled;
#pragma warning disable 0169
		static Delegate GetSetStatePullUpCanceledHandler ()
		{
			if (cb_setStatePullUpCanceled == null)
				cb_setStatePullUpCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullUpCanceled);
			return cb_setStatePullUpCanceled;
		}

		static IntPtr n_SetStatePullUpCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStatePullUpCanceled ());
		}
#pragma warning restore 0169

		IntPtr id_setStatePullUpCanceled;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullUpCanceled ()
		{
			if (id_setStatePullUpCanceled == IntPtr.Zero)
				id_setStatePullUpCanceled = JNIEnv.GetMethodID (class_ref, "setStatePullUpCanceled", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStatePullUpCanceled), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStatePullUpToLoad;
#pragma warning disable 0169
		static Delegate GetSetStatePullUpToLoadHandler ()
		{
			if (cb_setStatePullUpToLoad == null)
				cb_setStatePullUpToLoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStatePullUpToLoad);
			return cb_setStatePullUpToLoad;
		}

		static IntPtr n_SetStatePullUpToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStatePullUpToLoad ());
		}
#pragma warning restore 0169

		IntPtr id_setStatePullUpToLoad;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStatePullUpToLoad ()
		{
			if (id_setStatePullUpToLoad == IntPtr.Zero)
				id_setStatePullUpToLoad = JNIEnv.GetMethodID (class_ref, "setStatePullUpToLoad", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStatePullUpToLoad), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStateRefresing;
#pragma warning disable 0169
		static Delegate GetSetStateRefresingHandler ()
		{
			if (cb_setStateRefresing == null)
				cb_setStateRefresing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateRefresing);
			return cb_setStateRefresing;
		}

		static IntPtr n_SetStateRefresing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStateRefresing ());
		}
#pragma warning restore 0169

		IntPtr id_setStateRefresing;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateRefresing ()
		{
			if (id_setStateRefresing == IntPtr.Zero)
				id_setStateRefresing = JNIEnv.GetMethodID (class_ref, "setStateRefresing", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStateRefresing), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStateRefresingFinish;
#pragma warning disable 0169
		static Delegate GetSetStateRefresingFinishHandler ()
		{
			if (cb_setStateRefresingFinish == null)
				cb_setStateRefresingFinish = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateRefresingFinish);
			return cb_setStateRefresingFinish;
		}

		static IntPtr n_SetStateRefresingFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStateRefresingFinish ());
		}
#pragma warning restore 0169

		IntPtr id_setStateRefresingFinish;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateRefresingFinish ()
		{
			if (id_setStateRefresingFinish == IntPtr.Zero)
				id_setStateRefresingFinish = JNIEnv.GetMethodID (class_ref, "setStateRefresingFinish", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStateRefresingFinish), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStateReleaseToLoad;
#pragma warning disable 0169
		static Delegate GetSetStateReleaseToLoadHandler ()
		{
			if (cb_setStateReleaseToLoad == null)
				cb_setStateReleaseToLoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateReleaseToLoad);
			return cb_setStateReleaseToLoad;
		}

		static IntPtr n_SetStateReleaseToLoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStateReleaseToLoad ());
		}
#pragma warning restore 0169

		IntPtr id_setStateReleaseToLoad;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateReleaseToLoad ()
		{
			if (id_setStateReleaseToLoad == IntPtr.Zero)
				id_setStateReleaseToLoad = JNIEnv.GetMethodID (class_ref, "setStateReleaseToLoad", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStateReleaseToLoad), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setStateReleaseToRefresh;
#pragma warning disable 0169
		static Delegate GetSetStateReleaseToRefreshHandler ()
		{
			if (cb_setStateReleaseToRefresh == null)
				cb_setStateReleaseToRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetStateReleaseToRefresh);
			return cb_setStateReleaseToRefresh;
		}

		static IntPtr n_SetStateReleaseToRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStateReleaseToRefresh ());
		}
#pragma warning restore 0169

		IntPtr id_setStateReleaseToRefresh;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel SetStateReleaseToRefresh ()
		{
			if (id_setStateReleaseToRefresh == IntPtr.Zero)
				id_setStateReleaseToRefresh = JNIEnv.GetMethodID (class_ref, "setStateReleaseToRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshKernel;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStateReleaseToRefresh), JniHandleOwnership.TransferLocalRef);
		}

	}

}
