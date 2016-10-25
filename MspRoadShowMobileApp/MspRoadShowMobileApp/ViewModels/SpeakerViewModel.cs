using MspRoadShowMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShowMobileApp.ViewModels
{
    public class SpeakerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SpeakerModel> _speakerList = new ObservableCollection<SpeakerModel>();
        public ObservableCollection<SpeakerModel> SpeakerList
        {
            get
            {
                return _speakerList;
            }
            set
            {
                _speakerList = value;
                OnPropertyChanged("SpeakerList");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public SpeakerViewModel()
        {
            LoadData();
        }

        private async void LoadData()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("http://msproadshowdev.azurewebsites.net/api/Speakers");
            SpeakerList = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<SpeakerModel>>(result);
            SpeakerList[0].imageLink = "http://msproadshow.azurewebsites.net/Content/Images/Sponsors/itstep.png";
            SpeakerList[1].imageLink = "http://msproadshow.azurewebsites.net/Content/Images/Speakers/lapchevskyi.jpg";
            SpeakerList[2].imageLink = "http://msproadshow.azurewebsites.net/styles/img/test-avatar.png";
            SpeakerList[3].imageLink = "http://msproadshow.azurewebsites.net/styles/img/test-avatar.png";
            SpeakerList[4].imageLink = "http://msproadshow.azurewebsites.net/Content/Images/Speakers/lubenets.jpg";
            SpeakerList[5].imageLink = "http://msproadshow.azurewebsites.net/styles/img/test-avatar.png";
            SpeakerList[6].imageLink = "http://msproadshow.azurewebsites.net/Content/Images/Speakers/vlasov.png";
            SpeakerList[7].imageLink = "http://msproadshow.azurewebsites.net/styles/img/test-avatar.png";
            SpeakerList[8].imageLink = "http://msproadshow.azurewebsites.net/Content/Images/Speakers/koval.jpg";
            SpeakerList[9].imageLink = "http://msproadshow.azurewebsites.net/Content/Images/Speakers/stativkin.jpg";
            SpeakerList[10].imageLink = "http://msproadshow.azurewebsites.net/styles/img/test-avatar.png";
            SpeakerList[11].imageLink = "http://msproadshow.azurewebsites.net/styles/img/test-avatar.png";


        }

    }
}
