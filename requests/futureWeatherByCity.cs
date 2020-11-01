using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace WeatherApp.requests
{
    public class List
    {
        public int dt { get; set; }

        public Main main;

        public Weather weather;

        public Wind wind;
    }
    public class futureWeatherByCityResponseObject
    {
        public string cnt { get; set; }

        public IList <List> list { get; set; }

        public IList <string> errorMessages { get; set; }
        
    }
}
