using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']"
	[Register ("com/scwang/smartrefresh/layout/api/RefreshLayout", "", "Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker")]
	public partial interface IRefreshLayout : global::Android.Support.V4.View.INestedScrollingChild, global::Android.Support.V4.View.INestedScrollingParent {

		bool IsEnableAutoLoadmore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isEnableAutoLoadmore' and count(parameter)=0]"
			[Register ("isEnableAutoLoadmore", "()Z", "GetIsEnableAutoLoadmoreHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsEnableLoadmore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isEnableLoadmore' and count(parameter)=0]"
			[Register ("isEnableLoadmore", "()Z", "GetIsEnableLoadmoreHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsEnableOverScrollBounce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isEnableOverScrollBounce' and count(parameter)=0]"
			[Register ("isEnableOverScrollBounce", "()Z", "GetIsEnableOverScrollBounceHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsEnablePureScrollMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isEnablePureScrollMode' and count(parameter)=0]"
			[Register ("isEnablePureScrollMode", "()Z", "GetIsEnablePureScrollModeHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsEnableRefresh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isEnableRefresh' and count(parameter)=0]"
			[Register ("isEnableRefresh", "()Z", "GetIsEnableRefreshHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsEnableScrollContentWhenLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isEnableScrollContentWhenLoaded' and count(parameter)=0]"
			[Register ("isEnableScrollContentWhenLoaded", "()Z", "GetIsEnableScrollContentWhenLoadedHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsLoading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isLoading' and count(parameter)=0]"
			[Register ("isLoading", "()Z", "GetIsLoadingHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsLoadmoreFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isLoadmoreFinished' and count(parameter)=0]"
			[Register ("isLoadmoreFinished", "()Z", "GetIsLoadmoreFinishedHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		bool IsRefreshing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='isRefreshing' and count(parameter)=0]"
			[Register ("isRefreshing", "()Z", "GetIsRefreshingHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Android.Views.ViewGroup Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()Landroid/view/ViewGroup;", "GetGetLayoutHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter RefreshFooter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='getRefreshFooter' and count(parameter)=0]"
			[Register ("getRefreshFooter", "()Lcom/scwang/smartrefresh/layout/api/RefreshFooter;", "GetGetRefreshFooterHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader RefreshHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='getRefreshHeader' and count(parameter)=0]"
			[Register ("getRefreshHeader", "()Lcom/scwang/smartrefresh/layout/api/RefreshHeader;", "GetGetRefreshHeaderHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/scwang/smartrefresh/layout/constant/RefreshState;", "GetGetStateHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='autoLoadmore' and count(parameter)=0]"
		[Register ("autoLoadmore", "()Z", "GetAutoLoadmoreHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		bool AutoLoadmore ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='autoLoadmore' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("autoLoadmore", "(I)Z", "GetAutoLoadmore_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		bool AutoLoadmore (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='autoLoadmore' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("autoLoadmore", "(IF)Z", "GetAutoLoadmore_IFHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		bool AutoLoadmore (int p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='autoRefresh' and count(parameter)=0]"
		[Register ("autoRefresh", "()Z", "GetAutoRefreshHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		bool AutoRefresh ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='autoRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("autoRefresh", "(I)Z", "GetAutoRefresh_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		bool AutoRefresh (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='autoRefresh' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("autoRefresh", "(IF)Z", "GetAutoRefresh_IFHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		bool AutoRefresh (int p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishLoadmore' and count(parameter)=0]"
		[Register ("finishLoadmore", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadmoreHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishLoadmore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("finishLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadmore_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishLoadmore' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("finishLoadmore", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadmore_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishLoadmore' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("finishLoadmore", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishLoadmore_IZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishRefresh' and count(parameter)=0]"
		[Register ("finishRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefreshHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("finishRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefresh_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishRefresh' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("finishRefresh", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefresh_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='finishRefresh' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("finishRefresh", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetFinishRefresh_IZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setDisableContentWhenLoading' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableContentWhenLoading", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetDisableContentWhenLoading_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenLoading (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setDisableContentWhenRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableContentWhenRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetDisableContentWhenRefresh_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenRefresh (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetDragRate_FHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDragRate (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableAutoLoadmore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableAutoLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableAutoLoadmore_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableAutoLoadmore (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableFooterTranslationContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableFooterTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableFooterTranslationContent_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableFooterTranslationContent (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableHeaderTranslationContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableHeaderTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableHeaderTranslationContent_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableHeaderTranslationContent (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableLoadmore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableLoadmore_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableLoadmore (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableOverScrollBounce' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableOverScrollBounce", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableOverScrollBounce_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableOverScrollBounce (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnablePureScrollMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnablePureScrollMode", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnablePureScrollMode_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnablePureScrollMode (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableRefresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableRefresh_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableRefresh (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setEnableScrollContentWhenLoaded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableScrollContentWhenLoaded", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetEnableScrollContentWhenLoaded_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableScrollContentWhenLoaded (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setFooterHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFooterHeight", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterHeight_FHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeight (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setFooterHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFooterHeightPx", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterHeightPx_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeightPx (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setFooterMaxDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFooterMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetFooterMaxDragRate_FHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterMaxDragRate (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setHeaderHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHeaderHeight", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderHeight_FHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeight (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setHeaderHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderHeightPx", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderHeightPx_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeightPx (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setHeaderMaxDragRate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHeaderMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetHeaderMaxDragRate_FHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderMaxDragRate (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setLoadmoreFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoadmoreFinished", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetLoadmoreFinished_ZHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetLoadmoreFinished (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setOnLoadmoreListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnLoadmoreListener']]"
		[Register ("setOnLoadmoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnLoadmoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnLoadmoreListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setOnMultiPurposeListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnMultiPurposeListener']]"
		[Register ("setOnMultiPurposeListener", "(Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnMultiPurposeListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setOnRefreshListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnRefreshListener']]"
		[Register ("setOnRefreshListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setOnRefreshLoadmoreListener' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.listener.OnRefreshLoadmoreListener']]"
		[Register ("setOnRefreshLoadmoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshLoadmoreListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setPrimaryColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setPrimaryColors", "([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetPrimaryColors_arrayIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColors (params  int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setPrimaryColorsId' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setPrimaryColorsId", "([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetPrimaryColorsId_arrayIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColorsId (params  int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setReboundDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReboundDuration", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetReboundDuration_IHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundDuration (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setReboundInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setReboundInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetReboundInterpolator_Landroid_view_animation_Interpolator_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundInterpolator (global::Android.Views.Animations.IInterpolator p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setRefreshFooter' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter']]"
		[Register ("setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setRefreshFooter' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshFooter'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setRefreshHeader' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader']]"
		[Register ("setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setRefreshHeader' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshHeader'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.api']/interface[@name='RefreshLayout']/method[@name='setRefreshScrollBoundary' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshScrollBoundary']]"
		[Register ("setRefreshScrollBoundary", "(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;", "GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler:Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayoutInvoker, Binding_SmartRefreshLayout")]
		global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshScrollBoundary (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary p0);

	}

	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/api/RefreshLayout", DoNotGenerateAcw=true)]
	internal class IRefreshLayoutInvoker : global::Android.Views.ViewGroup, IRefreshLayout {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/scwang/smartrefresh/layout/api/RefreshLayout", typeof (IRefreshLayoutInvoker));

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

		public static IRefreshLayout GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRefreshLayout> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.scwang.smartrefresh.layout.api.RefreshLayout"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRefreshLayoutInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isEnableAutoLoadmore;
#pragma warning disable 0169
		static Delegate GetIsEnableAutoLoadmoreHandler ()
		{
			if (cb_isEnableAutoLoadmore == null)
				cb_isEnableAutoLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableAutoLoadmore);
			return cb_isEnableAutoLoadmore;
		}

		static bool n_IsEnableAutoLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableAutoLoadmore;
		}
#pragma warning restore 0169

		IntPtr id_isEnableAutoLoadmore;
		public unsafe bool IsEnableAutoLoadmore {
			get {
				if (id_isEnableAutoLoadmore == IntPtr.Zero)
					id_isEnableAutoLoadmore = JNIEnv.GetMethodID (class_ref, "isEnableAutoLoadmore", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableAutoLoadmore);
			}
		}

		static Delegate cb_isEnableLoadmore;
#pragma warning disable 0169
		static Delegate GetIsEnableLoadmoreHandler ()
		{
			if (cb_isEnableLoadmore == null)
				cb_isEnableLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableLoadmore);
			return cb_isEnableLoadmore;
		}

		static bool n_IsEnableLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableLoadmore;
		}
#pragma warning restore 0169

		IntPtr id_isEnableLoadmore;
		public unsafe bool IsEnableLoadmore {
			get {
				if (id_isEnableLoadmore == IntPtr.Zero)
					id_isEnableLoadmore = JNIEnv.GetMethodID (class_ref, "isEnableLoadmore", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableLoadmore);
			}
		}

		static Delegate cb_isEnableOverScrollBounce;
#pragma warning disable 0169
		static Delegate GetIsEnableOverScrollBounceHandler ()
		{
			if (cb_isEnableOverScrollBounce == null)
				cb_isEnableOverScrollBounce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableOverScrollBounce);
			return cb_isEnableOverScrollBounce;
		}

		static bool n_IsEnableOverScrollBounce (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableOverScrollBounce;
		}
#pragma warning restore 0169

		IntPtr id_isEnableOverScrollBounce;
		public unsafe bool IsEnableOverScrollBounce {
			get {
				if (id_isEnableOverScrollBounce == IntPtr.Zero)
					id_isEnableOverScrollBounce = JNIEnv.GetMethodID (class_ref, "isEnableOverScrollBounce", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableOverScrollBounce);
			}
		}

		static Delegate cb_isEnablePureScrollMode;
#pragma warning disable 0169
		static Delegate GetIsEnablePureScrollModeHandler ()
		{
			if (cb_isEnablePureScrollMode == null)
				cb_isEnablePureScrollMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnablePureScrollMode);
			return cb_isEnablePureScrollMode;
		}

		static bool n_IsEnablePureScrollMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnablePureScrollMode;
		}
#pragma warning restore 0169

		IntPtr id_isEnablePureScrollMode;
		public unsafe bool IsEnablePureScrollMode {
			get {
				if (id_isEnablePureScrollMode == IntPtr.Zero)
					id_isEnablePureScrollMode = JNIEnv.GetMethodID (class_ref, "isEnablePureScrollMode", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnablePureScrollMode);
			}
		}

		static Delegate cb_isEnableRefresh;
#pragma warning disable 0169
		static Delegate GetIsEnableRefreshHandler ()
		{
			if (cb_isEnableRefresh == null)
				cb_isEnableRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableRefresh);
			return cb_isEnableRefresh;
		}

		static bool n_IsEnableRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableRefresh;
		}
#pragma warning restore 0169

		IntPtr id_isEnableRefresh;
		public unsafe bool IsEnableRefresh {
			get {
				if (id_isEnableRefresh == IntPtr.Zero)
					id_isEnableRefresh = JNIEnv.GetMethodID (class_ref, "isEnableRefresh", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableRefresh);
			}
		}

		static Delegate cb_isEnableScrollContentWhenLoaded;
#pragma warning disable 0169
		static Delegate GetIsEnableScrollContentWhenLoadedHandler ()
		{
			if (cb_isEnableScrollContentWhenLoaded == null)
				cb_isEnableScrollContentWhenLoaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableScrollContentWhenLoaded);
			return cb_isEnableScrollContentWhenLoaded;
		}

		static bool n_IsEnableScrollContentWhenLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableScrollContentWhenLoaded;
		}
#pragma warning restore 0169

		IntPtr id_isEnableScrollContentWhenLoaded;
		public unsafe bool IsEnableScrollContentWhenLoaded {
			get {
				if (id_isEnableScrollContentWhenLoaded == IntPtr.Zero)
					id_isEnableScrollContentWhenLoaded = JNIEnv.GetMethodID (class_ref, "isEnableScrollContentWhenLoaded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableScrollContentWhenLoaded);
			}
		}

		static Delegate cb_isLoading;
#pragma warning disable 0169
		static Delegate GetIsLoadingHandler ()
		{
			if (cb_isLoading == null)
				cb_isLoading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoading);
			return cb_isLoading;
		}

		static bool n_IsLoading (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoading;
		}
#pragma warning restore 0169

		IntPtr id_isLoading;
		public unsafe bool IsLoading {
			get {
				if (id_isLoading == IntPtr.Zero)
					id_isLoading = JNIEnv.GetMethodID (class_ref, "isLoading", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoading);
			}
		}

		static Delegate cb_isLoadmoreFinished;
#pragma warning disable 0169
		static Delegate GetIsLoadmoreFinishedHandler ()
		{
			if (cb_isLoadmoreFinished == null)
				cb_isLoadmoreFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoadmoreFinished);
			return cb_isLoadmoreFinished;
		}

		static bool n_IsLoadmoreFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoadmoreFinished;
		}
#pragma warning restore 0169

		IntPtr id_isLoadmoreFinished;
		public unsafe bool IsLoadmoreFinished {
			get {
				if (id_isLoadmoreFinished == IntPtr.Zero)
					id_isLoadmoreFinished = JNIEnv.GetMethodID (class_ref, "isLoadmoreFinished", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoadmoreFinished);
			}
		}

		static Delegate cb_isRefreshing;
#pragma warning disable 0169
		static Delegate GetIsRefreshingHandler ()
		{
			if (cb_isRefreshing == null)
				cb_isRefreshing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRefreshing);
			return cb_isRefreshing;
		}

		static bool n_IsRefreshing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefreshing;
		}
#pragma warning restore 0169

		IntPtr id_isRefreshing;
		public unsafe bool IsRefreshing {
			get {
				if (id_isRefreshing == IntPtr.Zero)
					id_isRefreshing = JNIEnv.GetMethodID (class_ref, "isRefreshing", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRefreshing);
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayout);
			return cb_getLayout;
		}

		static IntPtr n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Layout);
		}
#pragma warning restore 0169

		IntPtr id_getLayout;
		public unsafe global::Android.Views.ViewGroup Layout {
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()Landroid/view/ViewGroup;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLayout), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefreshFooter;
#pragma warning disable 0169
		static Delegate GetGetRefreshFooterHandler ()
		{
			if (cb_getRefreshFooter == null)
				cb_getRefreshFooter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshFooter);
			return cb_getRefreshFooter;
		}

		static IntPtr n_GetRefreshFooter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshFooter);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshFooter;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter RefreshFooter {
			get {
				if (id_getRefreshFooter == IntPtr.Zero)
					id_getRefreshFooter = JNIEnv.GetMethodID (class_ref, "getRefreshFooter", "()Lcom/scwang/smartrefresh/layout/api/RefreshFooter;");
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshFooter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRefreshHeader;
#pragma warning disable 0169
		static Delegate GetGetRefreshHeaderHandler ()
		{
			if (cb_getRefreshHeader == null)
				cb_getRefreshHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshHeader);
			return cb_getRefreshHeader;
		}

		static IntPtr n_GetRefreshHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RefreshHeader);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshHeader;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader RefreshHeader {
			get {
				if (id_getRefreshHeader == IntPtr.Zero)
					id_getRefreshHeader = JNIEnv.GetMethodID (class_ref, "getRefreshHeader", "()Lcom/scwang/smartrefresh/layout/api/RefreshHeader;");
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshHeader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		IntPtr id_getState;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState State {
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/scwang/smartrefresh/layout/constant/RefreshState;");
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_autoLoadmore;
#pragma warning disable 0169
		static Delegate GetAutoLoadmoreHandler ()
		{
			if (cb_autoLoadmore == null)
				cb_autoLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AutoLoadmore);
			return cb_autoLoadmore;
		}

		static bool n_AutoLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLoadmore ();
		}
#pragma warning restore 0169

		IntPtr id_autoLoadmore;
		public unsafe bool AutoLoadmore ()
		{
			if (id_autoLoadmore == IntPtr.Zero)
				id_autoLoadmore = JNIEnv.GetMethodID (class_ref, "autoLoadmore", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_autoLoadmore);
		}

		static Delegate cb_autoLoadmore_I;
#pragma warning disable 0169
		static Delegate GetAutoLoadmore_IHandler ()
		{
			if (cb_autoLoadmore_I == null)
				cb_autoLoadmore_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_AutoLoadmore_I);
			return cb_autoLoadmore_I;
		}

		static bool n_AutoLoadmore_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLoadmore (p0);
		}
#pragma warning restore 0169

		IntPtr id_autoLoadmore_I;
		public unsafe bool AutoLoadmore (int p0)
		{
			if (id_autoLoadmore_I == IntPtr.Zero)
				id_autoLoadmore_I = JNIEnv.GetMethodID (class_ref, "autoLoadmore", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_autoLoadmore_I, __args);
		}

		static Delegate cb_autoLoadmore_IF;
#pragma warning disable 0169
		static Delegate GetAutoLoadmore_IFHandler ()
		{
			if (cb_autoLoadmore_IF == null)
				cb_autoLoadmore_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, bool>) n_AutoLoadmore_IF);
			return cb_autoLoadmore_IF;
		}

		static bool n_AutoLoadmore_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoLoadmore (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_autoLoadmore_IF;
		public unsafe bool AutoLoadmore (int p0, float p1)
		{
			if (id_autoLoadmore_IF == IntPtr.Zero)
				id_autoLoadmore_IF = JNIEnv.GetMethodID (class_ref, "autoLoadmore", "(IF)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_autoLoadmore_IF, __args);
		}

		static Delegate cb_autoRefresh;
#pragma warning disable 0169
		static Delegate GetAutoRefreshHandler ()
		{
			if (cb_autoRefresh == null)
				cb_autoRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_AutoRefresh);
			return cb_autoRefresh;
		}

		static bool n_AutoRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoRefresh ();
		}
#pragma warning restore 0169

		IntPtr id_autoRefresh;
		public unsafe bool AutoRefresh ()
		{
			if (id_autoRefresh == IntPtr.Zero)
				id_autoRefresh = JNIEnv.GetMethodID (class_ref, "autoRefresh", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_autoRefresh);
		}

		static Delegate cb_autoRefresh_I;
#pragma warning disable 0169
		static Delegate GetAutoRefresh_IHandler ()
		{
			if (cb_autoRefresh_I == null)
				cb_autoRefresh_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_AutoRefresh_I);
			return cb_autoRefresh_I;
		}

		static bool n_AutoRefresh_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoRefresh (p0);
		}
#pragma warning restore 0169

		IntPtr id_autoRefresh_I;
		public unsafe bool AutoRefresh (int p0)
		{
			if (id_autoRefresh_I == IntPtr.Zero)
				id_autoRefresh_I = JNIEnv.GetMethodID (class_ref, "autoRefresh", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_autoRefresh_I, __args);
		}

		static Delegate cb_autoRefresh_IF;
#pragma warning disable 0169
		static Delegate GetAutoRefresh_IFHandler ()
		{
			if (cb_autoRefresh_IF == null)
				cb_autoRefresh_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, bool>) n_AutoRefresh_IF);
			return cb_autoRefresh_IF;
		}

		static bool n_AutoRefresh_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoRefresh (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_autoRefresh_IF;
		public unsafe bool AutoRefresh (int p0, float p1)
		{
			if (id_autoRefresh_IF == IntPtr.Zero)
				id_autoRefresh_IF = JNIEnv.GetMethodID (class_ref, "autoRefresh", "(IF)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_autoRefresh_IF, __args);
		}

		static Delegate cb_finishLoadmore;
#pragma warning disable 0169
		static Delegate GetFinishLoadmoreHandler ()
		{
			if (cb_finishLoadmore == null)
				cb_finishLoadmore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FinishLoadmore);
			return cb_finishLoadmore;
		}

		static IntPtr n_FinishLoadmore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore ());
		}
#pragma warning restore 0169

		IntPtr id_finishLoadmore;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore ()
		{
			if (id_finishLoadmore == IntPtr.Zero)
				id_finishLoadmore = JNIEnv.GetMethodID (class_ref, "finishLoadmore", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishLoadmore), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishLoadmore_Z;
#pragma warning disable 0169
		static Delegate GetFinishLoadmore_ZHandler ()
		{
			if (cb_finishLoadmore_Z == null)
				cb_finishLoadmore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_FinishLoadmore_Z);
			return cb_finishLoadmore_Z;
		}

		static IntPtr n_FinishLoadmore_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore (p0));
		}
#pragma warning restore 0169

		IntPtr id_finishLoadmore_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (bool p0)
		{
			if (id_finishLoadmore_Z == IntPtr.Zero)
				id_finishLoadmore_Z = JNIEnv.GetMethodID (class_ref, "finishLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishLoadmore_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishLoadmore_I;
#pragma warning disable 0169
		static Delegate GetFinishLoadmore_IHandler ()
		{
			if (cb_finishLoadmore_I == null)
				cb_finishLoadmore_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FinishLoadmore_I);
			return cb_finishLoadmore_I;
		}

		static IntPtr n_FinishLoadmore_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore (p0));
		}
#pragma warning restore 0169

		IntPtr id_finishLoadmore_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (int p0)
		{
			if (id_finishLoadmore_I == IntPtr.Zero)
				id_finishLoadmore_I = JNIEnv.GetMethodID (class_ref, "finishLoadmore", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishLoadmore_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishLoadmore_IZ;
#pragma warning disable 0169
		static Delegate GetFinishLoadmore_IZHandler ()
		{
			if (cb_finishLoadmore_IZ == null)
				cb_finishLoadmore_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_FinishLoadmore_IZ);
			return cb_finishLoadmore_IZ;
		}

		static IntPtr n_FinishLoadmore_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishLoadmore (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_finishLoadmore_IZ;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishLoadmore (int p0, bool p1)
		{
			if (id_finishLoadmore_IZ == IntPtr.Zero)
				id_finishLoadmore_IZ = JNIEnv.GetMethodID (class_ref, "finishLoadmore", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishLoadmore_IZ, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishRefresh;
#pragma warning disable 0169
		static Delegate GetFinishRefreshHandler ()
		{
			if (cb_finishRefresh == null)
				cb_finishRefresh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FinishRefresh);
			return cb_finishRefresh;
		}

		static IntPtr n_FinishRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh ());
		}
#pragma warning restore 0169

		IntPtr id_finishRefresh;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh ()
		{
			if (id_finishRefresh == IntPtr.Zero)
				id_finishRefresh = JNIEnv.GetMethodID (class_ref, "finishRefresh", "()Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishRefresh), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishRefresh_Z;
#pragma warning disable 0169
		static Delegate GetFinishRefresh_ZHandler ()
		{
			if (cb_finishRefresh_Z == null)
				cb_finishRefresh_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_FinishRefresh_Z);
			return cb_finishRefresh_Z;
		}

		static IntPtr n_FinishRefresh_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh (p0));
		}
#pragma warning restore 0169

		IntPtr id_finishRefresh_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (bool p0)
		{
			if (id_finishRefresh_Z == IntPtr.Zero)
				id_finishRefresh_Z = JNIEnv.GetMethodID (class_ref, "finishRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishRefresh_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishRefresh_I;
#pragma warning disable 0169
		static Delegate GetFinishRefresh_IHandler ()
		{
			if (cb_finishRefresh_I == null)
				cb_finishRefresh_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_FinishRefresh_I);
			return cb_finishRefresh_I;
		}

		static IntPtr n_FinishRefresh_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh (p0));
		}
#pragma warning restore 0169

		IntPtr id_finishRefresh_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (int p0)
		{
			if (id_finishRefresh_I == IntPtr.Zero)
				id_finishRefresh_I = JNIEnv.GetMethodID (class_ref, "finishRefresh", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishRefresh_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishRefresh_IZ;
#pragma warning disable 0169
		static Delegate GetFinishRefresh_IZHandler ()
		{
			if (cb_finishRefresh_IZ == null)
				cb_finishRefresh_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_FinishRefresh_IZ);
			return cb_finishRefresh_IZ;
		}

		static IntPtr n_FinishRefresh_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FinishRefresh (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_finishRefresh_IZ;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout FinishRefresh (int p0, bool p1)
		{
			if (id_finishRefresh_IZ == IntPtr.Zero)
				id_finishRefresh_IZ = JNIEnv.GetMethodID (class_ref, "finishRefresh", "(IZ)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishRefresh_IZ, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setDisableContentWhenLoading_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableContentWhenLoading_ZHandler ()
		{
			if (cb_setDisableContentWhenLoading_Z == null)
				cb_setDisableContentWhenLoading_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableContentWhenLoading_Z);
			return cb_setDisableContentWhenLoading_Z;
		}

		static IntPtr n_SetDisableContentWhenLoading_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableContentWhenLoading (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDisableContentWhenLoading_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenLoading (bool p0)
		{
			if (id_setDisableContentWhenLoading_Z == IntPtr.Zero)
				id_setDisableContentWhenLoading_Z = JNIEnv.GetMethodID (class_ref, "setDisableContentWhenLoading", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableContentWhenLoading_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setDisableContentWhenRefresh_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableContentWhenRefresh_ZHandler ()
		{
			if (cb_setDisableContentWhenRefresh_Z == null)
				cb_setDisableContentWhenRefresh_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDisableContentWhenRefresh_Z);
			return cb_setDisableContentWhenRefresh_Z;
		}

		static IntPtr n_SetDisableContentWhenRefresh_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisableContentWhenRefresh (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDisableContentWhenRefresh_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDisableContentWhenRefresh (bool p0)
		{
			if (id_setDisableContentWhenRefresh_Z == IntPtr.Zero)
				id_setDisableContentWhenRefresh_Z = JNIEnv.GetMethodID (class_ref, "setDisableContentWhenRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisableContentWhenRefresh_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetDragRate_FHandler ()
		{
			if (cb_setDragRate_F == null)
				cb_setDragRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetDragRate_F);
			return cb_setDragRate_F;
		}

		static IntPtr n_SetDragRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDragRate (p0));
		}
#pragma warning restore 0169

		IntPtr id_setDragRate_F;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetDragRate (float p0)
		{
			if (id_setDragRate_F == IntPtr.Zero)
				id_setDragRate_F = JNIEnv.GetMethodID (class_ref, "setDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDragRate_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableAutoLoadmore_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableAutoLoadmore_ZHandler ()
		{
			if (cb_setEnableAutoLoadmore_Z == null)
				cb_setEnableAutoLoadmore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableAutoLoadmore_Z);
			return cb_setEnableAutoLoadmore_Z;
		}

		static IntPtr n_SetEnableAutoLoadmore_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableAutoLoadmore (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableAutoLoadmore_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableAutoLoadmore (bool p0)
		{
			if (id_setEnableAutoLoadmore_Z == IntPtr.Zero)
				id_setEnableAutoLoadmore_Z = JNIEnv.GetMethodID (class_ref, "setEnableAutoLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableAutoLoadmore_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableFooterTranslationContent_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableFooterTranslationContent_ZHandler ()
		{
			if (cb_setEnableFooterTranslationContent_Z == null)
				cb_setEnableFooterTranslationContent_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableFooterTranslationContent_Z);
			return cb_setEnableFooterTranslationContent_Z;
		}

		static IntPtr n_SetEnableFooterTranslationContent_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableFooterTranslationContent (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableFooterTranslationContent_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableFooterTranslationContent (bool p0)
		{
			if (id_setEnableFooterTranslationContent_Z == IntPtr.Zero)
				id_setEnableFooterTranslationContent_Z = JNIEnv.GetMethodID (class_ref, "setEnableFooterTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableFooterTranslationContent_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableHeaderTranslationContent_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableHeaderTranslationContent_ZHandler ()
		{
			if (cb_setEnableHeaderTranslationContent_Z == null)
				cb_setEnableHeaderTranslationContent_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableHeaderTranslationContent_Z);
			return cb_setEnableHeaderTranslationContent_Z;
		}

		static IntPtr n_SetEnableHeaderTranslationContent_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableHeaderTranslationContent (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableHeaderTranslationContent_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableHeaderTranslationContent (bool p0)
		{
			if (id_setEnableHeaderTranslationContent_Z == IntPtr.Zero)
				id_setEnableHeaderTranslationContent_Z = JNIEnv.GetMethodID (class_ref, "setEnableHeaderTranslationContent", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableHeaderTranslationContent_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableLoadmore_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableLoadmore_ZHandler ()
		{
			if (cb_setEnableLoadmore_Z == null)
				cb_setEnableLoadmore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableLoadmore_Z);
			return cb_setEnableLoadmore_Z;
		}

		static IntPtr n_SetEnableLoadmore_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableLoadmore (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableLoadmore_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableLoadmore (bool p0)
		{
			if (id_setEnableLoadmore_Z == IntPtr.Zero)
				id_setEnableLoadmore_Z = JNIEnv.GetMethodID (class_ref, "setEnableLoadmore", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableLoadmore_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableOverScrollBounce_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableOverScrollBounce_ZHandler ()
		{
			if (cb_setEnableOverScrollBounce_Z == null)
				cb_setEnableOverScrollBounce_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableOverScrollBounce_Z);
			return cb_setEnableOverScrollBounce_Z;
		}

		static IntPtr n_SetEnableOverScrollBounce_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableOverScrollBounce (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableOverScrollBounce_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableOverScrollBounce (bool p0)
		{
			if (id_setEnableOverScrollBounce_Z == IntPtr.Zero)
				id_setEnableOverScrollBounce_Z = JNIEnv.GetMethodID (class_ref, "setEnableOverScrollBounce", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableOverScrollBounce_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnablePureScrollMode_Z;
#pragma warning disable 0169
		static Delegate GetSetEnablePureScrollMode_ZHandler ()
		{
			if (cb_setEnablePureScrollMode_Z == null)
				cb_setEnablePureScrollMode_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnablePureScrollMode_Z);
			return cb_setEnablePureScrollMode_Z;
		}

		static IntPtr n_SetEnablePureScrollMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnablePureScrollMode (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnablePureScrollMode_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnablePureScrollMode (bool p0)
		{
			if (id_setEnablePureScrollMode_Z == IntPtr.Zero)
				id_setEnablePureScrollMode_Z = JNIEnv.GetMethodID (class_ref, "setEnablePureScrollMode", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnablePureScrollMode_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableRefresh_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableRefresh_ZHandler ()
		{
			if (cb_setEnableRefresh_Z == null)
				cb_setEnableRefresh_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableRefresh_Z);
			return cb_setEnableRefresh_Z;
		}

		static IntPtr n_SetEnableRefresh_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableRefresh (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableRefresh_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableRefresh (bool p0)
		{
			if (id_setEnableRefresh_Z == IntPtr.Zero)
				id_setEnableRefresh_Z = JNIEnv.GetMethodID (class_ref, "setEnableRefresh", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableRefresh_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setEnableScrollContentWhenLoaded_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableScrollContentWhenLoaded_ZHandler ()
		{
			if (cb_setEnableScrollContentWhenLoaded_Z == null)
				cb_setEnableScrollContentWhenLoaded_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableScrollContentWhenLoaded_Z);
			return cb_setEnableScrollContentWhenLoaded_Z;
		}

		static IntPtr n_SetEnableScrollContentWhenLoaded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEnableScrollContentWhenLoaded (p0));
		}
#pragma warning restore 0169

		IntPtr id_setEnableScrollContentWhenLoaded_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetEnableScrollContentWhenLoaded (bool p0)
		{
			if (id_setEnableScrollContentWhenLoaded_Z == IntPtr.Zero)
				id_setEnableScrollContentWhenLoaded_Z = JNIEnv.GetMethodID (class_ref, "setEnableScrollContentWhenLoaded", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableScrollContentWhenLoaded_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setFooterHeight_F;
#pragma warning disable 0169
		static Delegate GetSetFooterHeight_FHandler ()
		{
			if (cb_setFooterHeight_F == null)
				cb_setFooterHeight_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetFooterHeight_F);
			return cb_setFooterHeight_F;
		}

		static IntPtr n_SetFooterHeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFooterHeight (p0));
		}
#pragma warning restore 0169

		IntPtr id_setFooterHeight_F;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeight (float p0)
		{
			if (id_setFooterHeight_F == IntPtr.Zero)
				id_setFooterHeight_F = JNIEnv.GetMethodID (class_ref, "setFooterHeight", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFooterHeight_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setFooterHeightPx_I;
#pragma warning disable 0169
		static Delegate GetSetFooterHeightPx_IHandler ()
		{
			if (cb_setFooterHeightPx_I == null)
				cb_setFooterHeightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetFooterHeightPx_I);
			return cb_setFooterHeightPx_I;
		}

		static IntPtr n_SetFooterHeightPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFooterHeightPx (p0));
		}
#pragma warning restore 0169

		IntPtr id_setFooterHeightPx_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterHeightPx (int p0)
		{
			if (id_setFooterHeightPx_I == IntPtr.Zero)
				id_setFooterHeightPx_I = JNIEnv.GetMethodID (class_ref, "setFooterHeightPx", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFooterHeightPx_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setFooterMaxDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetFooterMaxDragRate_FHandler ()
		{
			if (cb_setFooterMaxDragRate_F == null)
				cb_setFooterMaxDragRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetFooterMaxDragRate_F);
			return cb_setFooterMaxDragRate_F;
		}

		static IntPtr n_SetFooterMaxDragRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFooterMaxDragRate (p0));
		}
#pragma warning restore 0169

		IntPtr id_setFooterMaxDragRate_F;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetFooterMaxDragRate (float p0)
		{
			if (id_setFooterMaxDragRate_F == IntPtr.Zero)
				id_setFooterMaxDragRate_F = JNIEnv.GetMethodID (class_ref, "setFooterMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFooterMaxDragRate_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setHeaderHeight_F;
#pragma warning disable 0169
		static Delegate GetSetHeaderHeight_FHandler ()
		{
			if (cb_setHeaderHeight_F == null)
				cb_setHeaderHeight_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetHeaderHeight_F);
			return cb_setHeaderHeight_F;
		}

		static IntPtr n_SetHeaderHeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderHeight (p0));
		}
#pragma warning restore 0169

		IntPtr id_setHeaderHeight_F;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeight (float p0)
		{
			if (id_setHeaderHeight_F == IntPtr.Zero)
				id_setHeaderHeight_F = JNIEnv.GetMethodID (class_ref, "setHeaderHeight", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderHeight_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setHeaderHeightPx_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderHeightPx_IHandler ()
		{
			if (cb_setHeaderHeightPx_I == null)
				cb_setHeaderHeightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderHeightPx_I);
			return cb_setHeaderHeightPx_I;
		}

		static IntPtr n_SetHeaderHeightPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderHeightPx (p0));
		}
#pragma warning restore 0169

		IntPtr id_setHeaderHeightPx_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderHeightPx (int p0)
		{
			if (id_setHeaderHeightPx_I == IntPtr.Zero)
				id_setHeaderHeightPx_I = JNIEnv.GetMethodID (class_ref, "setHeaderHeightPx", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderHeightPx_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setHeaderMaxDragRate_F;
#pragma warning disable 0169
		static Delegate GetSetHeaderMaxDragRate_FHandler ()
		{
			if (cb_setHeaderMaxDragRate_F == null)
				cb_setHeaderMaxDragRate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetHeaderMaxDragRate_F);
			return cb_setHeaderMaxDragRate_F;
		}

		static IntPtr n_SetHeaderMaxDragRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderMaxDragRate (p0));
		}
#pragma warning restore 0169

		IntPtr id_setHeaderMaxDragRate_F;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetHeaderMaxDragRate (float p0)
		{
			if (id_setHeaderMaxDragRate_F == IntPtr.Zero)
				id_setHeaderMaxDragRate_F = JNIEnv.GetMethodID (class_ref, "setHeaderMaxDragRate", "(F)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderMaxDragRate_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setLoadmoreFinished_Z;
#pragma warning disable 0169
		static Delegate GetSetLoadmoreFinished_ZHandler ()
		{
			if (cb_setLoadmoreFinished_Z == null)
				cb_setLoadmoreFinished_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetLoadmoreFinished_Z);
			return cb_setLoadmoreFinished_Z;
		}

		static IntPtr n_SetLoadmoreFinished_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLoadmoreFinished (p0));
		}
#pragma warning restore 0169

		IntPtr id_setLoadmoreFinished_Z;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetLoadmoreFinished (bool p0)
		{
			if (id_setLoadmoreFinished_Z == IntPtr.Zero)
				id_setLoadmoreFinished_Z = JNIEnv.GetMethodID (class_ref, "setLoadmoreFinished", "(Z)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLoadmoreFinished_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_Handler ()
		{
			if (cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ == null)
				cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_);
			return cb_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_;
		}

		static IntPtr n_SetOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener p0 = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnLoadmoreListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnLoadmoreListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnLoadmoreListener p0)
		{
			if (id_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ == IntPtr.Zero)
				id_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_ = JNIEnv.GetMethodID (class_ref, "setOnLoadmoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnLoadmoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOnLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnLoadmoreListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_Handler ()
		{
			if (cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ == null)
				cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_);
			return cb_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
		}

		static IntPtr n_SetOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener p0 = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnMultiPurposeListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnMultiPurposeListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnMultiPurposeListener p0)
		{
			if (id_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ == IntPtr.Zero)
				id_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_ = JNIEnv.GetMethodID (class_ref, "setOnMultiPurposeListener", "(Lcom/scwang/smartrefresh/layout/listener/OnMultiPurposeListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOnMultiPurposeListener_Lcom_scwang_smartrefresh_layout_listener_OnMultiPurposeListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_Handler ()
		{
			if (cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ == null)
				cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_);
			return cb_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
		}

		static IntPtr n_SetOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener p0 = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnRefreshListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshListener p0)
		{
			if (id_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ == IntPtr.Zero)
				id_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_ = JNIEnv.GetMethodID (class_ref, "setOnRefreshListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOnRefreshListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_;
#pragma warning disable 0169
		static Delegate GetSetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_Handler ()
		{
			if (cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ == null)
				cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_);
			return cb_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_;
		}

		static IntPtr n_SetOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener p0 = (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnRefreshLoadmoreListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetOnRefreshLoadmoreListener (global::Com.Scwang.Smartrefresh.Layout.Listener.IOnRefreshLoadmoreListener p0)
		{
			if (id_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ == IntPtr.Zero)
				id_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_ = JNIEnv.GetMethodID (class_ref, "setOnRefreshLoadmoreListener", "(Lcom/scwang/smartrefresh/layout/listener/OnRefreshLoadmoreListener;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOnRefreshLoadmoreListener_Lcom_scwang_smartrefresh_layout_listener_OnRefreshLoadmoreListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setPrimaryColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColors_arrayIHandler ()
		{
			if (cb_setPrimaryColors_arrayI == null)
				cb_setPrimaryColors_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPrimaryColors_arrayI);
			return cb_setPrimaryColors_arrayI;
		}

		static IntPtr n_SetPrimaryColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPrimaryColors (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPrimaryColors_arrayI;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColors (params  int[] p0)
		{
			if (id_setPrimaryColors_arrayI == IntPtr.Zero)
				id_setPrimaryColors_arrayI = JNIEnv.GetMethodID (class_ref, "setPrimaryColors", "([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPrimaryColors_arrayI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setPrimaryColorsId_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColorsId_arrayIHandler ()
		{
			if (cb_setPrimaryColorsId_arrayI == null)
				cb_setPrimaryColorsId_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPrimaryColorsId_arrayI);
			return cb_setPrimaryColorsId_arrayI;
		}

		static IntPtr n_SetPrimaryColorsId_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPrimaryColorsId (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPrimaryColorsId_arrayI;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetPrimaryColorsId (params  int[] p0)
		{
			if (id_setPrimaryColorsId_arrayI == IntPtr.Zero)
				id_setPrimaryColorsId_arrayI = JNIEnv.GetMethodID (class_ref, "setPrimaryColorsId", "([I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPrimaryColorsId_arrayI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_setReboundDuration_I;
#pragma warning disable 0169
		static Delegate GetSetReboundDuration_IHandler ()
		{
			if (cb_setReboundDuration_I == null)
				cb_setReboundDuration_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReboundDuration_I);
			return cb_setReboundDuration_I;
		}

		static IntPtr n_SetReboundDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReboundDuration (p0));
		}
#pragma warning restore 0169

		IntPtr id_setReboundDuration_I;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundDuration (int p0)
		{
			if (id_setReboundDuration_I == IntPtr.Zero)
				id_setReboundDuration_I = JNIEnv.GetMethodID (class_ref, "setReboundDuration", "(I)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReboundDuration_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setReboundInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetReboundInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setReboundInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setReboundInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReboundInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setReboundInterpolator_Landroid_view_animation_Interpolator_;
		}

		static IntPtr n_SetReboundInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReboundInterpolator (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setReboundInterpolator_Landroid_view_animation_Interpolator_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetReboundInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setReboundInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setReboundInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setReboundInterpolator", "(Landroid/view/animation/Interpolator;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReboundInterpolator_Landroid_view_animation_Interpolator_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
#pragma warning disable 0169
		static Delegate GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_Handler ()
		{
			if (cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ == null)
				cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_);
			return cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
		}

		static IntPtr n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshFooter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0)
		{
			if (id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ == IntPtr.Zero)
				id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_ = JNIEnv.GetMethodID (class_ref, "setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
#pragma warning disable 0169
		static Delegate GetSetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_IIHandler ()
		{
			if (cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == null)
				cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II);
			return cb_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
		}

		static IntPtr n_SetRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshFooter (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshFooter (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter p0, int p1, int p2)
		{
			if (id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II == IntPtr.Zero)
				id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II = JNIEnv.GetMethodID (class_ref, "setRefreshFooter", "(Lcom/scwang/smartrefresh/layout/api/RefreshFooter;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshFooter_Lcom_scwang_smartrefresh_layout_api_RefreshFooter_II, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
#pragma warning disable 0169
		static Delegate GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_Handler ()
		{
			if (cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ == null)
				cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_);
			return cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
		}

		static IntPtr n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0)
		{
			if (id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ == IntPtr.Zero)
				id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_ = JNIEnv.GetMethodID (class_ref, "setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
#pragma warning disable 0169
		static Delegate GetSetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_IIHandler ()
		{
			if (cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == null)
				cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II);
			return cb_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
		}

		static IntPtr n_SetRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshHeader (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshHeader (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshHeader p0, int p1, int p2)
		{
			if (id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II == IntPtr.Zero)
				id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II = JNIEnv.GetMethodID (class_ref, "setRefreshHeader", "(Lcom/scwang/smartrefresh/layout/api/RefreshHeader;II)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshHeader_Lcom_scwang_smartrefresh_layout_api_RefreshHeader_II, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
#pragma warning disable 0169
		static Delegate GetSetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_Handler ()
		{
			if (cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ == null)
				cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_);
			return cb_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
		}

		static IntPtr n_SetRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary p0 = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRefreshScrollBoundary (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_;
		public unsafe global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout SetRefreshScrollBoundary (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshScrollBoundary p0)
		{
			if (id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ == IntPtr.Zero)
				id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_ = JNIEnv.GetMethodID (class_ref, "setRefreshScrollBoundary", "(Lcom/scwang/smartrefresh/layout/api/RefreshScrollBoundary;)Lcom/scwang/smartrefresh/layout/api/RefreshLayout;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout __ret = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshScrollBoundary_Lcom_scwang_smartrefresh_layout_api_RefreshScrollBoundary_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}
        
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
        }
    }

}
