using MspRoadShowMobileApp.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using System.Net.Http;

namespace MspRoadShowMobileApp.ViewModels
{
    public class SheduleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SheduleModel> _shedule = new ObservableCollection<SheduleModel>();
        public ObservableCollection<SheduleModel> Shedule
        {
            get
            {
                return _shedule;
            }
            set
            {
                _shedule = value;
                OnPropertyChanged("Shedule");
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this,new PropertyChangedEventArgs(property));
        }
        public SheduleViewModel()
        {

            LoadData();
        }

        private async void LoadData()
        {
          
            var email = await DependencyService.Get<ISaveAndLoad>().LoadText("email.txt");
            var client = new HttpClient();
            var shedule = await client.GetStringAsync($"http://msproadshow.azurewebsites.net/api/TopicsByUser?usermail=bav2212@gmail.com");
            Shedule = JsonConvert.DeserializeObject<ObservableCollection<SheduleModel>>(shedule);

        }
    }
}
