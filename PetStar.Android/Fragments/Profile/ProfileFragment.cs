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
using PetStarAndroid.Activitys.Profile;

namespace PetStarAndroid.Fragments.Profile
{
    public class ProfileFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view =  inflater.Inflate(Resource.Layout.ProfileFragment, container, false);

            var btnEditProf = view.FindViewById<Button>(Resource.Id.btnEditProf);
            var btnSetting = view.FindViewById<Button>(Resource.Id.btnSetting);

            btnEditProf.Click += delegate
            {
                var intent = new Intent(this.Activity, typeof(EditProfileActivity));
                StartActivity(intent);
            };

            btnSetting.Click += delegate
            {
                var intent = new Intent(this.Activity, typeof(SettingProfileActivity));
                StartActivity(intent);
            };
            return view;
        }
    }
}