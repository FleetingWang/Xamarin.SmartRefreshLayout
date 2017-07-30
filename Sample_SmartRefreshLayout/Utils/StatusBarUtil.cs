using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Annotation;
using Java.Lang;
using Java.Lang.Reflect;
using Android.Util;
using System.Text.RegularExpressions;
using Android.Content.Res;

namespace Sample_SmartRefreshLayout.Utils
{
    public class StatusBarUtil
    {
        
    public static int DEFAULT_COLOR = 0;
    public static float DEFAULT_ALPHA = 0;//Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP ? 0.2f : 0.3f;

    //<editor-fold desc="沉侵">
    public static void immersive(Activity activity) {
        immersive(activity, DEFAULT_COLOR, DEFAULT_ALPHA);
    }

    public static void immersive(Activity activity, int color, float alpha) {
        immersive(activity.Window, color, alpha);
    }

    public static void immersive(Activity activity, int color) {
        immersive(activity.Window, color, 1f);
    }

    public static void immersive(Window window) {
        immersive(window, DEFAULT_COLOR, DEFAULT_ALPHA);
    }

    public static void immersive(Window window, int color) {
        immersive(window, color, 1f);
    }

    public static void immersive(Window window, int color, float alpha) {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) { // 21
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            window.SetStatusBarColor(new Android.Graphics.Color(mixtureColor(color, alpha)));

            SystemUiFlags systemUiVisibility = (SystemUiFlags)window.DecorView.SystemUiVisibility;
            systemUiVisibility |= SystemUiFlags.LayoutFullscreen;
            systemUiVisibility |= SystemUiFlags.LayoutStable;
            window.DecorView.SystemUiVisibility = (StatusBarVisibility)systemUiVisibility;
        } else if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat) { // 19
            window.AddFlags(WindowManagerFlags.TranslucentStatus);
            setTranslucentView((ViewGroup)window.DecorView, color, alpha);
        } else if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean) { // 16
            SystemUiFlags systemUiVisibility = (SystemUiFlags)window.DecorView.SystemUiVisibility;
            systemUiVisibility |= SystemUiFlags.LayoutFullscreen;
            systemUiVisibility |= SystemUiFlags.LayoutStable;
            window.DecorView.SystemUiVisibility = (StatusBarVisibility)systemUiVisibility;
            }
        }
    //</editor-fold>

    //<editor-fold desc="DarkMode">
    public static void darkMode(Activity activity, bool dark) {
        if (isFlyme4Later()) {
            darkModeForFlyme4(activity.Window, dark);
        } else if (isMIUI6Later()) {
            darkModeForMIUI6(activity.Window, dark);
        } else if (Build.VERSION.SdkInt >= BuildVersionCodes.M) {
            darkModeForM(activity.Window, dark);
        }
    }

    /** 设置状态栏darkMode,字体颜色及icon变黑(目前支持MIUI6以上,Flyme4以上,Android M以上) */
    public static void darkMode(Activity activity) {
        darkMode(activity.Window, DEFAULT_COLOR, DEFAULT_ALPHA);
    }

    public static void darkMode(Activity activity, int color, float alpha) {
        darkMode(activity.Window, color, alpha);
    }

    /** 设置状态栏darkMode,字体颜色及icon变黑(目前支持MIUI6以上,Flyme4以上,Android M以上) */
    public static void darkMode(Window window, int color, float alpha) {
        if (isFlyme4Later()) {
            darkModeForFlyme4(window, true);
            immersive(window,color,alpha);
        } else if (isMIUI6Later()) {
            darkModeForMIUI6(window, true);
            immersive(window,color,alpha);
        } else if (Build.VERSION.SdkInt >= BuildVersionCodes.M) {
            darkModeForM(window, true);
            immersive(window, color, alpha);
        } else if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat) { //19
            window.AddFlags(WindowManagerFlags.TranslucentStatus);
            setTranslucentView((ViewGroup) window.DecorView, color, alpha);
        }
