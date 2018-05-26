using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using PetStarAndroid.Fragments;

namespace PetStarAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private TextView _textMessage;

        private OrganizationFragment organizationFragment;
        private AdvertFragment AdvertFragment;
        private CharityFragment CharityFragment;
        private ProfileFragment ProfileFragment;
        private PublicationsFragment PublicationsFragment;
        private Fragment CurrentFragment;

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_publications:

                    if (PublicationsFragment == null)
                    {
                        this.PublicationsFragment = new PublicationsFragment();
                        this.FragmentCommit(PublicationsFragment, "Publications");
                    }
                    ShowFragment(PublicationsFragment);

                    return true;
                case Resource.Id.navigation_advert:

                    if (AdvertFragment == null)
                    {
                        AdvertFragment = new AdvertFragment();
                        this.FragmentCommit(AdvertFragment, "Advert");
                    }
                    ShowFragment(AdvertFragment);
                    return true;
                case Resource.Id.navigation_charity:

                    if (CharityFragment == null)
                    {
                        CharityFragment = new CharityFragment();
                        this.FragmentCommit(CharityFragment, "Charity");
                    }
                    ShowFragment(CharityFragment);
                    return true;
                case Resource.Id.navigation_organization:

                    if (organizationFragment == null)
                    {
                        organizationFragment = new OrganizationFragment();
                        this.FragmentCommit(organizationFragment, "Organization");
                    }
                    ShowFragment(organizationFragment);
                    return true;
                case Resource.Id.navigation_account:

                    if (ProfileFragment == null)
                    {
                        ProfileFragment = new ProfileFragment();
                        this.FragmentCommit(ProfileFragment, "Profile");
                    }
                    ShowFragment(ProfileFragment);
                    return true;
            }
            return false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            this.PublicationsFragment = new PublicationsFragment();
            this.CurrentFragment = PublicationsFragment;
            this.FragmentCommit(PublicationsFragment, "Publications");



            _textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }

        private void ShowFragment(Fragment fragment)
        {
            if (fragment.IsVisible)
            {
                return;
            }

            var trans = FragmentManager.BeginTransaction();
            trans.Hide(CurrentFragment);
            trans.Show(fragment);
            CurrentFragment = fragment;
            trans.Commit();
        }

        private void FragmentCommit(Fragment fragment, string name)
        {
            var transaction = FragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.fragmentContainer, fragment, name);
            transaction.Commit();
        }
    }
}

