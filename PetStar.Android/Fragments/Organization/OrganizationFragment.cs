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

namespace PetStarAndroid.Fragments.Organization
{
    public class OrganizationFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.OrganizationFragment, container, false);

            var listView = view.FindViewById<ListView>(Resource.Id.listViewOrganization);

            var Posts = new List<PetShopModel>()
            {
                new PetShopModel
                {
                    Url = "avatar.png",
                    Name ="Мокрый нос",
                    Adrres = "ул. Дуси Ковальчук, 73, к2",
                },
                new PetShopModel
                {
                    Url = "list_fon.png",
                    Name ="Мокрый нос",
                    Adrres = "ул. Дуси Ковальчук, 73, к2",
                },
                new PetShopModel
                {
                    Url = "list_fon.png",
                    Name ="Мокрый нос",
                    Adrres = "ул. Дуси Ковальчук, 73, к2",
                },
                new PetShopModel
                {
                    Url = "list_fon.png",
                    Name ="Мокрый нос",
                    Adrres = "ул. Дуси Ковальчук, 73, к2",
                },
                new PetShopModel
                {
                    Url = "list_fon.png",
                    Name ="Мокрый нос",
                    Adrres = "ул. Дуси Ковальчук, 73, к2",
                },
            };
            listView.Adapter = new PetShopListAdapter(Posts);

            return view;

        }
    }
}