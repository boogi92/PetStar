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

namespace PetStarAndroid.Model
{
    public class PetShopModel
    {
        public int Id { get; set; }

        public string Url { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Adrres { get; set; }
        /// <summary>
        /// Штрота
        /// </summary>
        public decimal Latitude { get; set; }
        /// <summary>
        /// Долгота
        /// </summary>
        public decimal Longitude { get; set; }
    }
}