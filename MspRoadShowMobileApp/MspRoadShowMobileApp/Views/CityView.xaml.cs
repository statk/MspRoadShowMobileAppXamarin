using MspRoadShowMobileApp.Models;
using MspRoadShowMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public partial class CityView : ContentPage
    {
        public CityView()
        {
            this.BackgroundImage = "bg.png";
            this.Title = "Міста";
            InitializeComponent();

            var context = new CityViewModel();
            this.BindingContext = context;
        }

        public async void CityItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                
                ((ListView)sender).SelectedItem = null;
                // list.SelectedItem = null;

                var item = e.SelectedItem as CityModel;

                await Navigation.PushModalAsync(new NavigationPage(new MasterPage(new TopicView(item))), true);
            }
        }
    }
}
