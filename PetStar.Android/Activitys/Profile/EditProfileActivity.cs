﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PetStarAndroid.Activitys.Profile
{
    [Activity(Label = "EditProfileActivity")]
    public class EditProfileActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.EditProfile);
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}