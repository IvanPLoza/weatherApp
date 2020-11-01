/*****************
 * @author: ilozan00@fesb.hr
 * @brief: College project weather application for PRO1
 * ***************/
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.requests
{
    public class Weather
    {
        public string icon { get; set; }
        public string main { get; set; }
        public string description { get; set; }
    }

    public class Main
    {
        public string temp { get; set; }

        public string humidity { get; set; }

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

    public class ListW
    {
        public int dt { get; set; }

        public string visibility { get; set; }

        public Main main;

        public IList<Weather> weather;

        public Wind wind;
    }


    //I needed to have inheritance example so I will create errorMessages from this class and inherit it into request classes
    public class ErrorList
    {
        public string[] errorMessages { get; set; } 
    }
}
