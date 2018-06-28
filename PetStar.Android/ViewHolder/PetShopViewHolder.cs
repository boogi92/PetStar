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

namespace PetStarAndroid.ViewHolder
{
    public class PetShopViewHolder : Java.Lang.Object
    {
        public ImageView ImagePetShop { get; set; }
        public TextView TextNamePetShop { get; set; }
        public TextView TextAdrresPetShop { get; set; }
        public TextView TextDistance { get; set; }
    }
}