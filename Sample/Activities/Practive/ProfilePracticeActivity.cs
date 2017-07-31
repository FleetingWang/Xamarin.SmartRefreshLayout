using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Sample.Utils;

namespace Sample.Activities.Practive
{
    [Activity(Label = "@string/title_activity_practice_profile")]
    public class ProfilePracticeActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_practice_profile);

            var mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.NavigationClick += (sender, e) => { Finish(); };

            //状态栏透明和间距处理
            StatusBarUtil.darkMode(this);
            StatusBarUtil.setPaddingSmart(this, mToolbar);
            StatusBarUtil.setPaddingSmart(this, FindViewById(Resource.Id.profile));
            StatusBarUtil.setPaddingSmart(this, FindViewById(Resource.Id.blurview));
        }
    }
}