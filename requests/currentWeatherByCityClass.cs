/*****************
 * @author: ilozan00@fesb.hr
 * @brief: College project weather application for PRO1
 * ***************/
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

        public string visibility { get; set; }

        public IList<Weather> weather { get; set; }

        public string name { get; set; }

        public string id { get; set; }

        public IList <string> errorMessages { get; set; }
    }
}
