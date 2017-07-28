using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Internal.Pathview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/internal/pathview/PathsDrawable", DoNotGenerateAcw=true)]
	public partial class PathsDrawable : global::Android.Graphics.Drawables.Drawable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='MAX_CLIP']"
		[Register ("MAX_CLIP")]
		protected static global::Android.Graphics.Region MaxClip {
			get {
				const string __id = "MAX_CLIP.Landroid/graphics/Region;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Region> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='REGION']"
		[Register ("REGION")]
		protected static global::Android.Graphics.Region Region {
			get {
				const string __id = "REGION.Landroid/graphics/Region;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Region> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mColors']"
		[Register ("mColors")]
		protected global::System.Collections.IList MColors {
			get {
				const string __id = "mColors.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mColors.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mHeight']"
		[Register ("mHeight")]
		protected int MHeight {
			get {
				const string __id = "mHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mOrginHeight']"
		[Register ("mOrginHeight")]
		protected int MOrginHeight {
			get {
				const string __id = "mOrginHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mOrginHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mOrginPaths']"
		[Register ("mOrginPaths")]
		protected global::System.Collections.IList MOrginPaths {
			get {
				const string __id = "mOrginPaths.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mOrginPaths.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mOrginSvgs']"
		[Register ("mOrginSvgs")]
		protected global::System.Collections.IList MOrginSvgs {
			get {
				const string __id = "mOrginSvgs.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mOrginSvgs.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mOrginWidth']"
		[Register ("mOrginWidth")]
		protected int MOrginWidth {
			get {
				const string __id = "mOrginWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mOrginWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mPaint']"
		[Register ("mPaint")]
		protected global::Android.Graphics.Paint MPaint {
			get {
				const string __id = "mPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mPaths']"
		[Register ("mPaths")]
		protected global::System.Collections.IList MPaths {
			get {
				const string __id = "mPaths.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPaths.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mStartX']"
		[Register ("mStartX")]
		protected int MStartX {
			get {
				const string __id = "mStartX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mStartX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mStartY']"
		[Register ("mStartY")]
		protected int MStartY {
			get {
				const string __id = "mStartY.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mStartY.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/field[@name='mWidth']"
		[Register ("mWidth")]
		protected int MWidth {
			get {
				const string __id = "mWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/internal/pathview/PathsDrawable", typeof (PathsDrawable));
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

		protected PathsDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/constructor[@name='PathsDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PathsDrawable ()
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='getOpacity' and count(parameter)=0]"
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

		static Delegate cb_getPaint;
#pragma warning disable 0169
		static Delegate GetGetPaintHandler ()
		{
			if (cb_getPaint == null)
				cb_getPaint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaint);
			return cb_getPaint;
		}

		static IntPtr n_GetPaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='getPaint' and count(parameter)=0]"
			[Register ("getPaint", "()Landroid/graphics/Paint;", "GetGetPaintHandler")]
			get {
				const string __id = "getPaint.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canReuseBitmap_II;
#pragma warning disable 0169
		static Delegate GetCanReuseBitmap_IIHandler ()
		{
			if (cb_canReuseBitmap_II == null)
				cb_canReuseBitmap_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_CanReuseBitmap_II);
			return cb_canReuseBitmap_II;
		}

		static bool n_CanReuseBitmap_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanReuseBitmap (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='canReuseBitmap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("canReuseBitmap", "(II)Z", "GetCanReuseBitmap_IIHandler")]
		public virtual unsafe bool CanReuseBitmap (int width, int height)
		{
			const string __id = "canReuseBitmap.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canReuseCache;
#pragma warning disable 0169
		static Delegate GetCanReuseCacheHandler ()
		{
			if (cb_canReuseCache == null)
				cb_canReuseCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanReuseCache);
			return cb_canReuseCache;
		}

		static bool n_CanReuseCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanReuseCache ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='canReuseCache' and count(parameter)=0]"
		[Register ("canReuseCache", "()Z", "GetCanReuseCacheHandler")]
		public virtual unsafe bool CanReuseCache ()
		{
			const string __id = "canReuseCache.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_createCachedBitmapIfNeeded_II;
#pragma warning disable 0169
		static Delegate GetCreateCachedBitmapIfNeeded_IIHandler ()
		{
			if (cb_createCachedBitmapIfNeeded_II == null)
				cb_createCachedBitmapIfNeeded_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_CreateCachedBitmapIfNeeded_II);
			return cb_createCachedBitmapIfNeeded_II;
		}

		static void n_CreateCachedBitmapIfNeeded_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateCachedBitmapIfNeeded (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='createCachedBitmapIfNeeded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createCachedBitmapIfNeeded", "(II)V", "GetCreateCachedBitmapIfNeeded_IIHandler")]
		public virtual unsafe void CreateCachedBitmapIfNeeded (int width, int height)
		{
			const string __id = "createCachedBitmapIfNeeded.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='height' and count(parameter)=0]"
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

		static Delegate cb_onMeasure;
#pragma warning disable 0169
		static Delegate GetOnMeasureHandler ()
		{
			if (cb_onMeasure == null)
				cb_onMeasure = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMeasure);
			return cb_onMeasure;
		}

		static void n_OnMeasure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMeasure ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='onMeasure' and count(parameter)=0]"
		[Register ("onMeasure", "()V", "GetOnMeasureHandler")]
		protected virtual unsafe void OnMeasure ()
		{
			const string __id = "onMeasure.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ParserColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='parserColors' and count(parameter)=1 and parameter[1][@type='int...']]"
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] paths = (string[]) JNIEnv.GetArray (native_paths, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.ParserPaths (paths);
			if (paths != null)
				JNIEnv.CopyArray (paths, native_paths);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='parserPaths' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter cf = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_cf, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (cf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
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

		static Delegate cb_setGeometricHeight_I;
#pragma warning disable 0169
		static Delegate GetSetGeometricHeight_IHandler ()
		{
			if (cb_setGeometricHeight_I == null)
				cb_setGeometricHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGeometricHeight_I);
			return cb_setGeometricHeight_I;
		}

		static void n_SetGeometricHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGeometricHeight (height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='setGeometricHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGeometricHeight", "(I)V", "GetSetGeometricHeight_IHandler")]
		public virtual unsafe void SetGeometricHeight (int height)
		{
			const string __id = "setGeometricHeight.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setGeometricWidth_I;
#pragma warning disable 0169
		static Delegate GetSetGeometricWidth_IHandler ()
		{
			if (cb_setGeometricWidth_I == null)
				cb_setGeometricWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGeometricWidth_I);
			return cb_setGeometricWidth_I;
		}

		static void n_SetGeometricWidth_I (IntPtr jnienv, IntPtr native__this, int width)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGeometricWidth (width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='setGeometricWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGeometricWidth", "(I)V", "GetSetGeometricWidth_IHandler")]
		public virtual unsafe void SetGeometricWidth (int width)
		{
			const string __id = "setGeometricWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (width);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateCacheStates;
#pragma warning disable 0169
		static Delegate GetUpdateCacheStatesHandler ()
		{
			if (cb_updateCacheStates == null)
				cb_updateCacheStates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateCacheStates);
			return cb_updateCacheStates;
		}

		static void n_UpdateCacheStates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCacheStates ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='updateCacheStates' and count(parameter)=0]"
		[Register ("updateCacheStates", "()V", "GetUpdateCacheStatesHandler")]
		public virtual unsafe void UpdateCacheStates ()
		{
			const string __id = "updateCacheStates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateCachedBitmap_II;
#pragma warning disable 0169
		static Delegate GetUpdateCachedBitmap_IIHandler ()
		{
			if (cb_updateCachedBitmap_II == null)
				cb_updateCachedBitmap_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_UpdateCachedBitmap_II);
			return cb_updateCachedBitmap_II;
		}

		static void n_UpdateCachedBitmap_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCachedBitmap (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='updateCachedBitmap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("updateCachedBitmap", "(II)V", "GetUpdateCachedBitmap_IIHandler")]
		public virtual unsafe void UpdateCachedBitmap (int width, int height)
		{
			const string __id = "updateCachedBitmap.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Internal.Pathview.PathsDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.internal.pathview']/class[@name='PathsDrawable']/method[@name='width' and count(parameter)=0]"
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
