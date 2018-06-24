using Android.Widget;

namespace PetStarAndroid.Model
{
    public class ViewHolder : Java.Lang.Object
    {
        public ImageView ImagePostUser { get; set; }
        public ImageView ImagePost { get; set; }
        public TextView TextNickname { get; set; }
        public TextView TextTopPost { get; set; }
        public TextView CommentCount { get; set; }
        public TextView LikeCount { get; set; }
    }
}