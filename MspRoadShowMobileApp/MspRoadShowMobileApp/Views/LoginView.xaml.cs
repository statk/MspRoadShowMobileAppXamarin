using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {

            Start();
            this.BackgroundImage = "Splash.png";
            InitializeComponent();
            btnLog.BackgroundColor = Color.Blue;
            login.Keyboard = Keyboard.Email;
            btnLog.Clicked += async (s, e) =>
             {
                 await DependencyService.Get<ISaveAndLoad>().SaveText("email.txt",login.Text);
                 await Navigation.PushModalAsync(new MasterPage(new SheduleView()));
             };
            
        }

        private async void Start()
        {
            var isLoged = await DependencyService.Get<ISaveAndLoad>().IsFIleExist("email.txt");
            if (!isLoged)
                return; //
            else await Navigation.PushModalAsync(new MasterPage(new SheduleView()));
        }

        


    }
}
