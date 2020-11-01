using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WeatherApp.requests
{

    public class currentWeatherResponseObject
    {
        public Main main;

        public Temp temp;

        public Wind wind;

        public IList<Weather> weather { get; set; }

        public string name { get; set; }

        public string id { get; set; }

        public IList <string> errorMessages { get; set; }
    }
}
