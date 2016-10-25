using MspRoadShowMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Pages;

namespace MspRoadShowMobileApp.Views
{
    public partial class SpeakersPage : Xamarin.Forms.Pages.ListDataPage
    {
        public SpeakersPage()
        {
            this.BackgroundImage = "bg.png";
            InitializeComponent();
            var items = DataSourceProperty;


        }
    }
}
