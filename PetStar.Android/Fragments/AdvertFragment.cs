﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Util;
using Android.Views;
using Android.Widget;
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
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var view = inflater.Inflate(Resource.Layout.AdvertFragment, container, false);
            var viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager1);

            var activity = this.Activity as MainActivity;

            var adapter = new AdvertAdapter(activity.SupportFragmentManager);
            viewPager.Adapter = adapter;

            return view;
        }
    }
}