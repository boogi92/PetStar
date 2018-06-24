﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace PetStarAndroid.Fragments.Advert
{
    public class AdventGiftFragment : Android.Support.V4.App.Fragment
    {
        public static AdventGiftFragment Instance()
        {
            var fragment = new AdventGiftFragment();

            Bundle args = new Bundle();
            fragment.Arguments = args;

            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.AdvertFragment, container, false);
            return view;

        }
    }
}