using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Internal.Pathview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/internal/pathview/PathsView", DoNotGenerateAcw=true)]
	public partial class PathsView : global::Android.Views.View {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']/field[@name='mPathsDrawable']"
		[Register ("mPathsDrawable")]
		protected global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable MPathsDrawable {
			get {
				const string __id = "mPathsDrawable.Lcom/scwang/smartrefresh/layout/internal/pathview/PathsDrawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPathsDrawable.Lcom/scwang/smartrefresh/layout/internal/pathview/PathsDrawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/internal/pathview/PathsView", typeof (PathsView));
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

		protected PathsView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']/constructor[@name='PathsView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PathsView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']/constructor[@name='PathsView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PathsView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']/constructor[@name='PathsView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PathsView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_parserColors_arrayI;
#pragma warning disable 0169
		static Delegate GetParserColors_arrayIHandler ()
		{
			if (cb_parserColors_arrayI == null)
				cb_parserColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParserColors_arrayI);
			return cb_parserColors_arrayI;
		}

		static void n_ParserColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ParserColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']/method[@name='parserColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("parserColors", "([I)V", "GetParserColors_arrayIHandler")]
		public virtual unsafe void ParserColors (params  int[] colors)
		{
			const string __id = "parserColors.([I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_parserPaths_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParserPaths_arrayLjava_lang_String_Handler ()
		{
			if (cb_parserPaths_arrayLjava_lang_String_ == null)
				cb_parserPaths_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParserPaths_arrayLjava_lang_String_);
			return cb_parserPaths_arrayLjava_lang_String_;
		}

		static void n_ParserPaths_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paths)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsView __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] paths = (string[]) JNIEnv.GetArray (native_paths, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.ParserPaths (paths);
			if (paths != null)
				JNIEnv.CopyArray (paths, native_paths);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsView']/method[@name='parserPaths' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("parserPaths", "([Ljava/lang/String;)V", "GetParserPaths_arrayLjava_lang_String_Handler")]
		public virtual unsafe void ParserPaths (params  string[] paths)
		{
			const string __id = "parserPaths.([Ljava/lang/String;)V";
			IntPtr native_paths = JNIEnv.NewArray (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (paths != null) {
					JNIEnv.CopyArray (native_paths, paths);
					JNIEnv.DeleteLocalRef (native_paths);
				}
			}
		}

	}
}
