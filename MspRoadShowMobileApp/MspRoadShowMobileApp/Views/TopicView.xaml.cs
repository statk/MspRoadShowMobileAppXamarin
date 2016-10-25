using MspRoadShowMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public partial class TopicView : ContentPage
    {
        public TopicView()
        {
            this.BackgroundImage = "bg.png";
            InitializeComponent();
        }
        public TopicView(CityModel item)
        {
          
            this.BackgroundImage = "bg.png";
            this.BindingContext = item;
            InitializeComponent();
            var gest = new TapGestureRecognizer();
            gest.Tapped += (s, e) =>
             {
                var adress = WebUtility.UrlEncode($"{item.location},{item.name}");
                 switch (Device.OS)
                 {
                     case TargetPlatform.iOS:
                         Device.OpenUri(
                             new Uri(string.Format("http://maps.apple.com/?q={0}", adress)));
                         break;
                     case TargetPlatform.Android:
                         Device.OpenUri(
                             new Uri(string.Format("geo:0,0?q={0}", adress))); //"357+Avenue+du+Professeur+Etienne+Antonelli,+34070+Montpellier"
                         break;
                     case TargetPlatform.Windows:
                     case TargetPlatform.WinPhone:
                         Device.OpenUri(
                             new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString($"{item.location},{item.name}"))));
                         break;
                 }
             };

            myPointer.GestureRecognizers.Add(gest);
            myLabel.GestureRecognizers.Add(gest);
        }
    }
}
