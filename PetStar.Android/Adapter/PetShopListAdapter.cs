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
    public class PetShopListAdapter : BaseListAdapter<PetShopModel>
    {
        public PetShopListAdapter(List<PetShopModel> users) : base(users) { }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.BaseList, parent, false);

                var imagePetShop = view.FindViewById<ImageView>(Resource.Id.ImagePetShop);
                var textNamePetShop = view.FindViewById<TextView>(Resource.Id.textNamePetShop);
                var textAdrresPetShop = view.FindViewById<TextView>(Resource.Id.textAdrresPetShop);
                var textDistance = view.FindViewById<TextView>(Resource.Id.textDistance);

                view.Tag = new PetShopViewHolder()
                {
                    ImagePetShop = imagePetShop,
                    TextNamePetShop = textNamePetShop,
                    TextAdrresPetShop = textAdrresPetShop,
                    TextDistance = textDistance
                };
            }

            var holder = (PetShopViewHolder)view.Tag;

            holder.ImagePetShop.Background = ImageManager.Get(parent.Context, Lists[position].Url);
            holder.TextNamePetShop.Text = Lists[position].Name;
            holder.TextAdrresPetShop.Text = Lists[position].Adrres;

    

            holder.TextDistance.Text = "500 м";

            return view;

        }
    }
}