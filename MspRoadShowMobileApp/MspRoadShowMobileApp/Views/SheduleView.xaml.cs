using MspRoadShowMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public partial class SheduleView : ContentPage
    {
        public SheduleView()
        {
            InitializeComponent();
            this.Title = "Особистий кабінет";
            this.BindingContext = new SheduleViewModel();
            this.BackgroundImage = "bg.png";
            
            
        }
        public void SheduleItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
