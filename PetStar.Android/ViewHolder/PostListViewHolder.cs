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
    public class PostListViewHolder : Java.Lang.Object
    {
        public ImageView ImagePostUser { get; set; }
        public ImageView ImagePost { get; set; }
        public TextView TextNickname { get; set; }
        public TextView TextTopPost { get; set; }
        public TextView CommentCount { get; set; }
        public TextView LikeCount { get; set; }
    }
}