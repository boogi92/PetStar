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
using PetStarAndroid.Fragments.Authorization;

namespace PetStarAndroid.Activitys
{
    [Activity(Label = "Авторизация")]
    public class AuthorizationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Authorization);

            if (false)
            {
                this.FragmentCommit(new AuthorizationFragment(), "Authorization");
            }
            else
            {
                this.FragmentCommit(new TutorialFragment(), "Tutorial");
            }
        }

        private void FragmentCommit(Fragment fragment, string name)
        {
            var transaction = FragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.AutfraContainer, fragment, name);
            transaction.Commit();
        }
    }
}