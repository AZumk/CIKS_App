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
using Android.Content.PM;
using CIKS;
using Android.Support.V4.View;
using Android.Support.V4.App;



namespace App_CIKS.Activities
{
    [Activity(Label = "Resumo do Conteúdo", Theme = "@android:style/Theme.Holo.Light.NoActionBar", MainLauncher = true, ScreenOrientation = ScreenOrientation.SensorLandscape)]
    public class ResumoActivity : Activity
    {

        private ViewPager mViewPager;
        private SlidingTabScrollView mScrollView;

        public Android.Support.V4.App.FragmentManager SupportFragmentManager { get; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Resumo);


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.actionbar_main, menu);
            return base.OnCreateOptionsMenu(menu);
        }

    }

    public class SamplePagerAdapter : FragmentPagerAdapter
    {
        private List<Android.Support.V4.App.Fragment> mFragmentHolder;

        public SamplePagerAdapter(Android.Support.V4.App.FragmentManager fragManager) : base(fragManager)
        {
            mFragmentHolder = new List<Android.Support.V4.App.Fragment>();
            mFragmentHolder.Add(new Fragment1());
            mFragmentHolder.Add(new Fragment2());
            mFragmentHolder.Add(new Fragment3());
        }

        public override int Count
        {
            get { return mFragmentHolder.Count; }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return mFragmentHolder[position];
        }
    }



    public class Fragment1 : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.resumo_frag1, container, false);
            return view;

        }

        public override string ToString() //Called on line 156 in SlidingTabScrollView
        {
            return "Fragment 1";
        }
    }

    public class Fragment2 : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.resumo_frag2, container, false);
            return view;
        }

        public override string ToString() //Called on line 156 in SlidingTabScrollView
        {
            return "Fragment 2";
        }
    }

    public class Fragment3 : Android.Support.V4.App.Fragment
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.resumo_frag3, container, false);
            return view;
        }

        public override string ToString() //Called on line 156 in SlidingTabScrollView
        {
            return "Fragment 3";
        }
    }
}
