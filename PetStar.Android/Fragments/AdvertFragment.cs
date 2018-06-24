using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Util;
using Android.Views;
using Android.Support.V7.Widget;
using PetStarAndroid.Adapter;

namespace PetStarAndroid.Fragments
{
    public class AdvertFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view =  inflater.Inflate(Resource.Layout.AdvertFragment, container, false);
            var activity = (MainActivity)this.Activity;

            var pager = view.FindViewById<ViewPager>(Resource.Id.pager);
            var tabLayout = view.FindViewById<TabLayout>(Resource.Id.sliding_tabs);
            var adapter = new AdvertPagerAdapter(activity, activity.SupportFragmentManager);

            pager.Adapter = adapter;

            // Setup tablayout with view pager
            tabLayout.SetupWithViewPager(pager);

            // Iterate over all tabs and set the custom view
            for (int i = 0; i < tabLayout.TabCount; i++)
            {
                var tab = tabLayout.GetTabAt(i);
                //tab.SetCustomView(adapter.GetTabView(i));
            }
            return view;
        }
    }
}