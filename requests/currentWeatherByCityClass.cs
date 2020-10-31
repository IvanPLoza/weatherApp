using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WeatherApp
{

    public class Temp
    {
        public string temp { get; set; }
        public string humidity { get; set; }
    }

    public class Weather
    {
        public string icon { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
    public class currentWeatherResponseObject
    {

        public Temp temp;

        public IList < Weather > weather { get; set; }

        public string name { get; set; }

        public string id { get; set; }
    }
}
