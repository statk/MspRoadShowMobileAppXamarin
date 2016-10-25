using MspRoadShowMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public partial class SpeakersView : ContentPage
    {
        public SpeakersView()
        {
            this.BindingContext = new SpeakerViewModel();
            InitializeComponent();
            this.BackgroundImage = "bg.png";
           // mweb.Scale = 0.2;

            
        }
        public void SpeakerItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}
