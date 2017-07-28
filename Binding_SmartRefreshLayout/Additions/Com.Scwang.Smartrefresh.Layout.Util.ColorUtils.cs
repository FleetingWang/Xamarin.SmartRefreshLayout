using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/util/ColorUtils", DoNotGenerateAcw=true)]
	public sealed partial class ColorUtils : global::Java.Lang.Object {

		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/util/ColorUtils", typeof (ColorUtils));
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

		internal ColorUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='HSLToColor' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("HSLToColor", "([F)I", "")]
		public static unsafe int HSLToColor (float[] hsl)
		{
			const string __id = "HSLToColor.([F)I";
			IntPtr native_hsl = JNIEnv.NewArray (hsl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hsl);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (hsl != null) {
					JNIEnv.CopyArray (native_hsl, hsl);
					JNIEnv.DeleteLocalRef (native_hsl);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='LABToColor' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("LABToColor", "(DDD)I", "")]
		public static unsafe int LABToColor (double l, double a, double b)
		{
			const string __id = "LABToColor.(DDD)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (l);
				__args [1] = new JniArgumentValue (a);
				__args [2] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='LABToXYZ' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double[]']]"
		[Register ("LABToXYZ", "(DDD[D)V", "")]
		public static unsafe void LABToXYZ (double l, double a, double b, double[] outXyz)
		{
			const string __id = "LABToXYZ.(DDD[D)V";
			IntPtr native_outXyz = JNIEnv.NewArray (outXyz);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (l);
				__args [1] = new JniArgumentValue (a);
				__args [2] = new JniArgumentValue (b);
				__args [3] = new JniArgumentValue (native_outXyz);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outXyz != null) {
					JNIEnv.CopyArray (native_outXyz, outXyz);
					JNIEnv.DeleteLocalRef (native_outXyz);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='RGBToHSL' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float[]']]"
		[Register ("RGBToHSL", "(III[F)V", "")]
		public static unsafe void RGBToHSL (int r, int g, int b, float[] outHsl)
		{
			const string __id = "RGBToHSL.(III[F)V";
			IntPtr native_outHsl = JNIEnv.NewArray (outHsl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (r);
				__args [1] = new JniArgumentValue (g);
				__args [2] = new JniArgumentValue (b);
				__args [3] = new JniArgumentValue (native_outHsl);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outHsl != null) {
					JNIEnv.CopyArray (native_outHsl, outHsl);
					JNIEnv.DeleteLocalRef (native_outHsl);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='RGBToLAB' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='double[]']]"
		[Register ("RGBToLAB", "(III[D)V", "")]
		public static unsafe void RGBToLAB (int r, int g, int b, double[] outLab)
		{
			const string __id = "RGBToLAB.(III[D)V";
			IntPtr native_outLab = JNIEnv.NewArray (outLab);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (r);
				__args [1] = new JniArgumentValue (g);
				__args [2] = new JniArgumentValue (b);
				__args [3] = new JniArgumentValue (native_outLab);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outLab != null) {
					JNIEnv.CopyArray (native_outLab, outLab);
					JNIEnv.DeleteLocalRef (native_outLab);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='RGBToXYZ' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='double[]']]"
		[Register ("RGBToXYZ", "(III[D)V", "")]
		public static unsafe void RGBToXYZ (int r, int g, int b, double[] outXyz)
		{
			const string __id = "RGBToXYZ.(III[D)V";
			IntPtr native_outXyz = JNIEnv.NewArray (outXyz);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (r);
				__args [1] = new JniArgumentValue (g);
				__args [2] = new JniArgumentValue (b);
				__args [3] = new JniArgumentValue (native_outXyz);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outXyz != null) {
					JNIEnv.CopyArray (native_outXyz, outXyz);
					JNIEnv.DeleteLocalRef (native_outXyz);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='XYZToColor' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("XYZToColor", "(DDD)I", "")]
		public static unsafe int XYZToColor (double x, double y, double z)
		{
			const string __id = "XYZToColor.(DDD)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (z);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='XYZToLAB' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double[]']]"
		[Register ("XYZToLAB", "(DDD[D)V", "")]
		public static unsafe void XYZToLAB (double x, double y, double z, double[] outLab)
		{
			const string __id = "XYZToLAB.(DDD[D)V";
			IntPtr native_outLab = JNIEnv.NewArray (outLab);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (z);
				__args [3] = new JniArgumentValue (native_outLab);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outLab != null) {
					JNIEnv.CopyArray (native_outLab, outLab);
					JNIEnv.DeleteLocalRef (native_outLab);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='blendARGB' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("blendARGB", "(IIF)I", "")]
		public static unsafe int BlendARGB (int color1, int color2, float ratio)
		{
			const string __id = "blendARGB.(IIF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (color1);
				__args [1] = new JniArgumentValue (color2);
				__args [2] = new JniArgumentValue (ratio);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='blendHSL' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='float'] and parameter[4][@type='float[]']]"
		[Register ("blendHSL", "([F[FF[F)V", "")]
		public static unsafe void BlendHSL (float[] hsl1, float[] hsl2, float ratio, float[] outResult)
		{
			const string __id = "blendHSL.([F[FF[F)V";
			IntPtr native_hsl1 = JNIEnv.NewArray (hsl1);
			IntPtr native_hsl2 = JNIEnv.NewArray (hsl2);
			IntPtr native_outResult = JNIEnv.NewArray (outResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_hsl1);
				__args [1] = new JniArgumentValue (native_hsl2);
				__args [2] = new JniArgumentValue (ratio);
				__args [3] = new JniArgumentValue (native_outResult);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (hsl1 != null) {
					JNIEnv.CopyArray (native_hsl1, hsl1);
					JNIEnv.DeleteLocalRef (native_hsl1);
				}
				if (hsl2 != null) {
					JNIEnv.CopyArray (native_hsl2, hsl2);
					JNIEnv.DeleteLocalRef (native_hsl2);
				}
				if (outResult != null) {
					JNIEnv.CopyArray (native_outResult, outResult);
					JNIEnv.DeleteLocalRef (native_outResult);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='blendLAB' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='double'] and parameter[4][@type='double[]']]"
		[Register ("blendLAB", "([D[DD[D)V", "")]
		public static unsafe void BlendLAB (double[] lab1, double[] lab2, double ratio, double[] outResult)
		{
			const string __id = "blendLAB.([D[DD[D)V";
			IntPtr native_lab1 = JNIEnv.NewArray (lab1);
			IntPtr native_lab2 = JNIEnv.NewArray (lab2);
			IntPtr native_outResult = JNIEnv.NewArray (outResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_lab1);
				__args [1] = new JniArgumentValue (native_lab2);
				__args [2] = new JniArgumentValue (ratio);
				__args [3] = new JniArgumentValue (native_outResult);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (lab1 != null) {
					JNIEnv.CopyArray (native_lab1, lab1);
					JNIEnv.DeleteLocalRef (native_lab1);
				}
				if (lab2 != null) {
					JNIEnv.CopyArray (native_lab2, lab2);
					JNIEnv.DeleteLocalRef (native_lab2);
				}
				if (outResult != null) {
					JNIEnv.CopyArray (native_outResult, outResult);
					JNIEnv.DeleteLocalRef (native_outResult);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='calculateContrast' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("calculateContrast", "(II)D", "")]
		public static unsafe double CalculateContrast (int foreground, int background)
		{
			const string __id = "calculateContrast.(II)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (foreground);
				__args [1] = new JniArgumentValue (background);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='calculateLuminance' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("calculateLuminance", "(I)D", "")]
		public static unsafe double CalculateLuminance (int color)
		{
			const string __id = "calculateLuminance.(I)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='calculateMinimumAlpha' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
		[Register ("calculateMinimumAlpha", "(IIF)I", "")]
		public static unsafe int CalculateMinimumAlpha (int foreground, int background, float minContrastRatio)
		{
			const string __id = "calculateMinimumAlpha.(IIF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (foreground);
				__args [1] = new JniArgumentValue (background);
				__args [2] = new JniArgumentValue (minContrastRatio);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='colorToHSL' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("colorToHSL", "(I[F)V", "")]
		public static unsafe void ColorToHSL (int color, float[] outHsl)
		{
			const string __id = "colorToHSL.(I[F)V";
			IntPtr native_outHsl = JNIEnv.NewArray (outHsl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (native_outHsl);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outHsl != null) {
					JNIEnv.CopyArray (native_outHsl, outHsl);
					JNIEnv.DeleteLocalRef (native_outHsl);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='colorToLAB' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("colorToLAB", "(I[D)V", "")]
		public static unsafe void ColorToLAB (int color, double[] outLab)
		{
			const string __id = "colorToLAB.(I[D)V";
			IntPtr native_outLab = JNIEnv.NewArray (outLab);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (native_outLab);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outLab != null) {
					JNIEnv.CopyArray (native_outLab, outLab);
					JNIEnv.DeleteLocalRef (native_outLab);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='colorToXYZ' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("colorToXYZ", "(I[D)V", "")]
		public static unsafe void ColorToXYZ (int color, double[] outXyz)
		{
			const string __id = "colorToXYZ.(I[D)V";
			IntPtr native_outXyz = JNIEnv.NewArray (outXyz);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (native_outXyz);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (outXyz != null) {
					JNIEnv.CopyArray (native_outXyz, outXyz);
					JNIEnv.DeleteLocalRef (native_outXyz);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='compositeColors' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compositeColors", "(II)I", "")]
		public static unsafe int CompositeColors (int foreground, int background)
		{
			const string __id = "compositeColors.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (foreground);
				__args [1] = new JniArgumentValue (background);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='distanceEuclidean' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("distanceEuclidean", "([D[D)D", "")]
		public static unsafe double DistanceEuclidean (double[] labX, double[] labY)
		{
			const string __id = "distanceEuclidean.([D[D)D";
			IntPtr native_labX = JNIEnv.NewArray (labX);
			IntPtr native_labY = JNIEnv.NewArray (labY);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_labX);
				__args [1] = new JniArgumentValue (native_labY);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
				if (labX != null) {
					JNIEnv.CopyArray (native_labX, labX);
					JNIEnv.DeleteLocalRef (native_labX);
				}
				if (labY != null) {
					JNIEnv.CopyArray (native_labY, labY);
					JNIEnv.DeleteLocalRef (native_labY);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.util']/class[@name='ColorUtils']/method[@name='setAlphaComponent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setAlphaComponent", "(II)I", "")]
		public static unsafe int SetAlphaComponent (int color, int alpha)
		{
			const string __id = "setAlphaComponent.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (alpha);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
