using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using PetStarAndroid.Fragments.Advert;

namespace PetStarAndroid.Adapter
{
    public class AdvertAdapter : FragmentPagerAdapter
    {
        public AdvertAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
        {
        }

        public override int Count
        {
            get { return 4; }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return AdventSubscribersFragment.Instance();
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String("Problem " + (position + 1));
        }
    }
}