using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WeatherApp
{

    public class Main
    {
        public string temp { get; set; }

        public string humidty { get; set; }

        public string temp_min { get; set; }

        public string temp_max { get; set; }


    }

    public class Wind
    {
        public string speed { get; set; }
        
        public string deg { get; set; }
    }

    public class Temp
    {
        public string temp { get; set; }
        public string humidity { get; set; }
    }

    public class Weather
    {
        public string icon { get; set; }
        public string main { get; set; }
        public string description { get; set; }
    }
    public class currentWeatherResponseObject
    {
        public Main main;

        public Temp temp;

        public Wind wind;

        public IList < Weather > weather { get; set; }

        public string name { get; set; }

        public string id { get; set; }
    }
}
