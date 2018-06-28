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
using PetStarAndroid.Model;
using PetStarAndroid.ViewHolder;

namespace PetStarAndroid.Adapter
{
    public class PostListAdapter : BaseListAdapter<PostModel>
    {
        public PostListAdapter(List<PostModel> users) : base(users) { }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.UserPost, parent, false);

                var imagePostUser = view.FindViewById<ImageView>(Resource.Id.imagePostUser);
                var imagePost = view.FindViewById<ImageView>(Resource.Id.imagePost);
                var textNickname = view.FindViewById<TextView>(Resource.Id.textNickname);
                var textTopPost = view.FindViewById<TextView>(Resource.Id.textTopPost);
                var commentCount = view.FindViewById<TextView>(Resource.Id.commentCount);
                var likeCount = view.FindViewById<TextView>(Resource.Id.likeCount);

                view.Tag = new PostListViewHolder()
                {
                    ImagePost = imagePost,
                    ImagePostUser = imagePostUser,
                    LikeCount = likeCount,
                    CommentCount =  commentCount,
                    TextNickname =  textNickname, 
                    TextTopPost = textTopPost
                };
            }

            var holder = (PostListViewHolder)view.Tag;
            
            holder.ImagePostUser.Background = ImageManager.Get(parent.Context, Lists[position].IconUrl);
            holder.ImagePost.Background = ImageManager.Get(parent.Context, Lists[position].PostUrl);
            holder.LikeCount.Text = Lists[position].LikeCount;
            holder.CommentCount.Text = Lists[position].CommentCount;
            holder.TextNickname.Text = Lists[position].Nickname;
            holder.TextTopPost.Text = Lists[position].TextPost;

            return view;

        }
    }
}