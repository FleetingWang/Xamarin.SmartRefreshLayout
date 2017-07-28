using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Constant {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/constant/SpinnerStyle", DoNotGenerateAcw=true)]
	public sealed partial class SpinnerStyle : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']/field[@name='FixedBehind']"
		[Register ("FixedBehind")]
		public static global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle FixedBehind {
			get {
				const string __id = "FixedBehind.Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']/field[@name='FixedFront']"
		[Register ("FixedFront")]
		public static global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle FixedFront {
			get {
				const string __id = "FixedFront.Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']/field[@name='Scale']"
		[Register ("Scale")]
		public static global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle Scale {
			get {
				const string __id = "Scale.Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']/field[@name='Translate']"
		[Register ("Translate")]
		public static global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle Translate {
			get {
				const string __id = "Translate.Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/constant/SpinnerStyle", typeof (SpinnerStyle));
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

		internal SpinnerStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;", "")]
		public static unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.constant']/class[@name='SpinnerStyle']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;", "")]
		public static unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle[] Values ()
		{
			const string __id = "values.()[Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle));
			} finally {
			}
		}

	}
}
