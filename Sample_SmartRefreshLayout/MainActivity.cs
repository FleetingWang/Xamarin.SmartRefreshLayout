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

namespace Sample_SmartRefreshLayout
{
    [Android.App.Activity(Label = "@string/title_activity_index_main", 
        MainLauncher = true, 
        Icon = "@mipmap/ic_launcher", 
        RoundIcon = "@mipmap/ic_launcher",
        Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        ViewPager mViewPager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_index_main);

            var fragmentsDic = new CacheFragment[]
            {
                new CacheFragment(this, Resource.Id.navigation_practice, typeof(RefreshPractiveFragment)),
                new CacheFragment(this, Resource.Id.navigation_style, typeof(RefreshStylesFragment)),
                new CacheFragment(this, Resource.Id.navigation_using, typeof(RefreshUsingFragment))
            };

            mViewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            mViewPager.Adapter = new SimpleFragmentStatePagerAdapter(SupportFragmentManager, fragmentsDic);

            var navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.NavigationItemSelected += (sender, e) => {
                mViewPager.SetCurrentItem(e.Item.ItemId, true);
            };

            navigation.SelectedItemId = Resource.Id.navigation_style;
        }

        private class SimpleFragmentStatePagerAdapter: FragmentStatePagerAdapter
        {
            public readonly CacheFragment[] CacheFragments;

            public SimpleFragmentStatePagerAdapter(FragmentManager fm,
                CacheFragment[] cacheFragments) 
                : base(fm)
            {
                CacheFragments = cacheFragments;
            }

            public override Fragment GetItem(int position)
            {
                return CacheFragments[position].Fragment;
            }

            public override int Count => CacheFragments.Length;
        }

        private class CacheFragment
        {
            public int MenuId;
            public Type Type;
            private Context _context;
            public CacheFragment(Context context, int menuId, Type type)
            {
                _context = context;
                MenuId = menuId;
                Type = type;
            }
            private Fragment fragment;
            public Fragment Fragment 
                => fragment ?? (fragment = Fragment.Instantiate(_context, Java.Lang.Class.FromType(Type).Name));
        }


    }
}

