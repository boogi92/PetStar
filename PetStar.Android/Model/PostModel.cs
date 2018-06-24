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

namespace PetStarAndroid.Model
{
    public class PostModel
    {
        public int Id { get; set; }

        public string IconUrl { get; set; }

        public string Nickname { get; set; }

        public string TextPost { get; set; }

        public string PostUrl { get; set; }

        public string CommentCount { get; set; }

        public string LikeCount { get; set; }

    }
}