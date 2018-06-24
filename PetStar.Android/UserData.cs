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

namespace PetStarAndroid
{
    public static class UserData
    {
        public static List<User> Users { get; private set; }

        static UserData()
        {
            var temp = new List<User>();

            AddUser(temp);
            AddUser(temp);
            AddUser(temp);

            Users = temp.OrderBy(i => i.Name).ToList();
        }

        static void AddUser(List<User> users)
        {
            users.Add(new User()
            {
                Name = "aVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "avatar.png",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });

            users.Add(new User()
            {
                Name = "bVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "avatar.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "bVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "avatar.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });

            users.Add(new User()
            {
                Name = "aVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "avatar.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            }); users.Add(new User()
            {
                Name = "dVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "avatar.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
        }
    }
}