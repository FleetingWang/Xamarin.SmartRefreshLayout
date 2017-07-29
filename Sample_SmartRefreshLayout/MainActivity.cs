using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.App;
using System.Collections.Generic;
using Sample_SmartRefreshLayout.Fragments;
using static Android.Support.Design.Widget.BottomNavigationView;
using Java.Lang;

namespace Sample_SmartRefreshLayout
{
    [Android.App.Activity(Label = "@string/title_activity_index_main", 
        MainLauncher = true, 
        Icon = "@mipmap/ic_launcher", 
        RoundIcon = "@mipmap/ic_launcher",
        Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private class CacheFragment
        {
            public static CacheFragment[] List = new CacheFragment[]
            {
                new CacheFragment(Resource.Id.navigation_practice, typeof(RefreshPractiveFragment)),
                new CacheFragment(Resource.Id.navigation_style, typeof(RefreshStylesFragment)),
                new CacheFragment(Resource.Id.navigation_using, typeof(RefreshUsingFragment))
            };
            public int MenuId;
            public Class Clazz;
            public CacheFragment(int menuId, Type type)
            {
                MenuId = menuId;
                Clazz = Class.FromType(type);
            }

            private Fragment fragment;
            public Fragment Fragment
                => fragment ?? (fragment = Clazz.NewInstance() as Fragment);
        }

        ViewPager mViewPager;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_index_main);

            mViewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            mViewPager.Adapter = new SimpleFragmentStatePagerAdapter(SupportFragmentManager, CacheFragment.List);

            var navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);

            mViewPager.PageSelected += (sender, e) => {
                navigation.SelectedItemId = CacheFragment.List[e.Position].MenuId;
            };

            navigation.SelectedItemId = Resource.Id.navigation_using;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int position = 1;
            for(var i = 0;i< CacheFragment.List.Length; i++)
            {
                var cacheFragment = CacheFragment.List[i];
                if(cacheFragment.MenuId == item.ItemId)
                {
                    position = i;
                    break;
                }
            }
            mViewPager.SetCurrentItem(position, true);
            return true;
        }

        private class SimpleFragmentStatePagerAdapter: FragmentStatePagerAdapter
        {
            public readonly CacheFragment[] CacheFragments;
            public SimpleFragmentStatePagerAdapter(FragmentManager fm,
                CacheFragment[] cacheFragments): base(fm)
            {
                CacheFragments = cacheFragments;
            }

            public override Fragment GetItem(int position)
            {
                return CacheFragments[position].Fragment;
            }

            public override int Count => CacheFragments.Length;
        }
        
    }
}

