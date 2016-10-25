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
    public class CityViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<CityModel> _cityList = new ObservableCollection<CityModel>();
        public ObservableCollection<CityModel> CityList
        {
            get
            {
                return _cityList;
            }
            set
            {
                _cityList = value;
                OnPropertyChanged("CityList");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public CityViewModel()
        {
            LoadData();
        }

        private async void LoadData()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("http://msproadshow.azurewebsites.net/api/Cities");
            var cities = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<CityModel>>(result);
            foreach (var item in cities)
            {
                switch (item.id)
                {
                    case 1: CityList.Add(new CityModel {name = item.name, eventDate = item.eventDate, location = item.location, img = "cities/kyiv.png", textColor= "FF5A03", url= $"http://msproadshow.azurewebsites.net/Topics/City/{item.id}?partial=true" }); break;
                    case 2: CityList.Add(new CityModel { name = item.name, eventDate = item.eventDate, location = item.location, img = "cities/vinnitsa.png", textColor= "1C3B4F", url = $"http://msproadshow.azurewebsites.net/Topics/City/{item.id}?partial=true" }); break;
                    case 3: CityList.Add(new CityModel { name = item.name, eventDate = item.eventDate, location = item.location, img = "cities/kharkiv.png", textColor = "006955", url = $"http://msproadshow.azurewebsites.net/Topics/City/{item.id}?partial=true" }); break;
                    case 4: CityList.Add(new CityModel { name = item.name, eventDate = item.eventDate, location = item.location, img = "cities/lviv.png", textColor = "C20000", url = $"http://msproadshow.azurewebsites.net/Topics/City/{item.id}?partial=true" }); break;
                    case 5: CityList.Add(new CityModel { name = item.name, eventDate = item.eventDate, location = item.location, img = "cities/odessa.png", textColor = "99243F", url = $"http://msproadshow.azurewebsites.net/Topics/City/{item.id}?partial=true" }); break;
                    default: break;
                }
            }  

        }
    }
}