//        if (Build.VERSION.SDK_INT >= 21) {
//            window.clearFlags(WindowManager.LayoutParams.FLAG_TRANSLUCENT_STATUS);
//            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
//            window.setStatusBarColor(Color.TRANSPARENT);
//        } else if (Build.VERSION.SDK_INT >= 19) {
//            window.addFlags(WindowManager.LayoutParams.FLAG_TRANSLUCENT_STATUS);
//        }

//        setTranslucentView((ViewGroup) window.getDecorView(), color, alpha);
    }

    //------------------------->

    /** android 6.0设置字体颜色 */
    [RequiresApi(Api = (int)BuildVersionCodes.M)]
    private static void darkModeForM(Window window, bool dark) {
            //        window.clearFlags(WindowManager.LayoutParams.FLAG_TRANSLUCENT_STATUS);
            //        window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            //        window.setStatusBarColor(Color.TRANSPARENT);

            SystemUiFlags systemUiVisibility = (SystemUiFlags)window.DecorView.SystemUiVisibility;
            if (dark) {
                systemUiVisibility |= SystemUiFlags.LightStatusBar;
        } else {
                systemUiVisibility &= ~SystemUiFlags.LightStatusBar;
        }
        window.DecorView.SystemUiVisibility = (StatusBarVisibility)systemUiVisibility;
    }

    /**
     * 设置Flyme4+的darkMode,darkMode时候字体颜色及icon变黑
     * http://open-wiki.flyme.cn/index.php?title=Flyme%E7%B3%BB%E7%BB%9FAPI
     */
    public static bool darkModeForFlyme4(Window window, bool dark) {
            bool result = false;
        if (window != null) {
            try {
                WindowManagerLayoutParams e = window.Attributes;
                Field darkFlag = e.Class.GetDeclaredField("MEIZU_FLAG_DARK_STATUS_BAR_ICON");
                Field meizuFlags = e.Class.GetDeclaredField("meizuFlags");
                darkFlag.Accessible = true;
                meizuFlags.Accessible = true;
                int bit = darkFlag.GetInt(null);
                int value = meizuFlags.GetInt(e);
                if (dark) {
                    value |= bit;
                } else {
                    value &= ~bit;
                }

                meizuFlags.SetInt(e, value);
                window.Attributes = e;
                result = true;
            } catch (Java.Lang.Exception var8) {
                Log.Error("StatusBar", "darkIcon: failed");
            }
        }

        return result;
    }

    /**
     * 设置MIUI6+的状态栏是否为darkMode,darkMode时候字体颜色及icon变黑
     * http://dev.xiaomi.com/doc/p=4769/
     */
    public static bool darkModeForMIUI6(Window window, bool darkmode) {
        Class clazz = window.Class;
        try {
            int darkModeFlag = 0;
            Class layoutParams = Class.ForName("android.view.MiuiWindowManager$LayoutParams");
            Field field = layoutParams.GetField("EXTRA_FLAG_STATUS_BAR_DARK_MODE");
            darkModeFlag = field.GetInt(layoutParams);
            Method extraFlagField = clazz.GetMethod("setExtraFlags", Class.FromType(typeof(Java.Lang.Integer)), Class.FromType(typeof(Java.Lang.Integer)));
            extraFlagField.Invoke(window, darkmode ? darkModeFlag : 0, darkModeFlag);
            return true;
        } catch (Java.Lang.Exception e) {
            e.PrintStackTrace();
            return false;
        }
    }

    /** 判断是否Flyme4以上 */
    public static bool isFlyme4Later() {
        return Build.Fingerprint.Contains("Flyme_OS_4")
                || Build.VERSION.Incremental.Contains("Flyme_OS_4")
                || Regex.IsMatch(Build.Display, "Flyme OS [4|5]", RegexOptions.IgnoreCase);
    }

    /** 判断是否为MIUI6以上 */
    public static bool isMIUI6Later() {
        try {
            Class clz = Class.ForName("android.os.SystemProperties");
            Method mtd = clz.GetMethod("get", Class.FromType(typeof(Java.Lang.String)));
                string val = (string) mtd.Invoke(null, "ro.miui.ui.version.name");
            val = val.Replace("[vV]", "");
            int version = Integer.ParseInt(val);
            return version >= 6;
        } catch (Java.Lang.Exception e) {
            return false;
        }
    }
    //</editor-fold>


    /** 增加View的paddingTop,增加的值为状态栏高度 */
    public static void setPadding(Context context, View view) {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean) { // 16
            view.SetPadding(view.PaddingLeft, view.PaddingTop + getStatusBarHeight(context),
                    view.PaddingRight, view.PaddingBottom);
        }
    }
    /** 增加View的paddingTop,增加的值为状态栏高度 (智能判断，并设置高度)*/
    public static void setPaddingSmart(Context context, View view) {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean) { // 16
            ViewGroup.LayoutParams lp = view.LayoutParameters;
            if (lp != null && lp.Height > 0) {
                lp.Height += getStatusBarHeight(context);//增高
            }
            view.SetPadding(view.PaddingLeft, view.PaddingTop + getStatusBarHeight(context),
                    view.PaddingRight, view.PaddingBottom);
        }
    }

    /** 增加View的高度以及paddingTop,增加的值为状态栏高度.一般是在沉浸式全屏给ToolBar用的 */
    public static void setHeightAndPadding(Context context, View view) {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean) { // 16
            ViewGroup.LayoutParams lp = view.LayoutParameters;
            lp.Height += getStatusBarHeight(context);//增高
            view.SetPadding(view.PaddingLeft, view.PaddingTop + getStatusBarHeight(context),
                    view.PaddingRight, view.PaddingBottom);
        }
    }
    /** 增加View上边距（MarginTop）一般是给高度为 WARP_CONTENT 的小控件用的*/
    public static void setMargin(Context context, View view) {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean) { // 16
            ViewGroup.LayoutParams lp = view.LayoutParameters;
            if (lp is ViewGroup.MarginLayoutParams) {
                ((ViewGroup.MarginLayoutParams) lp).TopMargin += getStatusBarHeight(context);//增高
            }
            view.LayoutParameters = lp;
        }
    }
    /**
     * 创建假的透明栏
     */
    public static void setTranslucentView(ViewGroup container, int color, float alpha) {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat) { // 19
            int _mixtureColor = mixtureColor(color, alpha);
            View translucentView = container.FindViewById(Android.Resource.Id.Custom);
            if (translucentView == null && _mixtureColor != 0) {
                translucentView = new View(container.Context);
                translucentView.Id = Android.Resource.Id.Custom;
                ViewGroup.LayoutParams lp = new ViewGroup.LayoutParams(
                        ViewGroup.LayoutParams.MatchParent, getStatusBarHeight(container.Context));
                container.AddView(translucentView, lp);
            }
            if (translucentView != null) {
                translucentView.SetBackgroundColor(new Android.Graphics.Color(_mixtureColor));
            }
        }
    }

    public static int mixtureColor(int color, float alpha) {
        int a = (color & 0x000000) == 0 ? 0xff : color >> 24;
        return (color & 0xffffff) | (((int) (a * alpha)) << 24);
    }

    /** 获取状态栏高度 */
    public static int getStatusBarHeight(Context context) {
        int result = 24;
        int resId = context.Resources.GetIdentifier("status_bar_height", "dimen", "android");
        if (resId > 0) {
            result = context.Resources.GetDimensionPixelSize(resId);
        } else {
            result = (int) TypedValue.ApplyDimension(ComplexUnitType.Dip,
                    result, Resources.System.DisplayMetrics);
        }
        return result;
    }
    }
}