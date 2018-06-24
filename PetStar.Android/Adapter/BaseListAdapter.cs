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

namespace PetStarAndroid.Adapter
{
    public abstract class BaseListAdapter<T> : BaseAdapter<T>
    {
        protected List<T> Lists;

        public BaseListAdapter(List<T> lists)
        {
            Lists = lists;
        }

        public override T this[int position]
        {
            get
            {
                return Lists[position];
            }
        }

        public override int Count
        {
            get
            {
                return Lists.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            return default(View);
        }
    }
}