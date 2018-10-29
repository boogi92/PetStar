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

namespace PetStarAndroid.Fragments.Authorization
{
    public class TutorialFragment : Fragment
    {
        private int Curent = 0;

        private TextView TextView = null;

        private ImageView ImageView = null;

        public TutorialModel [] list = new TutorialModel[]
        {
            new TutorialModel
            {
                Url = Resource.Mipmap.step1,
                Text = "Добро пожаловать в PETSTAR — место, где вы и ваши питомцы будут в центре внимания"
            },

            new TutorialModel
            {
                Url = Resource.Mipmap.step2,
                Text = "Создавайте профили ваших питомцев, публикуйте фото или видео и отмечайте их"
            },

            new TutorialModel
            {
                Url = Resource.Mipmap.step3,
                Text = "Ищите себе новых питомцев или найдите кому отдать и продать своих питомцев"
            },

            new TutorialModel
            {
                Url = Resource.Mipmap.step4,
                Text = "Учавствуйте в благовторительных акциях и делайте пожертвования выбраным животным из приютов"
            }           
        };

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            var view = inflater.Inflate(Resource.Layout.Tutorial, container, false);

            var bt = view.FindViewById<Button>(Resource.Id.TutNextBt);
            this.TextView = view.FindViewById<TextView>(Resource.Id.TutText);
            this.ImageView = view.FindViewById<ImageView>(Resource.Id.TutImage);


            this.ImageView.SetBackgroundResource(this.list[this.Curent].Url);
            this.TextView.Text = list[this.Curent].Text;

            bt.Click += delegate 
            {
                if (this.Curent < 3)
                {
                    this.Curent++;
                    this.ImageView.SetBackgroundResource(this.list[this.Curent].Url);
                    this.TextView.Text = list[this.Curent].Text;
                }
            };

            return view;

        }

        public class TutorialModel
        {
            public int Url { get; set; }

            public string Text { get; set; }

        }

    }
}