using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShowMobileApp.Models
{
    public class  CityModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime eventDate { get; set; }
        public string location { get; set; }
        public int index { get; set; }
        public string cssClassName { get; set; }
        public string img { set; get; }
        public string textColor { set; get; }
        public string url { set; get; }
    }
}
