using System;
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
using PetStarAndroid.Adapter;
using PetStarAndroid.Model;

namespace PetStarAndroid.Fragments
{
    public class PublicationsFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.PublicationsFragment, container, false);

            var listView = view.FindViewById<ListView>(Resource.Id.listView);


            var Posts = new List<PostModel>()
            {
                new PostModel
                {
                    IconUrl = "avatar.png",
                    PostUrl ="image.png",
                    Nickname = "Boogi",
                    CommentCount = "1000",
                    LikeCount = "500",
                    TextPost = "Новосибирск"
                },
                new PostModel
                {
                    IconUrl = "avatar.png",
                    PostUrl ="image.png",
                    Nickname = "Humen",
                    CommentCount = "999M",
                    LikeCount = "500M",
                    TextPost = "Новосибирск"
                }
            };
            listView.Adapter = new PostListAdapter(Posts);

            return view;
        }
    }
}