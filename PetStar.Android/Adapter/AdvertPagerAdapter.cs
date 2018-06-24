using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using PetStarAndroid.Fragments.Advert;

namespace PetStarAndroid.Adapter
{
    public class AdvertPagerAdapter : FragmentPagerAdapter
    {

        const int PAGE_COUNT = 3;
        private string[] tabTitles = { "ПОДПИСКИ", "ПРОДАМ", "ОТДАМ" };
        readonly Context context;

        public AdvertPagerAdapter(Context context, Android.Support.V4.App.FragmentManager fm) : base(fm)
        {
            this.context = context;
        }

        public override int Count
        {
            get { return tabTitles.Count(); }
        }


        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0 : return AdventSubscribersFragment.Instance();
                case 1 : return AdventSubscribersFragment.Instance();
                default : return AdventSubscribersFragment.Instance();
            }
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            // Generate title based on item position
            return CharSequence.ArrayFromStringArray(tabTitles)[position];
        }

        public Android.Support.V4.App.Fragment GetTabView(int position)
        {
            //var tv = (TextView)LayoutInflater.From(context).Inflate(Resource.Layout.custom_tab, null);
            //tv.Text = tabTitles[position];
            //return tv;

            switch (position)
            {
                case 0: return AdventSubscribersFragment.Instance();
                case 1: return AdventSubscribersFragment.Instance();
                default: return AdventSubscribersFragment.Instance();
            }
        }
    }


}