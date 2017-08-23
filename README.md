# Xamarin.SmartRefreshLayout
Xamarin.Android binding for [scwang90/SmartRefreshLayout](https://github.com/scwang90/SmartRefreshLayout)
## Android智能下拉刷新框架-SmartRefreshLayout
### 原版介绍: [English](https://raw.githubusercontent.com/scwang90/SmartRefreshLayout/master/README_EN.md) | [中文](https://raw.githubusercontent.com/scwang90/SmartRefreshLayout/master/README.md)
示例App已改写为Xamarin.Android，[代码](https://github.com/wtffly/Xamarin.SmartRefreshLayout/tree/master/Sample)
#### 项目演示
![](art/gif_practive_weibo.gif) ![](art/gif_practive_feedlist.gif)

![](art/gif_practive_repast.gif) ![](art/gif_practive_profile.gif)

#### 风格演示
![](art/gif_Delivery.gif) ![](art/gif_Dropbox.gif)

上面这两个是我自己实现的Header，设计来自：[Refresh-your-delivery](https://dribbble.com/shots/2753803-Refresh-your-delivery)，[Dropbox-Refresh](https://dribbble.com/shots/3470499-Dropbox-Refresh)

下面的Header是我把github上其它优秀的Header进行的整理和集合还有优化：

![](art/gif_BezierRadar.gif) ![](art/gif_Circle.gif)

整理来自：[TwinklingRefreshLayout](https://github.com/lcodecorex/TwinklingRefreshLayout/blob/master/art/gif_recyclerview2.gif)，[Pull Down To Refresh](https://dribbble.com/shots/1797373-Pull-Down-To-Refresh)

![](art/gif_FlyRefresh.gif) ![](art/gif_Classics.gif)

整理来自：[FlyRefresh](https://github.com/race604/FlyRefresh)，[ClassicsHeader](#1)

![](art/gif_Phoenix.gif) ![](art/gif_Taurus.gif)

整理来自：[Yalantis/Phoenix](https://github.com/Yalantis/Phoenix)，[Yalantis/Taurus](https://github.com/Yalantis/Taurus)

![](art/gif_BattleCity.gif) ![](art/gif_HitBlock.gif)

整理来自：[FunGame/BattleCity](https://github.com/Hitomis/FunGameRefresh)，[FunGame/HitBlock](https://github.com/Hitomis/FunGameRefresh)

![](art/gif_WaveSwipe.gif) ![](art/gif_Material.gif)

整理来自：[WaveSwipeRefreshLayout](https://github.com/recruit-lifestyle/WaveSwipeRefreshLayout)，[MaterialHeader](https://developer.android.com/reference/android/support/v4/widget/SwipeRefreshLayout.html)

![](art/gif_StoreHouse.gif) ![](art/gif_WaterDrop.gif)

整理来自：[Ultra-Pull-To-Refresh](https://github.com/liaohuqiu/android-Ultra-Pull-To-Refresh)，[WaterDrop](https://github.com/THEONE10211024/WaterDropListView)


看到这么多炫酷的Header，是不是觉得很棒？这时你或许会担心这么多的Header集成在一起，但是平时只会用到一个，是不是要引入很多无用的代码和资源？  
请放心，我已经把刷新布局分成三个包啦，用到的时候自行引用就可以啦！

 - SmartRefreshLayout 刷新布局核心实现，自带ClassicsHeader（经典）、BezierRadarHeader（贝塞尔雷达）两个 Header.
 - SmartRefreshHeader 各种Header的集成，除了Layout自带的Header，其它都在这个包中.
 - SmartRefreshFooter 各种Footer的集成，除了Layout自带的Footer，其它都在这个包中.

 ### 感谢
 #### 原作者
 [scwang90/SmartRefreshLayout](https://github.com/scwang90/SmartRefreshLayout)
 #### Xamarin.Android绑定使用的VS插件
 [Xamarin.GradleBindings](https://github.com/EgorBo/Xamarin.GradleBindings)
 #### 示例绑定及使用的组件：
 [android-gif-drawable](https://github.com/koral--/android-gif-drawable) 绑定：[Binding_AndroidGifDrawable](https://github.com/wtffly/Xamarin.SmartRefreshLayout/tree/master/AndroidBindings/Binding_AndroidGifDrawable)  
 [CircleImageView](https://github.com/hdodenhof/CircleImageView) 绑定：[Binding_CircleimageView](https://github.com/wtffly/Xamarin.SmartRefreshLayout/tree/master/AndroidBindings/Binding_CircleimageView)  
 [FlycoRoundView](https://github.com/H07000223/FlycoRoundView) 绑定：[Binding_FlycoRoundViewLib](https://github.com/wtffly/Xamarin.SmartRefreshLayout/tree/master/AndroidBindings/Binding_FlycoRoundViewLib)  
 [RealtimeBlurView](https://github.com/mmin18/RealtimeBlurView) 绑定：[Binding_RealtimeblurView](https://github.com/wtffly/Xamarin.SmartRefreshLayout/tree/master/AndroidBindings/Binding_RealtimeblurView)  
 [recyclerview-animators](https://github.com/wasabeef/recyclerview-animators) 绑定：[Binding_RecyclerViewAnimators](https://github.com/wtffly/Xamarin.SmartRefreshLayout/tree/master/AndroidBindings/Binding_RecyclerViewAnimators)  

 License
-------

    Copyright 2017 wtffly

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
