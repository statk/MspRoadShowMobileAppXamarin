using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            this.Title = "Menu";
            this.BackgroundColor = Color.White;
            InitializeComponent();
            var gestSpeakers = new TapGestureRecognizer();
            gestSpeakers.Tapped += (s, e) => 
            {
                switch (Device.OS)
                {
                    case TargetPlatform.Other:
                        Navigation.PushModalAsync(new MasterPage(new SpeakersView())); break;
                    case TargetPlatform.iOS:
                        Navigation.PushModalAsync(new MasterPage(new SpeakersView())); break;
                    case TargetPlatform.Android:
                        Navigation.PushModalAsync(new MasterPage(new SpeakersView())); break;
                    case TargetPlatform.WinPhone:
                    case TargetPlatform.Windows:
                        Navigation.PushModalAsync(new MasterPage(new SpeakersView())); break;
                    default:
                        break;
                }
                
            };
            mSpeakers.GestureRecognizers.Add(gestSpeakers);
            mSpeakersI.GestureRecognizers.Add(gestSpeakers);
            var gestCity = new TapGestureRecognizer();
            gestCity.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new MasterPage(new CityView()));
            };
            mCity.GestureRecognizers.Add(gestCity);
            mCityI.GestureRecognizers.Add(gestCity);

            var gestCabinet = new TapGestureRecognizer();
            gestCabinet.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new MasterPage(new SheduleView()));
            };
            mCabinet.GestureRecognizers.Add(gestCabinet);
            mCabinetI.GestureRecognizers.Add(gestCabinet);

            var gestLogOut = new TapGestureRecognizer();
            gestLogOut.Tapped += async (s, e) =>
              {
                  var sure = await DisplayAlert("Вихід", "Ви впевненні що бажаете вийти?", "Так", "Ні");
                  if (!sure)
                      return;
                  else
                  {
                      await DependencyService.Get<ISaveAndLoad>().DeleteFile("email.txt");
                      await Navigation.PushModalAsync(new LoginView());
                  }
              };
            mLogOut.GestureRecognizers.Add(gestLogOut);
            mLogOutI.GestureRecognizers.Add(gestLogOut);

        }
    }
}
